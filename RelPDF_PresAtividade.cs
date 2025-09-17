using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Reflection.Emit;
using System.Xml.Linq;

namespace NovoGEF
{
    /// <summary>
    /// Classe responsável pela geração de relatórios PDF de presença em atividades.
    /// </summary>
    class RelPDF_PresAtividade
    {
        /// <summary>
        /// Gera o relatório PDF de presença a partir de um DataTable.
        /// </summary>
        /// <param name="dt">DataTable contendo os dados de presença.</param>
        public static void GerarRelatorioPDF(DataTable dt)
        {
            if (dt.Rows.Count > 0)
            {
                //calculo do total de páginas
                //1a página - 24 registros
                //2a em diante - 29 registros
                int totalPaginas = 1;
                if (dt.Rows.Count > 24)
                    totalPaginas += (int)Math.Ceiling(
                        (dt.Rows.Count - 24) / 24F);

                //configurar dados do PDF
                var pxPorMm = 72 / 25.2F;
                var pdf = new Document(PageSize.A4, 15 * pxPorMm, 15 * pxPorMm, 15 * pxPorMm, 20 * pxPorMm);
                var arquivo = new FileStream(ParmGlobal.nomeArquivo, FileMode.Create);
                var writer = PdfWriter.GetInstance(pdf, arquivo);
                writer.PageEvent = new RodapeRelatorioPDF(totalPaginas);
                pdf.Open();

                //adiciona uma tabela
                var tabela = new PdfPTable(4);
                float[] larguras = { 0.6f, 2f, 0.6f, 2f };
                tabela.SetWidths(larguras);
                tabela.DefaultCell.BorderWidth = 0;
                tabela.WidthPercentage = 100;

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    CriarCelulaTexto(i, tabela, dt.Rows[i].Field<string>("matricula").ToString().Substring(0, 6) + "-" + dt.Rows[i].Field<string>("matricula").ToString().Substring(6, 2), PdfPCell.ALIGN_CENTER, true);
                    CriarCelulaTexto(i, tabela, dt.Rows[i].Field<string>("nome"), PdfPCell.ALIGN_LEFT, true);
                    CriarCelulaTexto(i, tabela, "[  " + dt.Rows[i].Field<string>("presenca") +  "  ]", PdfPCell.ALIGN_CENTER, true);
                    CriarCelulaTexto(i, tabela, "", PdfPCell.ALIGN_CENTER, true);
                }

                pdf.Add(tabela);

                pdf.Close();
                arquivo.Close();

                DialogResult res = MessageBox.Show("Deseja abrir o relatório?", "Relatório", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(ParmGlobal.nomeArquivo);
                }
            }
            else
            {
                MessageBox.Show("Não existem dados para imprimir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Cria uma célula de texto para a tabela do PDF.
        /// </summary>
        /// <param name="i">Índice da linha.</param>
        /// <param name="tabela">Tabela do PDF.</param>
        /// <param name="texto">Texto da célula.</param>
        /// <param name="alinhamento">Alinhamento do texto.</param>
        /// <param name="negrito">Define se o texto será negrito.</param>
        /// <param name="italico">Define se o texto será itálico.</param>
        /// <param name="tamanhoFonte">Tamanho da fonte.</param>
        /// <param name="alturaCelula">Altura da célula.</param>
        static void CriarCelulaTexto(int i, PdfPTable tabela, string texto,
            int alinhamento = PdfPCell.ALIGN_LEFT,
            bool negrito = false, bool italico = false,
            int tamanhoFonte = 10, int alturaCelula = 25)
        {
            int estilo = iTextSharp.text.Font.NORMAL;
            if (negrito && italico)
            {
                estilo = iTextSharp.text.Font.BOLDITALIC;
            }
            else if (negrito)
            {
                estilo = iTextSharp.text.Font.BOLD;
            }
            else if (italico)
            {
                estilo = iTextSharp.text.Font.ITALIC;
            }

            BaseFont fonteBase = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false);
            iTextSharp.text.Font fonte = new iTextSharp.text.Font(fonteBase, tamanhoFonte, estilo, iTextSharp.text.BaseColor.BLACK);

            //cor de fundo diferente para linhas pares e ímpares
            var bgColor = iTextSharp.text.BaseColor.WHITE;
            if (i % 2 == 1)
                bgColor = new BaseColor(0.95f, 0.95f, 0.95f);

            PdfPCell celula = new PdfPCell(new Phrase(texto, fonte));
            celula.HorizontalAlignment = alinhamento;
            celula.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
            celula.Border = 0;
            celula.BorderWidthBottom = 1;
            celula.PaddingBottom = 5;
            celula.FixedHeight = alturaCelula;
            celula.BackgroundColor = bgColor;
            tabela.AddCell(celula);
        }

        /// <summary>
        /// Cria uma célula de imagem para a tabela do PDF.
        /// </summary>
        /// <param name="tabela">Tabela do PDF.</param>
        /// <param name="caminhoImagem">Caminho da imagem.</param>
        /// <param name="larguraImagem">Largura da imagem.</param>
        /// <param name="alturaImagem">Altura da imagem.</param>
        /// <param name="alturaCelula">Altura da célula.</param>
        static void criarCelulaImagem(PdfPTable tabela, string caminhoImagem,
            int larguraImagem, int alturaImagem, int alturaCelula = 25)
        {
            var bgColor = iTextSharp.text.BaseColor.WHITE;
            if (tabela.Rows.Count % 2 == 1)
                bgColor = new BaseColor(0.95f, 0.95f, 0.95f);

            if (File.Exists(caminhoImagem))
            {
                iTextSharp.text.Image imagem =
                    iTextSharp.text.Image.GetInstance(caminhoImagem);
                imagem.ScaleToFit(larguraImagem, alturaImagem);
                PdfPCell celula = new PdfPCell(imagem);
                celula.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                celula.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                celula.Border = 0;
                celula.BorderWidthBottom = 1;
                celula.FixedHeight = alturaCelula;
                celula.BackgroundColor = bgColor;
                tabela.AddCell(celula);
            }
            else
            {
                tabela.AddCell("ERRO");
            }
        }

        /// <summary>
        /// Classe responsável por adicionar rodapé e cabeçalho ao relatório PDF.
        /// </summary>
        class RodapeRelatorioPDF : PdfPageEventHelper
        {
            BaseFont familiaFonteRodape;
            iTextSharp.text.Font fonteRodape;
            int totalPaginas = 0;

            PdfContentByte cb;
            private readonly PdfTemplate template;

            /// <summary>
            /// Inicializa o rodapé do relatório PDF.
            /// </summary>
            /// <param name="totalPaginas">Total de páginas do relatório.</param>
            public RodapeRelatorioPDF(int totalPaginas)
            {
                familiaFonteRodape = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false);
                fonteRodape = new iTextSharp.text.Font(familiaFonteRodape, 8f, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK);
                this.totalPaginas = totalPaginas;
            }

            /// <summary>
            /// Evento disparado ao abrir o documento PDF.
            /// </summary>
            public override void OnOpenDocument(PdfWriter writer, Document document)
            {
                cb = writer.DirectContent;
            }

            /// <summary>
            /// Evento disparado ao finalizar uma página do PDF.
            /// </summary>
            public override void OnEndPage(PdfWriter writer, Document document)
            {
                base.OnEndPage(writer, document);
                AdicionarMomentoDaGeracao(writer, document);
                AdicionarNumeroPaginaAtual(writer, document);
            }

            /// <summary>
            /// Adiciona a data e hora de geração do relatório no rodapé.
            /// </summary>
            private void AdicionarMomentoDaGeracao(PdfWriter writer, Document document)
            {
                String textoDataGeracao = $"Gerado em {DateTime.Now.ToShortDateString()} às " +
                    $"{DateTime.Now.ToShortTimeString()}";

                writer.DirectContent.BeginText();
                writer.DirectContent.SetFontAndSize(fonteRodape.BaseFont, fonteRodape.Size);
                writer.DirectContent.SetTextMatrix(document.LeftMargin,
                    document.BottomMargin * 0.75f);
                writer.DirectContent.ShowText(textoDataGeracao);
                writer.DirectContent.EndText();
            }

            /// <summary>
            /// Adiciona o número da página atual no rodapé.
            /// </summary>
            private void AdicionarNumeroPaginaAtual(PdfWriter writer, Document document)
            {
                int paginaAtual = writer.PageNumber;
                String textoPaginaAtual = "Página " + paginaAtual.ToString() + " de " + totalPaginas.ToString();

                float larguraTextoPaginaAtual =
                    fonteRodape.BaseFont.GetWidthPoint(textoPaginaAtual, fonteRodape.Size);

                iTextSharp.text.Rectangle tamanhoPagina = document.PageSize;

                writer.DirectContent.BeginText();
                writer.DirectContent.SetFontAndSize(fonteRodape.BaseFont, fonteRodape.Size);
                writer.DirectContent.SetTextMatrix(tamanhoPagina.Width -
                    (document.RightMargin + larguraTextoPaginaAtual),
                    document.BottomMargin * 0.75f);
                writer.DirectContent.ShowText(textoPaginaAtual);
                writer.DirectContent.EndText();
            }

            #region Não utilizado
            public override void OnStartPage(PdfWriter writer, Document document)
            {
                base.OnStartPage(writer, document);

                var fonteBase = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false);

                //adiciona um título
                var fonteParagrafo = new iTextSharp.text.Font(fonteBase, 22,
                    iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                var titulo = new Paragraph(ParmGlobal.Titulo, fonteParagrafo);
                titulo.Alignment = Element.ALIGN_LEFT;
                titulo.SpacingAfter = 4;
                document.Add(titulo);

                //adiciona uma imagem
                if (File.Exists(ParmGlobal.caminhoLogo))
                {
                    iTextSharp.text.Image logo =
                        iTextSharp.text.Image.GetInstance(ParmGlobal.caminhoLogo);
                    float razaoLarguraAltura = logo.Width / logo.Height;
                    float alturaLogo = 32;
                    float larguraLogo = alturaLogo * razaoLarguraAltura;
                    logo.ScaleToFit(larguraLogo, alturaLogo);
                    var margemEsquerda = document.PageSize.Width - document.RightMargin - larguraLogo;
                    var margemTopo = document.PageSize.Height - document.TopMargin;
                    logo.SetAbsolutePosition(margemEsquerda, margemTopo);
                    //                    writer.DirectContent.AddImage(logo, false);
                    document.Add(logo);
                }

                //adiciona uma tabela
                var tabela = new PdfPTable(4);
                float[] larguras = { 0.6f, 2f, 0.6f, 2f };
                tabela.SetWidths(larguras);
                tabela.DefaultCell.BorderWidth = 0;
                tabela.WidthPercentage = 100;

                //adiciona os títulos das colunas
                CriarCelulaTexto(0, tabela, "Matricula", PdfPCell.ALIGN_CENTER, true);
                CriarCelulaTexto(0, tabela, "Nome", PdfPCell.ALIGN_LEFT, true);
                CriarCelulaTexto(0, tabela, "Presença", PdfPCell.ALIGN_CENTER, true);
                CriarCelulaTexto(0, tabela, "Observação", PdfPCell.ALIGN_CENTER, true);
                document.Add(tabela);
            }

            private void AdicionarLogoNoCabecalho(PdfWriter writer, Document document)
            {
                //adiciona uma imagem
                var caminhoImagem = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                    "Resources\\report.png");
                if (File.Exists(caminhoImagem))
                {
                    iTextSharp.text.Image logo =
                        iTextSharp.text.Image.GetInstance(caminhoImagem);
                    logo.ScaleToFit(48, 48);
                    var margemEsquerda = document.LeftMargin;
                    var margemTopo = document.PageSize.Height - document.TopMargin - 48;
                    logo.SetAbsolutePosition(margemEsquerda, margemTopo);
                    writer.DirectContent.AddImage(logo, false);
                }
            }

            public override void OnCloseDocument(PdfWriter writer, Document document)
            {
                base.OnCloseDocument(writer, document);
                //AdicionarNumeroTotalDePaginas(writer);
            }

            private void AdicionarNumeroTotalDePaginas(PdfWriter writer)
            {
                template.BeginText();
                template.SetFontAndSize(fonteRodape.BaseFont, fonteRodape.Size);
                template.SetTextMatrix(0, 0);
                int qtdeDigitosTotalPaginas = totalPaginas.ToString().Length;
                template.ShowText((writer.PageNumber - 1).ToString($"D{qtdeDigitosTotalPaginas}"));
                template.EndText();
            }
            #endregion
        }
    }
}


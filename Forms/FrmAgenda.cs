using iTextSharp.text;
using iTextSharp.text.pdf;
using NovoGEF;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static NovoGEF.FrmAtividade;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace NovoGEF.Forms
{
    /// <summary>
    /// Formulário responsável pelo gerenciamento da agenda de associados e suas atividades.
    /// </summary>
    public partial class FrmAgenda : Form
    {
        /// <summary>
        /// Inicializa uma nova instância do formulário de agenda.
        /// </summary>
        public FrmAgenda()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento disparado ao carregar o formulário. Verifica se o usuário está logado e inicializa controles.
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            if (ParmGlobal.usuarioId == 0)
            {
                MessageBox.Show("Usuário não logado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BtnAltReg.Enabled = false;
                DtpAtividade.Enabled = false;
            }
            else
            {
                DtpAtividade.Text = DateTime.Now.ToString("yyyy/MM/dd");
            }
        }

        /// <summary>
        /// Exibe os dados do associado selecionado no grid.
        /// </summary>
        private void Mostrar_Associado()
        {
            if (DgvGeftb005.CurrentRow != null)
            {
                TbIdAgenda.Text = DgvGeftb005.Rows[DgvGeftb005.CurrentCell.RowIndex].Cells[0].Value.ToString();
                TbIdAssociado.Text = DgvGeftb005.Rows[DgvGeftb005.CurrentCell.RowIndex].Cells[2].Value.ToString();
                TbSigla.Text = DgvGeftb005.Rows[DgvGeftb005.CurrentCell.RowIndex].Cells[3].Value.ToString();
                TbMatricula.Text = DgvGeftb005.Rows[DgvGeftb005.CurrentCell.RowIndex].Cells[4].Value.ToString();
                TbNome.Text = DgvGeftb005.Rows[DgvGeftb005.CurrentCell.RowIndex].Cells[5].Value.ToString();
                if (DgvGeftb005.Rows[DgvGeftb005.CurrentCell.RowIndex].Cells[6].Value.ToString() == "F")
                {
                    RbFalta.Checked = true;
                }
                else
                {
                    RbPresenca.Checked = true;
                }
                TbHrEnt.Text = DgvGeftb005.Rows[DgvGeftb005.CurrentCell.RowIndex].Cells[8].Value.ToString();
                TbJustificativa.Text = DgvGeftb005.Rows[DgvGeftb005.CurrentCell.RowIndex].Cells[7].Value.ToString();
                if (DgvGeftb005.Rows[DgvGeftb005.CurrentCell.RowIndex].Cells[9].Value.ToString() == "S")
                {
                    CbxVestuario.Checked = true;
                }
                else
                {
                    CbxVestuario.Checked = false;
                }
                if (TbMatricula.Text.Substring(0,1) == "A" || TbMatricula.Text.Substring(1, 1) == "G")
                {
                    groupBox1.Visible = true;
                }
                else
                {
                    groupBox1.Visible = false;
                }
                AjustarGrid();
            }
        }

        /// <summary>
        /// Evento disparado ao clicar em uma célula do grid de atividades.
        /// </summary>
        private void DgvGeftb002_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Mostrar_Associado();
        }

        /// <summary>
        /// Fecha o formulário de agenda.
        /// </summary>
        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Atualiza o registro do associado na agenda.
        /// </summary>
        private void BtnAtuReg_Click(object sender, EventArgs e)
        {
            string hrent = DateTime.Now.ToString("HH:mm");
            string dtagenda = DtpAtividade.Text;
            string presenca;
            string vestuario = null;
            if (CbxVestuario.Checked == true) { vestuario = "S"; }
            if (RbPresenca.Checked == true)
            {
                presenca = "P";
            }
            else
            {
                presenca = "F";
                hrent = null;
            }

            if (TbHrEnt.Text.ToString() == SearchHorario() || TbHrEnt.Text.ToString() != SearchHorario() && TbJustificativa.Text != "")
            {
                var geftb005 = new Geftb005();
                geftb005.Update(dtagenda, TbSigla.Text, Convert.ToInt32(TbIdAssociado.Text), presenca, hrent, vestuario, TbJustificativa.Text, DateTime.Now.ToString("yyyy/MM/dd"));
                if (SearchAgenda() == "S")
                {
                    MessageBox.Show("Registro atualizado com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LimpaForm();
                }
                else
                {
                    MessageBox.Show("Houve uma falha no banco de dados ao buscar os dados. Por favor entre em contato com o administrador do sistema. ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Associado está atrasado. Favor preencher a justificativa", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TbJustificativa.Focus();
            }

        }

        /// <summary>
        /// Ajusta a visibilidade e largura das colunas do grid de associados.
        /// </summary>
        private void AjustarGrid()
        {
            DgvGeftb005.Columns[0].Visible = false;
            DgvGeftb005.Columns[1].Visible = false;
            DgvGeftb005.Columns[2].Visible = false;
            DgvGeftb005.Columns[10].Visible = false;
            DgvGeftb005.Columns[11].Visible = false;
            DgvGeftb005.Columns[3].Visible = true;
            DgvGeftb005.Columns[4].Visible = true;
            DgvGeftb005.Columns[5].Visible = true;
            DgvGeftb005.Columns[6].Visible = true;
            DgvGeftb005.Columns[7].Visible = true;
            DgvGeftb005.Columns[8].Visible = true;
            DgvGeftb005.Columns[5].Width = 320;
            if (label3.Text == "Domingo") {
                DgvGeftb005.Columns[9].Visible = true;
            } else {
                DgvGeftb005.Columns[9].Visible = false;
            }
        }

        /// <summary>
        /// Evento disparado ao alterar o estado do botão de falta.
        /// Limpa o campo de justificativa.
        /// </summary>
        private void RbFalta_CheckedChanged(object sender, EventArgs e)
        {
          TbJustificativa.Clear();
        }

        /// <summary>
        /// Evento disparado ao alterar a data da atividade.
        /// Atualiza o nome do dia da semana e verifica registros.
        /// </summary>
        private void DtpAtividade_ValueChanged(object sender, EventArgs e)
        {
            // Obtendo nome do dia da semana
            DateTime dataInf = DateTime.Parse(DtpAtividade.Value.ToString("yyyy/MM/d"));
            label3.Text = GetNomeSemana(dataInf);

            // Calcular a semana do mês
            int diaDoMes = dataInf.Day;
            int semanaDoMes = (diaDoMes - 1) / 7 + 1;

            if (SearchAgenda() == "N")
            {
                AtualizarAgenda(semanaDoMes);
                if (SearchAgenda() == "N")
                {
                    MessageBox.Show("Não existem registros para a pesquisa solicitada.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        /// <summary>
        /// Pesquisa registros de agenda para a data selecionada.
        /// </summary>
        /// <returns>Retorna "S" se houver registros, "N" caso contrário.</returns>
        private string SearchAgenda()
        {
            var dt = new DataTable();
            var geftb005 = new Geftb005();
            DgvGeftb005.DataSource = geftb005.Search(DtpAtividade.Text, dt);
            if (dt.Rows.Count > 0)
            {
                AjustarGrid();
                return "S";
            }
            else
            {
                OcultarGrid();
                return "N";
            }
        }

        /// <summary>
        /// Pesquisa o horário do associado selecionado.
        /// </summary>
        /// <returns>Retorna o horário como string ou null se não encontrado.</returns>
        private string SearchHorario()
        {
            var dt = new DataTable();
            var geftb003 = new Geftb003();
            DgvGeftb003.DataSource = geftb003.SearchHorario(TbSigla.Text, dt);
            if (dt.Rows.Count > 0)
            {
                return DgvGeftb003.Rows[DgvGeftb003.CurrentCell.RowIndex].Cells[0].Value.ToString();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Atualiza a agenda dos associados conforme o dia da semana.
        /// </summary>
        /// <param name="diasemana">Número da semana do mês.</param>
        /// <returns>Retorna "S" ao finalizar o processo.</returns>
        public string AtualizarAgenda(int diasemana)
        {
            var dt51 = new DataTable();
            var geftb0051 = new Geftb005();
            var geftb005 = new Geftb005();
            DgvGeftb0051.DataSource = geftb0051.SearchAssAgenda(dt51);
            for (int i = 0; i < dt51.Rows.Count; i++)
            {
                if (Convert.ToDateTime((DtpAtividade.Text).ToString()) >= Convert.ToDateTime((DgvGeftb0051.Rows[i].Cells[3].Value).ToString()) && DgvGeftb0051.Rows[i].Cells[4].Value.ToString() == label3.Text.ToUpper())
                {
                    if ((DgvGeftb0051.Rows[i].Cells[5].Value.ToString() == "QUINZENAL 1/3" || DgvGeftb0051.Rows[i].Cells[5].Value.ToString() == "QUINZENAL 2/4") && diasemana == 5)
                    {}
                    else if ((DgvGeftb0051.Rows[i].Cells[5].Value.ToString() == "QUINZENAL 1/3" && (diasemana == 1 || diasemana == 3) || (DgvGeftb0051.Rows[i].Cells[5].Value.ToString() == "QUINZENAL 2/4") && (diasemana == 2 || diasemana == 4)))
                    {
                        DgvGeftb005.DataSource = geftb005.InsertAssociadoAgenda(DtpAtividade.Text, Convert.ToInt32(DgvGeftb0051.Rows[i].Cells[1].Value.ToString()), Convert.ToInt32(DgvGeftb0051.Rows[i].Cells[2].Value.ToString()), DateTime.Now.ToString("yyyy/MM/dd"));
                    }
                    else if ((DgvGeftb0051.Rows[i].Cells[5].Value.ToString() != "QUINZENAL 1/3") && (DgvGeftb0051.Rows[i].Cells[5].Value.ToString() != "QUINZENAL 2/4"))
                    {
                        DgvGeftb005.DataSource = geftb005.InsertAssociadoAgenda(DtpAtividade.Text, Convert.ToInt32(DgvGeftb0051.Rows[i].Cells[1].Value.ToString()), Convert.ToInt32(DgvGeftb0051.Rows[i].Cells[2].Value.ToString()), DateTime.Now.ToString("yyyy/MM/dd"));
                    }
                }
            }
            if (dt51.Rows.Count == 0)
            {
                var dt4 = new DataTable();
                var geftb004 = new Geftb004();
                DgvGeftb004.DataSource = geftb004.SearchAssAtvsemAgenda(label3.Text, dt4);
                for (int i = 0; i < dt4.Rows.Count; i++)
                {
                    if (Convert.ToDateTime((DtpAtividade.Text).ToString()) >= Convert.ToDateTime((DgvGeftb004.Rows[i].Cells[2].Value).ToString()))
                    {
                        if ((DgvGeftb004.Rows[i].Cells[3].Value.ToString() == "QUINZENAL 1/3" || DgvGeftb004.Rows[i].Cells[3].Value.ToString() == "QUINZENAL 2/4") && diasemana == 5)
                        { }
                        else if ((DgvGeftb004.Rows[i].Cells[3].Value.ToString() == "QUINZENAL 1/3" && (diasemana == 1 || diasemana == 3) || (DgvGeftb004.Rows[i].Cells[3].Value.ToString() == "QUINZENAL 2/4") && (diasemana == 2 || diasemana == 4)))
                        {
                            DgvGeftb005.DataSource = geftb005.InsertAssociadoAgenda(DtpAtividade.Text, Convert.ToInt32(DgvGeftb004.Rows[i].Cells[0].Value.ToString()), Convert.ToInt32(DgvGeftb004.Rows[i].Cells[1].Value.ToString()), DateTime.Now.ToString("yyyy/MM/dd"));
                        }
                        else if ((DgvGeftb004.Rows[i].Cells[3].Value.ToString() != "QUINZENAL 1/3")  && (DgvGeftb004.Rows[i].Cells[3].Value.ToString() != "QUINZENAL 2/4"))
                        {
                            DgvGeftb005.DataSource = geftb005.InsertAssociadoAgenda(DtpAtividade.Text, Convert.ToInt32(DgvGeftb004.Rows[i].Cells[0].Value.ToString()), Convert.ToInt32(DgvGeftb004.Rows[i].Cells[1].Value.ToString()), DateTime.Now.ToString("yyyy/MM/dd"));
                        }
                    }
                }
            }
            return "S";
        }

        /// <summary>
        /// Oculta todas as colunas do grid de associados.
        /// </summary>
        public void OcultarGrid()
        {
            DgvGeftb005.Columns[0].Visible = false;
            DgvGeftb005.Columns[1].Visible = false;
            DgvGeftb005.Columns[2].Visible = false;
            DgvGeftb005.Columns[3].Visible = false;
            DgvGeftb005.Columns[4].Visible = false;
            DgvGeftb005.Columns[5].Visible = false;
            DgvGeftb005.Columns[6].Visible = false;
            DgvGeftb005.Columns[7].Visible = false;
            DgvGeftb005.Columns[8].Visible = false;
            DgvGeftb005.Columns[9].Visible = false;
            DgvGeftb005.Columns[10].Visible = false;
            DgvGeftb005.Columns[11].Visible = false;
        }

        /// <summary>
        /// Limpa todos os campos do formulário de agenda.
        /// </summary>
        public void LimpaForm()
        {
            TbIdAgenda.Clear();
            TbIdAssociado.Clear();
            TbJustificativa.Clear();
            TbHrEnt.Clear();
            TbMatricula.Clear();
            TbNome.Clear();
            TbSigla.Clear();
            CbxVestuario.Checked = false;
            RbPresenca.Checked = true;
        }

        /// <summary>
        /// Retorna o nome do dia da semana para uma data informada.
        /// </summary>
        /// <param name="data">Data para consulta.</param>
        /// <returns>Nome do dia da semana.</returns>
        public string GetNomeSemana(DateTime data)
        {
            switch (data.DayOfWeek)
            {
                case DayOfWeek.Sunday: return "Domingo";
                case DayOfWeek.Monday: return "Segunda-feira";
                case DayOfWeek.Tuesday: return "Terça-feira";
                case DayOfWeek.Wednesday: return "Quarta-feira";
                case DayOfWeek.Thursday: return "Quinta-feira";
                case DayOfWeek.Friday: return "Sexta-feira";
                case DayOfWeek.Saturday: return "Sábado";
                default: return string.Empty;
            }
        }

        /// <summary>
        /// Evento disparado ao pressionar uma tecla no grid de associados.
        /// </summary>
        private void DgvGeftb005_KeyDown(object sender, KeyEventArgs e)
        {
            Mostrar_Associado();
        }

        /// <summary>
        /// Evento disparado ao pressionar uma tecla no grid de associados.
        /// </summary>
        private void DgvGeftb005_KeyPress(object sender, KeyPressEventArgs e)
        {
            Mostrar_Associado();
        }

        /// <summary>
        /// Evento disparado ao liberar uma tecla no grid de associados.
        /// </summary>
        private void DgvGeftb005_KeyUp(object sender, KeyEventArgs e)
        {
            Mostrar_Associado();
        }

        /// <summary>
        /// Gera o relatório de recebimento da bolsa de alimentos em PDF para o domingo.
        /// </summary>
        private void BtnImpRecBolsa_Click(object sender, EventArgs e)
        {
            if (label3.Text == "Domingo")
            {
                DataTable dt = new DataTable();
                var geftb005 = new Geftb005();
                DataTable dtAgenda = geftb005.SearchRecBolsa(DtpAtividade.Text, dt);
                if (dtAgenda.Rows.Count > 0)
                {
                    ParmGlobal.Titulo = "Relatório - Recebimento da Bolsa de Alimentos\n\n";
                    ParmGlobal.nomeArquivo = ParmGlobal.caminho + @"Relatorio\RecBolsa_" + DateTime.Now.ToString("yyyy.MM.dd.HH.mm.ss") + ".pdf";
                    RelPDF_RecBolsa.GerarRelatorioPDF(dtAgenda);
                }
                else
                {
                    MessageBox.Show("Não existem registros com presença para imprimir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        /// <summary>
        /// Abre o formulário de impressão de frequência de atividade.
        /// </summary>
        private void BtnImprime_Click(object sender, EventArgs e)
        {
            FrmImpFreqAtv frm = new FrmImpFreqAtv(DtpAtividade.Text);
            frm.ShowDialog();

        }
    }
}
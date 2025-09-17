using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Globalization;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Drawing.Text;
using System.Net;
using System.Threading;
using System.Net.NetworkInformation;
using static System.Windows.Forms.LinkLabel;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Runtime.ConstrainedExecution;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace NovoGEF.Forms
{
    /// <summary>
    /// Formulário responsável pelo cadastro, pesquisa e atualização de atividades.
    /// </summary>
    public partial class FrmAtividade : Form
    {
        /// <summary>
        /// Inicializa uma nova instância do formulário de atividade.
        /// </summary>
        public FrmAtividade()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento disparado ao carregar o formulário. Verifica se o usuário está logado e inicializa os dados.
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            if (ParmGlobal.usuarioId == 0 )
            {
                MessageBox.Show("Usuário não logado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BtnAtuReg.Enabled = false;   
                BtnCadastrar.Enabled = false;
                BtnPesquisar.Enabled = false;
                BtnLimpForm.Enabled = false;
            }else
            {
                Pesquisar_Geftb003(0);
            }
        }

        /// <summary>
        /// Limpa todos os campos do formulário de atividade.
        /// </summary>
        private void Limpa_Form()
        {
            tbCodigo.Clear();
            tbSigla.Clear();
            mskHoraini.Clear();
            tbDescricao.Clear();
            mskHorafim.Clear();
            string dt4 = DateTime.Now.ToString("yyyy/MM/dd");
            DtpInicio.Text = dt4;
            DtpFim.Text = dt4;
            DtpFim.Visible = true;
            CbxDtFim.Visible = true;
        }

        /// <summary>
        /// Realiza validações nos campos do formulário de atividade.
        /// </summary>
        /// <returns>Retorna 0 se válido, 1 se houver erro.</returns>
        private int IsValidForm()
        {
            String hrini = mskHoraini.Text;
            hrini = hrini.PadLeft(4, '0');
            String hrfim = mskHorafim.Text;
            hrfim = hrfim.PadLeft(4, '0');

            bool isNumeric_hrini = Regex.IsMatch(hrini, @"^\d+$");
            bool isNumeric_hrfim = Regex.IsMatch(hrfim, @"^\d+$");

            int rb = 0;
            if (RbAssSoc.Checked == true)
            {
                rb = 0;
            }
            else if (RbColaborador.Checked == true)
            {
                rb = 1;
            }

            if (String.IsNullOrEmpty(tbSigla.Text))
            {
                MessageBox.Show("Campo sigla não aceita vazio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbSigla.Focus();
                return 1;
            }
            else if (String.IsNullOrEmpty(tbDescricao.Text))
            {
                MessageBox.Show("Campo descrição não aceita vazio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbDescricao.Focus();
                return 1;
            }
            else if (String.IsNullOrEmpty(mskHoraini.Text))
            {
                MessageBox.Show("Campo hora inicial deve ser preenchido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskHoraini.Focus();
                return 1;
            }
            else if (!String.IsNullOrEmpty(hrini) && !isNumeric_hrini)
            {
                MessageBox.Show("Campo hora inicial deve conter números.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskHoraini.Focus();
                return 1;
            }
            else if (String.IsNullOrEmpty(mskHorafim.Text))
            {
                MessageBox.Show("Campo hora final deve ser preenchido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskHorafim.Focus();
                return 1;
            }
            else if (!String.IsNullOrEmpty(hrfim) && !isNumeric_hrfim)
            {
                MessageBox.Show("Campo hora final deve conter números.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskHorafim.Focus();
                return 1;
            }
            else if (rb == 0 && cbSubgrupo2.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um subgrupo de assitência social.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbSubgrupo2.Focus();
                return 1;
            }
            else if (rb == 1 && cbSubgrupo1.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um subgrupo de colaborador.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbSubgrupo1.Focus();
                return 1;
            }
            else if (cbDiasemana.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione o dia da semana que a atividade ocorrerá.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbDiasemana.Focus();
                return 1;
            }
            else if (cbPeriodo.SelectedIndex == -1)
            {
                MessageBox.Show("selecione o periodo que a atividade ocorrerá.", "Atenção", MessageBoxButtons.OK);
                cbPeriodo.Focus();
                return 1;
            }

            return 0;
        }

        /// <summary>
        /// Evento disparado ao clicar no botão pesquisar. Realiza pesquisa de atividades conforme filtro.
        /// </summary>
        private void Btn_Pesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar_Geftb003(0);
        }

        /// <summary>
        /// Realiza pesquisa de atividades conforme filtro informado.
        /// </summary>
        /// <param name="filtro">Filtro de pesquisa: 0=Ativos, 1=Inativos.</param>
        private void Pesquisar_Geftb003(int filtro)
        {
            DataTable dtAtividade = new DataTable();
            var geftb003 = new Geftb003();
            if (rbAtivo.Checked ==true)
            {
                DgvGeftb003.DataSource = geftb003.Search(0, dtAtividade);
            }
            else
            {
                DgvGeftb003.DataSource = geftb003.Search(1, dtAtividade);
            }
            if (dtAtividade.Rows.Count > 0)
            {
                DgvGeftb003.Columns[0].HeaderText = "Código";
                DgvGeftb003.Columns[0].DefaultCellStyle
                        .Alignment = DataGridViewContentAlignment.MiddleRight;
                DgvGeftb003.Columns[1].HeaderText = "Sigla";
                DgvGeftb003.Columns[2].HeaderText = "Descrição";
                DgvGeftb003.Columns[3].HeaderText = "Grupo";
                DgvGeftb003.Columns[4].HeaderText = "Sub-Grupo";
                DgvGeftb003.Columns[5].HeaderText = "Hora Início";
                DgvGeftb003.Columns[5].DefaultCellStyle
                        .Alignment = DataGridViewContentAlignment.MiddleRight;
                DgvGeftb003.Columns[6].HeaderText = "Hora Fim";
                DgvGeftb003.Columns[6].DefaultCellStyle
                        .Alignment = DataGridViewContentAlignment.MiddleRight;
                DgvGeftb003.Columns[7].HeaderText = "Data Início";
                DgvGeftb003.Columns[7].DefaultCellStyle
                        .Alignment = DataGridViewContentAlignment.MiddleRight;
                DgvGeftb003.Columns[8].HeaderText = "Data Fim";
                DgvGeftb003.Columns[8].DefaultCellStyle
                        .Alignment = DataGridViewContentAlignment.MiddleRight;
                DgvGeftb003.Columns[9].HeaderText = "Dia da Semana";
                DgvGeftb003.Columns[9].DefaultCellStyle
                        .Alignment = DataGridViewContentAlignment.MiddleRight;
                DgvGeftb003.Columns[10].HeaderText = "Período";
                DgvGeftb003.Columns[10].DefaultCellStyle
                        .Alignment = DataGridViewContentAlignment.MiddleRight;
                DgvGeftb003.Columns[2].Width = 320;
                DgvGeftb003.Columns[3].Width = 160;
                DgvGeftb003.Columns[4].Width = 160;
                DgvGeftb003.Columns[11].Visible = false;
                DgvGeftb003.Columns[12].Visible = false;
            }else {
                MessageBox.Show("não existe registro correspondente aos filtros selecionados", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Exibe os dados da atividade selecionada no grid.
        /// </summary>
        private void Mostrar_Atividade()
        {
            if (DgvGeftb003.CurrentRow != null)
            {
                tbCodigo.Text = DgvGeftb003.Rows[DgvGeftb003.CurrentCell.RowIndex].Cells[0].Value.ToString();
                tbSigla.Text = DgvGeftb003.Rows[DgvGeftb003.CurrentCell.RowIndex].Cells[1].Value.ToString();
                tbDescricao.Text = DgvGeftb003.Rows[DgvGeftb003.CurrentCell.RowIndex].Cells[2].Value.ToString();
                if (DgvGeftb003.Rows[DgvGeftb003.CurrentCell.RowIndex].Cells[3].Value.ToString() == "COLABORADORES") 
                {
                    RbColaborador.Checked = true;
                    cbSubgrupo2.SelectedIndex = -1;

                 }else
                {
                    RbAssSoc.Checked = true;
                    cbSubgrupo1.SelectedIndex = -1;
                }
                if (DgvGeftb003.Rows[DgvGeftb003.CurrentCell.RowIndex].Cells[3].Value.ToString() == "COLABORADORES")
                {
                    cbSubgrupo1.SelectedItem = DgvGeftb003.Rows[DgvGeftb003.CurrentCell.RowIndex].Cells[4].Value.ToString();
                }
                else
                {
                    cbSubgrupo2.SelectedItem = DgvGeftb003.Rows[DgvGeftb003.CurrentCell.RowIndex].Cells[4].Value.ToString();
                }
                String hrini = DgvGeftb003.Rows[DgvGeftb003.CurrentCell.RowIndex].Cells[5].Value.ToString(); ;
                String hrfim = DgvGeftb003.Rows[DgvGeftb003.CurrentCell.RowIndex].Cells[6].Value.ToString();
                hrini = hrini.PadLeft(4, '0');
                hrfim = hrfim.PadLeft(4, '0');
                mskHoraini.Text = hrini;
                mskHorafim.Text = hrfim;
                DtpInicio.Text = DgvGeftb003.Rows[DgvGeftb003.CurrentCell.RowIndex].Cells[7].Value.ToString();
                DtpFim.Text = DgvGeftb003.Rows[DgvGeftb003.CurrentCell.RowIndex].Cells[8].Value.ToString();
                TbDtFim.Text = DgvGeftb003.Rows[DgvGeftb003.CurrentCell.RowIndex].Cells[8].Value.ToString();
                if (DgvGeftb003.Rows[DgvGeftb003.CurrentCell.RowIndex].Cells[8].Value.ToString() == "")
                {
                    CbxDtFim.Checked = false;
                }
                else
                {
                    CbxDtFim.Checked = true;
                }
                cbDiasemana.SelectedItem = DgvGeftb003.Rows[DgvGeftb003.CurrentCell.RowIndex].Cells[9].Value.ToString();
                cbPeriodo.SelectedItem = DgvGeftb003.Rows[DgvGeftb003.CurrentCell.RowIndex].Cells[10].Value.ToString();
            }
        }

        /// <summary>
        /// Evento disparado ao clicar em uma célula do grid de atividades.
        /// </summary>
        private void DgvGeftb003_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Mostrar_Atividade();
        }

        /// <summary>
        /// Evento disparado ao alterar o estado do botão de assistência social.
        /// </summary>
        private void RbAssSoc_CheckedChanged(object sender, EventArgs e)
        {
            if (RbAssSoc.Checked == true)
            {
                cbSubgrupo1.Enabled = false;
                cbSubgrupo2.Enabled = true;
            }
            else
            {
                cbSubgrupo1.Enabled = true;
                cbSubgrupo2.Enabled = false;
            }
        }

        /// <summary>
        /// Evento disparado ao alterar o estado do botão de colaborador.
        /// </summary>
        private void RbColaborador_CheckedChanged(object sender, EventArgs e)
        {
            if (RbAssSoc.Checked == true)
            {
                cbSubgrupo1.Enabled = false;
                cbSubgrupo2.Enabled = true;
            }
            else
            {
                cbSubgrupo1.Enabled = true;
                cbSubgrupo2.Enabled = false;
            }
        }

        /// <summary>
        /// Evento disparado ao clicar no checkbox de data fim.
        /// </summary>
        private void Cbx_DtFim_Click(object sender, EventArgs e)
        {
            if (CbxDtFim.Checked == true)
            {
                const string message = "Quer realmente desativar essa atividade?";
                const string caption = "ATENÇÃO";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    CbxDtFim.Checked = true;
                }
                else
                {
                    CbxDtFim.Checked = false;
                }
            }
            else if (CbxDtFim.Checked == false)
            {
                const string message = "Quer realmente reativar essa aatividade?";
                const string caption = "ATENÇÃO";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    CbxDtFim.Checked = false;
                }
                else
                {
                    CbxDtFim.Checked = true;
                }
            }
        }

        /// <summary>
        /// Cancela a operação e retorna o formulário ao estado inicial.
        /// </summary>
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            CbxDtFim.Visible = true;
            DtpFim.Visible = true;
            BtnCadastrar.Visible = true;
            BtnLimpForm.Visible = true;
            BtnAtuReg.Visible = true;
            BtnSair.Visible = true;
            BtnImpTabAtv.Visible = true;
            BtnConf.Visible = false;
            BtnCancel.Visible = false;
            groupBox3.Enabled = true;
            Limpa_Form();

        }

        /// <summary>
        /// Confirma o cadastro de atividade após validação dos campos.
        /// </summary>
        private void BtnConf_Click(object sender, EventArgs e)
        {
            int critica = IsValidForm();
            if (critica == 0)
            {
                string gr, sgr;
                if (RbAssSoc.Checked == true)
                {
                    gr = "ASSISTÊNCIA SOCIAL";
                    sgr = cbSubgrupo2.Text;
                }
                else
                {
                    gr = "COLABORADORES";
                    sgr = cbSubgrupo1.Text;
                }
                string dt2 = DtpInicio.Value.ToString("yyyy/MM/dd");
                string dt4 = DateTime.Now.ToString("yyyy/MM/dd");
                var geftb003 = new Geftb003();
                geftb003.Insert(dt2, tbSigla.Text, tbDescricao.Text,
                mskHoraini.Text, mskHorafim.Text, gr, sgr, cbDiasemana.Text, cbPeriodo.Text, dt4);
                MessageBox.Show("Atividade incluida com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Limpa_Form();
                CbxDtFim.Visible = true;
                DtpFim.Visible = true;
                BtnCadastrar.Visible = true;
                BtnLimpForm.Visible = true;
                BtnAtuReg.Visible = true;
                BtnSair.Visible = true;
                BtnImpTabAtv.Visible = true;
                BtnConf.Visible = false;
                BtnCancel.Visible = false;
                groupBox3.Enabled = true;
                Limpa_Form();
                Limpa_Form();
                Pesquisar_Geftb003(0);
            }
        }

        /// <summary>
        /// Fecha o formulário de atividade.
        /// </summary>
        private void BtnSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Limpa os campos do formulário ao clicar no botão Limpar.
        /// </summary>
        private void BtnLimpForm_Click(object sender, EventArgs e)
        {
            Limpa_Form();
        }

        /// <summary>
        /// Atualiza os dados da atividade após validação dos campos.
        /// </summary>
        private void BtnAtuReg_Click(object sender, EventArgs e)
        {
            int critica = IsValidForm();
            if (critica == 0)
            {
                string gr, sgr;
                if (RbAssSoc.Checked == true)
                {
                    gr = "ASSISTENCIA SOCIAL";
                    sgr = cbSubgrupo2.Text;
                }
                else
                {
                    gr = "COLABORADORES";
                    sgr = cbSubgrupo1.Text;
                }
                bool ativado = false;
                if (TbDtFim.Text == "")
                {
                    ativado = true;
                }
                string dt2 = DtpInicio.Value.ToString("yyyy/MM/dd");
                string dt3 = null;
                string dt4 = DateTime.Now.ToString("yyyy/MM/dd");
                if (CbxDtFim.Checked == true && ativado == true)
                {
                    var result = MessageBox.Show("Quer realmente desativar essa atividade?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        dt3 = DtpFim.Value.ToString("yyyy/MM/dd");
                    }
                }
                else if (CbxDtFim.Checked == false && ativado == false)
                {
                    var result = MessageBox.Show("Quer realmente reativar essa aatividade?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        dt3 = null;
                    }
                }
                else if (CbxDtFim.Checked == false && ativado == true)
                {
                    dt3 = null;
                }
                string hi = mskHoraini.Text;
                hi = hi.Substring(0, 2) + ":" + hi.Substring(2, 2);
                string hf = mskHorafim.Text;
                hf = hf.Substring(0, 2) + ":" + hf.Substring(2, 2);
                var geftb003 = new Geftb003();
                geftb003.Update(Convert.ToInt32(tbCodigo.Text), dt2, dt3, tbSigla.Text, tbDescricao.Text,
                hi, hf, gr, sgr, cbDiasemana.Text, cbPeriodo.Text, dt4);
                MessageBox.Show("Atividade atualizada com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BtnCadastrar.Visible = true;
                BtnLimpForm.Visible = true;
                BtnAtuReg.Visible = true;
                BtnSair.Visible = true;
                BtnImpTabAtv.Visible = true;
                BtnConf.Visible = false;
                BtnCancel.Visible = false;
                groupBox3.Enabled = true;
                Limpa_Form();
                Pesquisar_Geftb003(0);
            }

        }

        /// <summary>
        /// Prepara o formulário para cadastro de nova atividade.
        /// </summary>
        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            BtnCadastrar.Visible = false;
            BtnLimpForm.Visible = false;
            BtnAtuReg.Visible = false;
            BtnSair.Visible = false;
            BtnImpTabAtv.Visible = false;
            BtnConf.Visible = true;
            BtnCancel.Visible = true;
            groupBox3.Enabled = false;
            Limpa_Form();
            CbxDtFim.Visible = false;
            DtpFim.Visible = false;
            tbSigla.Focus();
        }

        /// <summary>
        /// Evento disparado ao pressionar uma tecla no grid de atividades.
        /// </summary>
        private void DgvGeftb003_KeyDown(object sender, KeyEventArgs e)
        {
            Mostrar_Atividade();
        }

        /// <summary>
        /// Evento disparado ao liberar uma tecla no grid de atividades.
        /// </summary>
        private void DgvGeftb003_KeyUp(object sender, KeyEventArgs e)
        {
            Mostrar_Atividade();
        }

        /// <summary>
        /// Evento disparado ao pressionar uma tecla no grid de atividades.
        /// </summary>
        private void DgvGeftb003_KeyPress(object sender, KeyPressEventArgs e)
        {
            Mostrar_Atividade();
        }

        /// <summary>
        /// Gera o relatório em PDF da tabela de atividades.
        /// </summary>
        private void BtnImpTabAtv_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            var geftb003 = new Geftb003();
            DataTable dtAtividade = geftb003.Search(0, dt);
            if (dtAtividade.Rows.Count > 0)
            {
                ParmGlobal.Titulo = "Relatórios - Tabela de Atividades\n\n";
                ParmGlobal.nomeArquivo = ParmGlobal.caminho + @"Relatorio\TabAtividades_" + DateTime.Now.ToString("yyyy.MM.dd.HH.mm.ss") + ".pdf";
                RelPDF_TabAtividade.GerarRelatorioPDF(dtAtividade);
            }
            else
            {
                MessageBox.Show("Não existem registros na tabela para imprimir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Evento disparado ao liberar uma tecla no grid de atividades.
        /// </summary>
        private void DgvGeftb003_KeyUp_1(object sender, KeyEventArgs e)
        {
            Mostrar_Atividade();
        }
    }
}

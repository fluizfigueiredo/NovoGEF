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

namespace NovoGEF.Forms
{
    /// <summary>
    /// Formulário responsável pelo gerenciamento do estoque de medicamentos.
    /// </summary>
    public partial class FrmEstoqueMed : Form
    {
        /// <summary>
        /// Inicializa uma nova instância do formulário de estoque de medicamentos.
        /// </summary>
        public FrmEstoqueMed()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Classe interna para representar uma atividade (não implementada).
        /// </summary>
        public class ATIVIDADE
        {
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
                BtnLimpForm.Enabled = false;
            }else
            {
                Pesquisar_Geftb007();
                Pesquisar_Geftb008();
            }
        }

        /// <summary>
        /// Pesquisa e carrega os grupos de fármacos no combobox.
        /// </summary>
        private void Pesquisar_Geftb007()
        {
            DataTable dtGrfarmaco = new DataTable();
            var geftb007 = new Geftb007();
            cbGrFarmaco.DataSource = geftb007.Search(dtGrfarmaco);
            if (dtGrfarmaco.Rows.Count > 0)
            {
                cbGrFarmaco.DisplayMember = "grupo";
                cbGrFarmaco.ValueMember = "idgrfarmaco";
            }
            else
            {
                MessageBox.Show("Não existe grupo farmaco cadastrado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Pesquisa e carrega os medicamentos no grid de estoque.
        /// </summary>
        private void Pesquisar_Geftb008()
        {
            DataTable dtEstoqueMed = new DataTable();
            var geftb008 = new Geftb008();
            DgvGeftb008.DataSource = geftb008.Search(dtEstoqueMed);
            if (dtEstoqueMed.Rows.Count > 0)
            {
                DgvGeftb008.Columns[0].HeaderText = "Código";
                DgvGeftb008.Columns[0].DefaultCellStyle
                        .Alignment = DataGridViewContentAlignment.MiddleRight;
                DgvGeftb008.Columns[1].HeaderText = "Lote";
                DgvGeftb008.Columns[2].HeaderText = "Nome Comercial";
                DgvGeftb008.Columns[3].HeaderText = "Nome Químico";
                DgvGeftb008.Columns[4].HeaderText = "Grupo Farmaco";
                DgvGeftb008.Columns[5].HeaderText = "Prateleira";
                DgvGeftb008.Columns[5].DefaultCellStyle
                        .Alignment = DataGridViewContentAlignment.MiddleRight;
                DgvGeftb008.Columns[6].HeaderText = "Data Validade";
                DgvGeftb008.Columns[6].DefaultCellStyle
                        .Alignment = DataGridViewContentAlignment.MiddleRight;
                DgvGeftb008.Columns[7].HeaderText = "Estoque";
                DgvGeftb008.Columns[7].DefaultCellStyle
                        .Alignment = DataGridViewContentAlignment.MiddleRight;
                DgvGeftb008.Columns[2].Width = 320;
                DgvGeftb008.Columns[3].Width = 320;
                DgvGeftb008.Columns[8].Visible = false;
                DgvGeftb008.Columns[9].Visible = false;
            }
            else
            {
                MessageBox.Show("Não existe medicamento cadastrado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Limpa todos os campos do formulário de estoque de medicamentos.
        /// </summary>
        private void Limpa_Form()
        {
            TbIdEstoqueMed.Clear();
            TbNomeCom.Clear();
            TbNomeQui.Clear();
            TbLote.Clear();
            TbEstoque.Clear();
            TbPrateleira.Clear();
            string dt4 = DateTime.Now.ToString("yyyy/MM/dd");
            DtpValidade.Text = dt4;
        }

        /// <summary>
        /// Realiza validações nos campos do formulário de estoque de medicamentos.
        /// </summary>
        /// <returns>Retorna 0 se válido, 1 se houver erro.</returns>
        private int IsValidForm()
        {

            bool isNumeric_lote = Regex.IsMatch(TbLote.Text, @"^\d+$");
            bool isNumeric_estoque = Regex.IsMatch(TbEstoque.Text, @"^\d+$");
            bool isNumeric_prateleira = Regex.IsMatch(TbPrateleira.Text, @"^\d+$");

            if (String.IsNullOrEmpty(TbNomeCom.Text))
            {
                MessageBox.Show("Campo nome comercial não aceita vazio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TbNomeCom.Focus();
                return 1;
            }
            else if (String.IsNullOrEmpty(TbNomeQui.Text))
            {
                MessageBox.Show("Campo nome químico não aceita vazio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TbNomeQui.Focus();
                return 1;
            }
            else if (String.IsNullOrEmpty(TbEstoque.Text))
            {
                MessageBox.Show("Campo estoque deve ser preenchido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TbEstoque.Focus();
                return 1;
            }
            else if (!String.IsNullOrEmpty(TbEstoque.Text) && !isNumeric_estoque)
            {
                MessageBox.Show("Campo estoque deve conter números.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TbEstoque.Focus();
                return 1;
            }
            else if (String.IsNullOrEmpty(TbLote.Text))
            {
                MessageBox.Show("Campo lote deve ser preenchido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TbLote.Focus();
                return 1;
            }
            else if (!String.IsNullOrEmpty(TbLote.Text) && !isNumeric_lote)
            {
                MessageBox.Show("Campo lote deve conter números.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TbLote.Focus();
                return 1;
            }
            else if (String.IsNullOrEmpty(TbPrateleira.Text))
            {
                MessageBox.Show("Campo prateleira deve ser preenchido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TbPrateleira.Focus();
                return 1;
            }
            else if (!String.IsNullOrEmpty(TbPrateleira.Text) && !isNumeric_prateleira)
            {
                MessageBox.Show("Campo prateleira deve conter números.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TbPrateleira.Focus();
                return 1;
            }
            return 0;
        }

        /// <summary>
        /// Exibe os dados do medicamento selecionado no grid.
        /// </summary>
        private void Mostrar_EstoqueMed()
        {
            if (DgvGeftb008.CurrentRow != null)
            {
                TbIdEstoqueMed.Text = DgvGeftb008.Rows[DgvGeftb008.CurrentCell.RowIndex].Cells[0].Value.ToString();
                TbLote.Text = DgvGeftb008.Rows[DgvGeftb008.CurrentCell.RowIndex].Cells[1].Value.ToString();
                TbNomeCom.Text = DgvGeftb008.Rows[DgvGeftb008.CurrentCell.RowIndex].Cells[2].Value.ToString();
                TbNomeQui.Text = DgvGeftb008.Rows[DgvGeftb008.CurrentCell.RowIndex].Cells[3].Value.ToString();
                cbGrFarmaco.Text = DgvGeftb008.Rows[DgvGeftb008.CurrentCell.RowIndex].Cells[4].Value.ToString();
                TbPrateleira.Text = DgvGeftb008.Rows[DgvGeftb008.CurrentCell.RowIndex].Cells[5].Value.ToString();
                DtpValidade.Text = DgvGeftb008.Rows[DgvGeftb008.CurrentCell.RowIndex].Cells[6].Value.ToString();
                TbEstoque.Text = DgvGeftb008.Rows[DgvGeftb008.CurrentCell.RowIndex].Cells[7].Value.ToString();
            }
        }

        /// <summary>
        /// Cancela a operação e retorna o formulário ao estado inicial.
        /// </summary>
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            BtnCadastrar.Visible = true;
            BtnLimpForm.Visible = true;
            BtnAtuReg.Visible = true;
            BtnSair.Visible = true;
            BtnConf.Visible = false;
            BtnCancel.Visible = false;
            Limpa_Form();
        }

        /// <summary>
        /// Confirma o cadastro de medicamento após validação dos campos.
        /// </summary>
        private void BtnConf_Click(object sender, EventArgs e)
        {
            int critica = IsValidForm();
            if (critica == 0)
            {
                string dt2 = DtpValidade.Value.ToString("yyyy/MM/dd");
                string dt4 = DateTime.Now.ToString("yyyy/MM/dd");
                var geftb008 = new Geftb008();
                geftb008.Insert(TbNomeCom.Text, TbNomeQui.Text, Convert.ToInt32(TbLote.Text), Convert.ToInt32(TbPrateleira.Text), Convert.ToInt32(TbEstoque.Text), Convert.ToInt32(cbGrFarmaco.SelectedValue), dt2, dt4);
                MessageBox.Show("Estoque de medicamentos incluido com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Limpa_Form();
                BtnCadastrar.Visible = true;
                BtnLimpForm.Visible = true;
                BtnAtuReg.Visible = true;
                BtnSair.Visible = true;
                BtnConf.Visible = false;
                BtnCancel.Visible = false;
                Limpa_Form();
                Limpa_Form();
                Pesquisar_Geftb008();
            }
        }

        /// <summary>
        /// Fecha o formulário de estoque de medicamentos.
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
        /// Atualiza os dados do medicamento após validação dos campos.
        /// </summary>
        private void BtnAtuReg_Click(object sender, EventArgs e)
        {
            int critica = IsValidForm();
            if (critica == 0)
            {
                string dt2 = DtpValidade.Value.ToString("yyyy/MM/dd");
                string dt4 = DateTime.Now.ToString("yyyy/MM/dd");
                var geftb008 = new Geftb008();
                geftb008.Update(Convert.ToInt32(TbIdEstoqueMed.Text), TbNomeCom.Text, TbNomeQui.Text, Convert.ToInt32(TbLote.Text), Convert.ToInt32(TbPrateleira.Text), Convert.ToInt32(TbEstoque.Text), Convert.ToInt32(cbGrFarmaco.SelectedValue), dt2, dt4);
                MessageBox.Show("Estoque de medicamentos atualizado com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BtnCadastrar.Visible = true;
                BtnLimpForm.Visible = true;
                BtnAtuReg.Visible = true;
                BtnSair.Visible = true;
                BtnConf.Visible = false;
                BtnCancel.Visible = false;
                Limpa_Form();
                Pesquisar_Geftb008();
            }
        }

        /// <summary>
        /// Prepara o formulário para cadastro de novo medicamento.
        /// </summary>
        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            BtnCadastrar.Visible = false;
            BtnLimpForm.Visible = false;
            BtnAtuReg.Visible = false;
            BtnSair.Visible = false;
            BtnConf.Visible = true;
            BtnCancel.Visible = true;
            Limpa_Form();
            TbNomeCom.Focus();
        }

        /// <summary>
        /// Evento disparado ao clicar em uma célula do grid de medicamentos.
        /// </summary>
        private void DgvGeftb008_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Mostrar_EstoqueMed();
        }

        /// <summary>
        /// Evento disparado ao pressionar uma tecla no grid de medicamentos.
        /// </summary>
        private void DgvGeftb008_KeyDown(object sender, KeyEventArgs e)
        {
            Mostrar_EstoqueMed();
        }

        /// <summary>
        /// Evento disparado ao pressionar uma tecla no grid de medicamentos.
        /// </summary>
        private void DgvGeftb008_KeyPress(object sender, KeyPressEventArgs e)
        {
            Mostrar_EstoqueMed();
        }

        /// <summary>
        /// Evento disparado ao liberar uma tecla no grid de medicamentos.
        /// </summary>
        private void DgvGeftb008_KeyUp(object sender, KeyEventArgs e)
        {
            Mostrar_EstoqueMed();
        }
    }
}

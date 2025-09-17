using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data;

namespace NovoGEF.Forms
{
    /// <summary>
    /// Formulário responsável pelo cadastro, pesquisa e atualização de editoras de livros.
    /// </summary>
    public partial class FrmLivEditora : Form
    {
        /// <summary>
        /// Inicializa uma nova instância do formulário de editora de livro.
        /// </summary>
        public FrmLivEditora()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento disparado ao carregar o formulário. Verifica se o usuário está logado e inicializa os dados.
        /// </summary>
        private void FrmLivEditora_Load(object sender, EventArgs e)
        {
            if (ParmGlobal.usuarioId == 0)
            {
                MessageBox.Show("Usuário não logado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BtnAtuReg.Enabled = false;
                BtnCadastrar.Enabled = false;
                BtnLimpForm.Enabled = false;
            }else
            {
                Pesquisar_Geftb011();
            }
        }

        /// <summary>
        /// Limpa todos os campos do formulário de editora.
        /// </summary>
        private void Limpa_Form()
        {
            TbCodigo.Clear();
            TbDescricao.Clear();
            MskCnpj.Clear();
            TbTel1.Clear();
            TbTel2.Clear();
            TbEmail.Clear();
        }

        /// <summary>
        /// Realiza validações nos campos do formulário de editora.
        /// </summary>
        /// <returns>Retorna 0 se válido, 1 se houver erro.</returns>
        private int IsValidForm()
        {
            bool isNumeric_Tel1 = Regex.IsMatch(TbTel1.Text, @"^\d+$");
            bool isNumeric_Tel2 = Regex.IsMatch(TbTel2.Text, @"^\d+$");
            int val_email = IsValidEmail(TbEmail.Text);
            int val_cnpj = IsValidCNPJ();
            if (val_cnpj == 1)
            {
                MessageBox.Show("Campo CPF inválido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MskCnpj.Focus();
                return 1;
            }
            if (String.IsNullOrEmpty(TbDescricao.Text))
            {
                MessageBox.Show("Campo nome não aceita vazio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TbDescricao.Focus();
                return 1;
            }
            else if (!String.IsNullOrEmpty(TbTel1.Text) && !isNumeric_Tel1)
            {
                MessageBox.Show("Campo Telefone 1 deve conter números.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TbTel1.Focus();
                return 1;
            }
            else if (!String.IsNullOrEmpty(TbTel2.Text) && !isNumeric_Tel2)
            {
                MessageBox.Show("Campo Telefone 2 deve conter números.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TbTel2.Focus();
                return 1;
            }
            else if (!String.IsNullOrEmpty(TbEmail.Text) && val_email == 1)
            {
                MessageBox.Show("Campo e-Mail inválido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TbEmail.Focus();
                return 1;
            }
            return 0;
        }

        /// <summary>
        /// Valida o e-mail informado.
        /// </summary>
        /// <param name="email">E-mail a ser validado.</param>
        /// <returns>Retorna 0 se válido, 1 se inválido.</returns>
        public int IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return 1;
            }
            else
            {
                string strModelo = "^([0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
                if (System.Text.RegularExpressions.Regex.IsMatch(email, strModelo))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>
        /// Valida o CNPJ informado.
        /// </summary>
        /// <returns>Retorna 0 se válido, 1 se inválido.</returns>
        public int IsValidCNPJ()
        {
            String cnpj = MskCnpj.Text;
            cnpj = cnpj.PadLeft(14, '0');
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;
            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");
            if (cnpj.Length != 14)
                return 1;
            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return 0;
        }

        /// <summary>
        /// Pesquisa e carrega as editoras no grid.
        /// </summary>
        private void Pesquisar_Geftb011()
        {
            var dt = new DataTable();
            var geftb011 = new Geftb011();
            DgvGeftb011.DataSource = geftb011.Search(dt);
            if (dt.Rows.Count > 0)
            {
                DgvGeftb011.Columns[6].Visible = false;
                DgvGeftb011.Columns[7].Visible = false;
            }
        }

        /// <summary>
        /// Exibe os dados da editora selecionada no grid.
        /// </summary>
        private void Mostrar_Editora()
        {
            if (DgvGeftb011.CurrentRow != null)
            {
                TbCodigo.Text = DgvGeftb011.Rows[DgvGeftb011.CurrentCell.RowIndex].Cells[0].Value.ToString();
                TbDescricao.Text = DgvGeftb011.Rows[DgvGeftb011.CurrentCell.RowIndex].Cells[1].Value.ToString();
                String cnpj = DgvGeftb011.Rows[DgvGeftb011.CurrentCell.RowIndex].Cells[2].Value.ToString();
                TbTel1.Text = DgvGeftb011.Rows[DgvGeftb011.CurrentCell.RowIndex].Cells[3].Value.ToString();
                TbTel2.Text = DgvGeftb011.Rows[DgvGeftb011.CurrentCell.RowIndex].Cells[4].Value.ToString();
                TbEmail.Text = DgvGeftb011.Rows[DgvGeftb011.CurrentCell.RowIndex].Cells[5].Value.ToString();
                cnpj = cnpj.PadLeft(14, '0');
                MskCnpj.Text = cnpj;
                DgvGeftb011.Columns[6].Visible = false;
                DgvGeftb011.Columns[7].Visible = false;
            }
        }

        /// <summary>
        /// Evento disparado ao clicar em uma célula do grid de editoras.
        /// </summary>
        private void DgvGeftb011_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Mostrar_Editora();
        }

        /// <summary>
        /// Fecha o formulário de editora.
        /// </summary>
        private void FecharFormulárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
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
            BtnLimpForm.Visible = true;
            Limpa_Form();
        }

        /// <summary>
        /// Limpa os campos do formulário ao clicar no botão Limpar.
        /// </summary>
        private void BtnLimpForm_Click(object sender, EventArgs e)
        {
            Limpa_Form();
        }

        /// <summary>
        /// Fecha o formulário de editora ao clicar no botão Sair.
        /// </summary>
        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Atualiza os dados da editora após validação dos campos.
        /// </summary>
        private void BtnAtuReg_Click(object sender, EventArgs e)
        {
            int critica = IsValidForm();
            if (critica == 0)
            {
                string dt4 = DateTime.Now.ToString("yyyy/MM/dd");
                String cnpj = MskCnpj.Text;
                cnpj = cnpj.PadLeft(14, '0');
                var geftb011 = new Geftb011();
                geftb011.Update(Convert.ToInt32(TbCodigo.Text), TbDescricao.Text, cnpj, TbTel1.Text, TbTel2.Text, TbEmail.Text, dt4);
                MessageBox.Show("Editora atualizada com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Limpa_Form();
                Pesquisar_Geftb011();
                TbCodigo.Clear();
                TbDescricao.Clear();
                TbDescricao.Focus();
            }
        }

        /// <summary>
        /// Evento disparado ao pressionar uma tecla no grid de editoras.
        /// </summary>
        private void DgvGeftb011_KeyDown(object sender, KeyEventArgs e)
        {
            Mostrar_Editora();
        }

        /// <summary>
        /// Evento disparado ao pressionar uma tecla no grid de editoras.
        /// </summary>
        private void DgvGeftb011_KeyPress(object sender, KeyPressEventArgs e)
        {
            Mostrar_Editora();
        }

        /// <summary>
        /// Evento disparado ao liberar uma tecla no grid de editoras.
        /// </summary>
        private void DgvGeftb011_KeyUp(object sender, KeyEventArgs e)
        {
            Mostrar_Editora();
        }

        /// <summary>
        /// Confirma o cadastro de editora após validação dos campos.
        /// </summary>
        private void BtnConf_Click(object sender, EventArgs e)
        {
            int critica = IsValidForm();
            if (critica == 0)
            {
                string dt4 = DateTime.Now.ToString("yyyy/MM/dd");
                if (ParmGlobal.titoudep == 0)
                {
                    TbCodigo.Text = "0";
                }
                String cnpj = MskCnpj.Text;
                cnpj = cnpj.PadLeft(14, '0');
                DataTable dtEditora = new DataTable();
                var geftb011 = new Geftb011();
                geftb011.SearchNomeCnpj(TbDescricao.Text, cnpj, dtEditora);
                if (dtEditora.Rows.Count == 0)
                {
                    geftb011.Insert(TbDescricao.Text, cnpj, TbTel1.Text, TbTel2.Text, TbEmail.Text, dt4);
                    MessageBox.Show("Editora incluida com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Limpa_Form();
                    Pesquisar_Geftb011();
                    BtnSair.Visible = true;
                    BtnAtuReg.Visible = true;
                    BtnCadastrar.Visible = true;
                    BtnLimpForm.Visible = true;
                    BtnCan.Visible = false;
                    BtnConf.Visible = false;
                    TbCodigo.Clear();
                    TbDescricao.Clear();
                    TbDescricao.Focus();
                }
                else
                {
                    MessageBox.Show("Editora já cadastrada.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TbDescricao.Focus();
                    TbCodigo.Clear();
                    TbDescricao.Clear();
                    TbDescricao.Focus();
                }
            }
        }

        /// <summary>
        /// Cancela a operação e retorna o formulário ao estado inicial.
        /// </summary>
        private void BtnCan_Click(object sender, EventArgs e)
        {
            BtnSair.Visible = true;
            BtnAtuReg.Visible = true;
            BtnCadastrar.Visible = true;
            BtnLimpForm.Visible = true;
            BtnCan.Visible = false;
            BtnConf.Visible = false;
            TbCodigo.Clear();
            TbDescricao.Clear();
            TbDescricao.Focus();
        }

        /// <summary>
        /// Prepara o formulário para cadastro de nova editora.
        /// </summary>
        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            BtnSair.Visible = false;
            BtnAtuReg.Visible = false;
            BtnCadastrar.Visible = false;
            BtnLimpForm.Visible = false;
            BtnCan.Visible = true;
            BtnConf.Visible = true;
            TbCodigo.Clear();
            TbDescricao.Clear();
            TbDescricao.Focus();
        }
    }
}

using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data;
using System.Runtime.CompilerServices;

namespace NovoGEF.Forms
{
    /// <summary>
    /// Formulário responsável pelo cadastro, pesquisa e atualização de livros na livraria.
    /// </summary>
    public partial class FrmLivraria : Form
    {
        /// <summary>
        /// Inicializa uma nova instância do formulário de livraria.
        /// </summary>
        public FrmLivraria()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento disparado ao carregar o formulário. Verifica se o usuário está logado e inicializa os dados.
        /// </summary>
        private void FrmLivraria_Load(object sender, EventArgs e)
        {
            if (ParmGlobal.usuarioId == 0)
            {
                MessageBox.Show("Usuário não logado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BtnAtuReg.Enabled = false;
                BtnCadastrar.Enabled = false;
                BtnPesquisar.Enabled = false;
                BtnCadAutor.Enabled   = false;
                BtnLimpForm.Enabled = false;
            }else
            {
                Pesquisar_Geftb009();
                Pesquisar_Geftb010();
                Pesquisar_Geftb011();
                Pesquisar_Geftb012(3);
                TbTitulo.Enabled = false;
                TbAssunto.Enabled = false;
                TbEstoque.Enabled = false;
                TbVlUnitario.Enabled = false;
                TbVlLivraria.Enabled = false;
                TbVlFeira.Enabled = false;
            }
        }

        /// <summary>
        /// Limpa todos os campos do formulário de livraria.
        /// </summary>
        private void Limpa_Form()
        {
            CbxCodigo.Checked = false;
            CbxTitulo.Checked = false;
            CbxAssunto.Checked = false;
            TbSearchCodigo.Clear();
            TbSearchTitulo.Clear();
            TbSearchAssunto.Clear();
            TbIdLivraria.Clear();
            TbTitulo.Clear();
            TbAssunto.Clear();
            TbEstoque.Text = "0";
            TbVlUnitario.Text = "0.00";
            TbVlLivraria.Text = "0.00";
            TbVlFeira.Text = "0.00";
        }

        /// <summary>
        /// Pesquisa e carrega os autores espirituais no combobox.
        /// </summary>
        private void Pesquisar_Geftb009()
        {
            var dtAutorEsp = new DataTable();
            var geftb009 = new Geftb009();
            CbAutorEsp.DataSource = geftb009.Search(dtAutorEsp);
            if (dtAutorEsp.Rows.Count > 0)
            {
                CbAutorEsp.ValueMember = dtAutorEsp.Columns[0].ColumnName.ToString();
                CbAutorEsp.DisplayMember = dtAutorEsp.Columns[1].ColumnName.ToString();
            }
            else
            {
                MessageBox.Show("Não existem autores espirituais para listar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Pesquisa e carrega os autores no combobox.
        /// </summary>
        private void Pesquisar_Geftb010()
        {
            var dtAutor = new DataTable();
            var geftb010 = new Geftb010();
            CbAutor.DataSource = geftb010.Search(dtAutor);
            if (dtAutor.Rows.Count > 0)
            {
                CbAutor.ValueMember = dtAutor.Columns[0].ColumnName.ToString();
                CbAutor.DisplayMember = dtAutor.Columns[1].ColumnName.ToString();
            }else
            {
                MessageBox.Show("Não existem autores para listar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Pesquisa e carrega as editoras no combobox.
        /// </summary>
        private void Pesquisar_Geftb011()
        {
            var dtEditora = new DataTable();
            var geftb011 = new Geftb011();
            CbEditora.DataSource = geftb011.Search(dtEditora);
            if (dtEditora.Rows.Count > 0)
            {
                CbEditora.ValueMember = dtEditora.Columns[0].ColumnName.ToString();
                CbEditora.DisplayMember = dtEditora.Columns[1].ColumnName.ToString();
            }
            else
            {
                MessageBox.Show("Não existem editoras para listar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Realiza validações nos campos do formulário de livro.
        /// </summary>
        /// <returns>Retorna 0 se válido, 1 se houver erro.</returns>
        private int IsValidForm()
        {
            bool isNumeric_Estoque = Regex.IsMatch(TbEstoque.Text, @"^\d+$");
            if (String.IsNullOrEmpty(TbTitulo.Text))
            {
                MessageBox.Show("Campo título não aceita vazio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TbTitulo.Focus();
                return 1;
            }
            if (String.IsNullOrEmpty(TbAssunto.Text))
            {
                MessageBox.Show("Campo assunto não aceita vazio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TbAssunto.Focus();
                return 1;
            }
            else if (!isNumeric_Estoque)
            {
                MessageBox.Show("Campo estoque deve conter números.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TbEstoque.Focus();
                return 1;
            }
            return 0;
        }

        /// <summary>
        /// Evento disparado ao clicar no botão pesquisar. Realiza pesquisa conforme filtros selecionados.
        /// </summary>
        private void Btn_Pesquisar_Click(object sender, EventArgs e)
        {
            if (CbxCodigo.Checked.Equals(true))
            {
                CbxTitulo.Checked = false;
                CbxAssunto.Checked = false;
                Pesquisar_Geftb012(0);
            }
            else if (CbxTitulo.Checked.Equals(true))
            {
                CbxCodigo.Checked = false;
                CbxAssunto.Checked = false;
                Pesquisar_Geftb012(1);
            }
            else if (CbxAssunto.Checked.Equals(true))
            {
                CbxTitulo.Checked = false;
                CbxCodigo.Checked = false;
                Pesquisar_Geftb012(2);
            }else
            {
                CbxAssunto.Checked = false;
                CbxTitulo.Checked = false;
                CbxCodigo.Checked = false;
                Pesquisar_Geftb012(3);
            }
        }

        /// <summary>
        /// Realiza pesquisa de livros conforme filtro informado.
        /// </summary>
        /// <param name="filtro">Filtro de pesquisa: 0=Código, 1=Título, 2=Assunto, 3=Todos.</param>
        private void Pesquisar_Geftb012(int filtro)
        {
            var dtLivraria = new DataTable();
            var geftb012 = new Geftb012();
            if (filtro == 0)
            {
                DgvGeftb012.DataSource = geftb012.SearchCodigo(Convert.ToInt32(TbSearchCodigo.Text), dtLivraria);
            }
            else if (filtro == 1)
            {
                DgvGeftb012.DataSource = geftb012.SearchTitulo(TbSearchTitulo.Text, dtLivraria);
            }
            else if (filtro == 2)
            {
                DgvGeftb012.DataSource = geftb012.SearchAssunto(TbSearchAssunto.Text, dtLivraria);
            }
            else 
            {
                DgvGeftb012.DataSource = geftb012.Search(dtLivraria);
            }
            if (dtLivraria.Rows.Count > 0)
            {
                DgvGeftb012.Columns[0].HeaderText = "Código";
                DgvGeftb012.Columns[0].DefaultCellStyle
                        .Alignment = DataGridViewContentAlignment.MiddleRight;
                DgvGeftb012.Columns[1].HeaderText = "Título";
                DgvGeftb012.Columns[2].HeaderText = "Assunto";
                DgvGeftb012.Columns[3].HeaderText = "Autor Espiritual";
                DgvGeftb012.Columns[4].HeaderText = "Autor";
                DgvGeftb012.Columns[5].HeaderText = "Editora";
                DgvGeftb012.Columns[6].HeaderText = "Estoque";
                DgvGeftb012.Columns[6].DefaultCellStyle
                        .Alignment = DataGridViewContentAlignment.MiddleRight;
                DgvGeftb012.Columns[7].HeaderText = "Valor Unitário";
                DgvGeftb012.Columns[7].DefaultCellStyle
                        .Alignment = DataGridViewContentAlignment.MiddleRight;
                DgvGeftb012.Columns[8].HeaderText = "Valor Livraria";
                DgvGeftb012.Columns[8].DefaultCellStyle
                        .Alignment = DataGridViewContentAlignment.MiddleRight;
                DgvGeftb012.Columns[9].HeaderText = "Valor Feira";
                DgvGeftb012.Columns[9].DefaultCellStyle
                        .Alignment = DataGridViewContentAlignment.MiddleRight; 
                DgvGeftb012.Columns[1].Width = 160;
                DgvGeftb012.Columns[2].Width = 160;
                DgvGeftb012.Columns[3].Width = 160;
                DgvGeftb012.Columns[4].Width = 320;
                DgvGeftb012.Columns[5].Width = 160;
                DgvGeftb012.Columns[10].Visible = false;
                DgvGeftb012.Columns[11].Visible = false;
            }
        }

        /// <summary>
        /// Exibe os dados do livro selecionado no grid.
        /// </summary>
        private void Mostrar_Livraria()
        {
            if (DgvGeftb012.CurrentRow != null)
            {
                TbIdLivraria.Text = DgvGeftb012.Rows[DgvGeftb012.CurrentCell.RowIndex].Cells[0].Value.ToString();
                TbTitulo.Text = DgvGeftb012.Rows[DgvGeftb012.CurrentCell.RowIndex].Cells[1].Value.ToString();
                TbAssunto.Text = DgvGeftb012.Rows[DgvGeftb012.CurrentCell.RowIndex].Cells[2].Value.ToString();
                CbAutorEsp.Text = DgvGeftb012.Rows[DgvGeftb012.CurrentCell.RowIndex].Cells[3].Value.ToString();
                CbAutor.Text = DgvGeftb012.Rows[DgvGeftb012.CurrentCell.RowIndex].Cells[4].Value.ToString();
                CbEditora.Text = DgvGeftb012.Rows[DgvGeftb012.CurrentCell.RowIndex].Cells[5].Value.ToString();
                TbEstoque.Text = DgvGeftb012.Rows[DgvGeftb012.CurrentCell.RowIndex].Cells[6].Value.ToString();
                Decimal vlUnitario = decimal.Parse(DgvGeftb012.Rows[DgvGeftb012.CurrentCell.RowIndex].Cells[7].Value.ToString());
                Decimal vlFeira = decimal.Parse(DgvGeftb012.Rows[DgvGeftb012.CurrentCell.RowIndex].Cells[8].Value.ToString());
                Decimal vlLivraria = decimal.Parse(DgvGeftb012.Rows[DgvGeftb012.CurrentCell.RowIndex].Cells[9].Value.ToString());
                TbVlUnitario.Text = vlUnitario.ToString("N2");
                TbVlFeira.Text = vlFeira.ToString("N2");
                TbVlLivraria.Text = vlLivraria.ToString("N2");
                TbTitulo.Enabled = true;
                TbAssunto.Enabled = true;
                TbEstoque.Enabled = true;
                TbVlUnitario.Enabled = true;
                TbVlLivraria.Enabled = true;
                TbVlFeira.Enabled = true;
                TbTitulo.Focus();
            }
        }

        /// <summary>
        /// Evento disparado ao clicar em uma célula do grid de livros.
        /// </summary>
        private void DgvGeftb002_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Mostrar_Livraria();
        }

        /// <summary>
        /// Evento disparado ao alterar o estado do checkbox de código.
        /// </summary>
        private void CbxCodigo_CheckedChanged(object sender, EventArgs e)
        {
            CbxTitulo.Checked = false;
            CbxAssunto.Checked = false;
            TbSearchCodigo.Text = string.Empty;
            TbSearchTitulo.Text = string.Empty;
            TbSearchAssunto.Text = string.Empty;
        }

        /// <summary>
        /// Evento disparado ao alterar o estado do checkbox de título.
        /// </summary>
        private void CbxTitulo_CheckedChanged(object sender, EventArgs e)
        {
            CbxCodigo.Checked = false;
            CbxAssunto.Checked = false;
            TbSearchCodigo.Text = string.Empty;
            TbSearchTitulo.Text = string.Empty;
            TbSearchAssunto.Text = string.Empty;
        }

        /// <summary>
        /// Evento disparado ao alterar o estado do checkbox de assunto.
        /// </summary>
        private void CbxAssunto_CheckedChanged(object sender, EventArgs e)
        {
            CbxCodigo.Checked = false;
            CbxTitulo.Checked = false;
            TbSearchCodigo.Text = string.Empty;
            TbSearchTitulo.Text = string.Empty;
            TbSearchAssunto.Text = string.Empty;
        }

        /// <summary>
        /// Cancela a operação e retorna o formulário ao estado inicial.
        /// </summary>
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            TbIdLivraria.Clear();
            BtnCadastrar.Visible = true;
            BtnCadAutor.Visible = true;
            BtnLimpForm.Visible = true;
            BtnAtuReg.Visible = true;
            BtnSair.Visible = true;
            BtnConf.Visible = false;
            BtnCancel.Visible = false;
            groupBox3.Enabled = true;
            Limpa_Form();
            TbTitulo.Enabled = false;
            TbAssunto.Enabled = false;
            TbEstoque.Enabled = false;
            TbVlUnitario.Enabled = false;
            TbVlLivraria.Enabled = false;
            TbVlFeira.Enabled = false;
        }

        /// <summary>
        /// Confirma o cadastro de livro após validação dos campos.
        /// </summary>
        private void BtnConf_Click(object sender, EventArgs e)
        {
            int critica = IsValidForm();
            if (critica == 0)
            {
                string dt4 = DateTime.Now.ToString("yyyy/MM/dd");
                Decimal vlunitario = decimal.Parse(TbVlUnitario.Text);
                Decimal vllivraria = decimal.Parse(TbVlLivraria.Text);
                Decimal vlfeira = decimal.Parse(TbVlFeira.Text);
                var geftb012 = new Geftb012();
                geftb012.Insert(TbTitulo.Text, TbAssunto.Text, Convert.ToInt32(CbAutor.SelectedValue), Convert.ToInt32(CbAutorEsp.SelectedValue), 
                    Convert.ToInt32(CbEditora.SelectedValue) , Convert.ToInt32(TbEstoque.Text), vlunitario, vllivraria, vlfeira, dt4);
                MessageBox.Show("Livro incluido com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BtnCadastrar.Visible = true;
                BtnCadAutor.Visible = true;
                BtnLimpForm.Visible = true;
                BtnAtuReg.Visible = true;
                BtnSair.Visible = true;
                BtnConf.Visible = false;
                BtnCancel.Visible = false;
                groupBox3.Enabled = true;
                Limpa_Form();
                Limpa_Form();
                TbTitulo.Enabled = false;
                TbAssunto.Enabled = false;
                TbEstoque.Enabled = false;
                TbVlUnitario.Enabled = false;
                TbVlLivraria.Enabled = false;
                TbVlFeira.Enabled = false;
                Pesquisar_Geftb012(3);
            }
        }

        /// <summary>
        /// Limpa os campos do formulário ao clicar no botão Limpar.
        /// </summary>
        private void BtnLimpForm_Click(object sender, EventArgs e)
        {
            Limpa_Form();
        }

        /// <summary>
        /// Fecha o formulário de livraria ao clicar no botão Sair.
        /// </summary>
        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Prepara o formulário para cadastro de novo livro.
        /// </summary>
        private void BtnCadAss_Click(object sender, EventArgs e)
        {
            ParmGlobal.titoudep = 0;
            BtnCadastrar.Visible = false;
            BtnCadAutor.Visible = false;
            BtnLimpForm.Visible = false;
            BtnAtuReg.Visible = false;
            BtnSair.Visible = false;
            BtnConf.Visible = true;
            BtnCancel.Visible = true;
            groupBox3.Enabled = false;
            Limpa_Form();
            TbTitulo.Enabled = true;
            TbAssunto.Enabled = true;
            TbEstoque.Enabled = true;
            TbVlUnitario.Enabled = true;
            TbVlLivraria.Enabled = true;
            TbVlFeira.Enabled = true;
            TbTitulo.Focus();
        }

        /// <summary>
        /// Atualiza os dados do livro após validação dos campos.
        /// </summary>
        private void BtnAtuReg_Click(object sender, EventArgs e)
        {
            int critica = IsValidForm();
            if (critica == 0)
            {
                string dt4 = DateTime.Now.ToString("yyyy/MM/dd");
                Decimal vlunitario = decimal.Parse(TbVlUnitario.Text);
                Decimal vllivraria = decimal.Parse(TbVlLivraria.Text);
                Decimal vlfeira = decimal.Parse(TbVlFeira.Text);
                var geftb012 = new Geftb012();
                geftb012.Update(Convert.ToInt32(TbIdLivraria.Text), TbTitulo.Text, TbAssunto.Text, Convert.ToInt32(CbAutor.SelectedValue), Convert.ToInt32(CbAutorEsp.SelectedValue),
                    Convert.ToInt32(CbEditora.SelectedValue), Convert.ToInt32(TbEstoque.Text), vlunitario, vllivraria, vlfeira, dt4);
                MessageBox.Show("Livro atualizado com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Limpa_Form();
                Pesquisar_Geftb012(3);
                TbTitulo.Enabled = false;
                TbAssunto.Enabled = false;
                TbEstoque.Enabled = false;
                TbVlUnitario.Enabled = false;
                TbVlLivraria.Enabled = false;
                TbVlFeira.Enabled = false;
            }
        }

        /// <summary>
        /// Evento disparado ao pressionar uma tecla no grid de livros.
        /// </summary>
        private void DgvGeftb002_KeyDown(object sender, KeyEventArgs e)
        {
            Mostrar_Livraria();
        }

        /// <summary>
        /// Evento disparado ao pressionar uma tecla no grid de livros.
        /// </summary>
        private void DgvGeftb002_KeyPress(object sender, KeyPressEventArgs e)
        {
            Mostrar_Livraria();
        }

        /// <summary>
        /// Evento disparado ao liberar uma tecla no grid de livros.
        /// </summary>
        private void DgvGeftb002_KeyUp(object sender, KeyEventArgs e)
        {
            Mostrar_Livraria();
        }

        /// <summary>
        /// Validação de entrada para campo valor unitário (aceita apenas números e vírgula).
        /// </summary>
        private void TbVlUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("este campo aceita somente numero e virgula");
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                MessageBox.Show("este campo aceita somente uma virgula");
            }
        }

        /// <summary>
        /// Validação de entrada para campo valor livraria (aceita apenas números e vírgula).
        /// </summary>
        private void TbVlLivraria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("este campo aceita somente numero e virgula");
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                MessageBox.Show("este campo aceita somente uma virgula");
            }
        }

        /// <summary>
        /// Validação de entrada para campo valor feira (aceita apenas números e vírgula).
        /// </summary>
        private void TbVlFeira_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("este campo aceita somente numero e virgula");
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                MessageBox.Show("este campo aceita somente uma virgula");
            }
        }

        /// <summary>
        /// Abre o formulário de cadastro de autor.
        /// </summary>
        private void BtnCadAutor_Click(object sender, EventArgs e)
        {
            FrmLivAutor frm = new FrmLivAutor();
            frm.ShowDialog();
        }

        /// <summary>
        /// Abre o formulário de cadastro de autor espiritual.
        /// </summary>
        private void BtnCadAutorEsp_Click(object sender, EventArgs e)
        {
            FrmLivAutorEsp frm = new FrmLivAutorEsp();
            frm.ShowDialog();
        }

        /// <summary>
        /// Abre o formulário de cadastro de editora.
        /// </summary>
        private void BtnCadEditora_Click(object sender, EventArgs e)
        {
            FrmLivEditora frm = new FrmLivEditora();
            frm.ShowDialog();
        }

        /// <summary>
        /// Atualiza os dados dos combobox de autores e editoras.
        /// </summary>
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            Pesquisar_Geftb009();
            Pesquisar_Geftb010();
            Pesquisar_Geftb011();
        }
    }
}

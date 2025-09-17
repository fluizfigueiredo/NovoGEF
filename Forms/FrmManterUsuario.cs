using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace NovoGEF.Forms
{
    /// <summary>
    /// Formulário responsável pelo cadastro, pesquisa e atualização de usuários do sistema.
    /// </summary>
    public partial class FrmManterUsuario : Form
    {
        /// <summary>
        /// Inicializa uma nova instância do formulário de manutenção de usuário.
        /// </summary>
        public FrmManterUsuario()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento disparado ao carregar o formulário. Verifica se o usuário está logado e inicializa os dados.
        /// </summary>
        private void FrmManterUsuario_Load(object sender, EventArgs e)
        {
            if (ParmGlobal.usuarioId == 0)
            {
                MessageBox.Show("Usuário não logado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BtnAtuReg.Enabled = false;
                BtnCadastrar.Enabled = false;
            } else
            {
                if (Pesquisar_Geftb001(0, null) == "N") {
                    MessageBox.Show("Não existe usuário para lisar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        /// <summary>
        /// Pesquisa usuários conforme o id ou matrícula informados.
        /// </summary>
        /// <param name="id_usuario">Id do usuário para pesquisa.</param>
        /// <param name="matricula">Matrícula do usuário para pesquisa.</param>
        /// <returns>Retorna "S" se encontrou registros, "N" se não encontrou.</returns>
        public string Pesquisar_Geftb001(int id_usuario, string matricula)
        {
            DataTable dt = new DataTable();
            Geftb001 geftb001 = new Geftb001();
            DgvGeftb001.DataSource = geftb001.SearchUsuario(id_usuario, matricula, dt);
            if (dt.Rows.Count > 0)
            {
                DgvGeftb001.Columns[0].Visible = false;
                DgvGeftb001.Columns[1].HeaderText = "Matricula";
                DgvGeftb001.Columns[1].DefaultCellStyle
                        .Alignment = DataGridViewContentAlignment.MiddleRight;
                DgvGeftb001.Columns[2].HeaderText = "Nome";
                DgvGeftb001.Columns[3].HeaderText = "Data Início";
                DgvGeftb001.Columns[3].DefaultCellStyle
                        .Alignment = DataGridViewContentAlignment.MiddleRight;
                DgvGeftb001.Columns[4].HeaderText = "Data Fim";
                DgvGeftb001.Columns[4].DefaultCellStyle
                        .Alignment = DataGridViewContentAlignment.MiddleRight;
                DgvGeftb001.Columns[5].HeaderText = "Nível";
                DgvGeftb001.Columns[5].DefaultCellStyle
                        .Alignment = DataGridViewContentAlignment.MiddleRight;
                DgvGeftb001.Columns[1].Width = 70;
                DgvGeftb001.Columns[2].Width = 340;
                DgvGeftb001.Columns[5].Width = 40;
                return "S";
            }
            else {  return "N"; }
        }

        /// <summary>
        /// Realiza validações nos campos do formulário de usuário.
        /// </summary>
        /// <returns>Retorna 0 se válido, 1 se houver erro.</returns>
        private int IsValidForm()
        {
            if (String.IsNullOrEmpty(TbMatricula.Text))
            {
                MessageBox.Show("Campo Matricula pecisa ser informado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TbNome.Focus();
                return 1;
            }
            else if (String.IsNullOrEmpty(CbNivelSeg.Text))
            {
                MessageBox.Show("Campo Nível pecisa ser informado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TbNome.Focus();
                return 1;
            }
            return 0;
        }

        /// <summary>
        /// Exibe os dados do usuário selecionado no grid.
        /// </summary>
        private void Mostrar_Associado()
        {
            if (DgvGeftb001.CurrentRow != null)
            {
                TbIdUsuario.Text = DgvGeftb001.Rows[DgvGeftb001.CurrentCell.RowIndex].Cells[0].Value.ToString();
                TbMatricula.Text = DgvGeftb001.Rows[DgvGeftb001.CurrentCell.RowIndex].Cells[1].Value.ToString();
                TbNome.Text = DgvGeftb001.Rows[DgvGeftb001.CurrentCell.RowIndex].Cells[2].Value.ToString();
                DtpInicio.Text = DgvGeftb001.Rows[DgvGeftb001.CurrentCell.RowIndex].Cells[3].Value.ToString();
                DtpFim.Text = DgvGeftb001.Rows[DgvGeftb001.CurrentCell.RowIndex].Cells[4].Value.ToString();
                TbDtFim.Text = DgvGeftb001.Rows[DgvGeftb001.CurrentCell.RowIndex].Cells[4].Value.ToString();
                if (DgvGeftb001.Rows[DgvGeftb001.CurrentCell.RowIndex].Cells[4].Value.ToString() == "")
                {
                    CbxDtFim.Checked = false;
                }
                else
                {
                    CbxDtFim.Checked = true;
                }
                CbNivelSeg.Text = DgvGeftb001.Rows[DgvGeftb001.CurrentCell.RowIndex].Cells[5].Value.ToString();
            }
        }

        /// <summary>
        /// Fecha o formulário de manutenção de usuário.
        /// </summary>
        private void FecharFormulárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Prepara o formulário para cadastro de novo usuário e realiza a inclusão após validação.
        /// </summary>
        private void BtnCadAss_Click(object sender, EventArgs e)
        {
            string senha = "gef@12345";
            int critica = IsValidForm();
            if (critica == 0)
            {
                string matricula = TbMatricula.Text.Substring(0, 6) + TbMatricula.Text.Substring(7, 2);
                if (Pesquisar_Geftb001(0, matricula) == "S")
                {
                    MessageBox.Show("Usuário já cadastrado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    var geftb001 = new Geftb001();
                    string dt2 = DtpInicio.Value.ToString("yyyy/MM/dd");
                    string dt4 = DateTime.Now.ToString("yyyy/MM/dd");
                    geftb001.Insert(senha, matricula, dt2, Convert.ToInt32(CbNivelSeg.Text), dt4);
                    MessageBox.Show("Usuário incluido com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LimpaForm();
                    if (Pesquisar_Geftb001(0, null) == "S")
                    {
                        MessageBox.Show("Não existe usuário para lisar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        /// <summary>
        /// Evento disparado ao clicar em uma célula do grid de usuários.
        /// </summary>
        private void DgvGeftb001_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Mostrar_Associado();
        }

        /// <summary>
        /// Evento disparado ao pressionar uma tecla no grid de usuários.
        /// </summary>
        private void DgvGeftb001_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Mostrar_Associado();
        }

        /// <summary>
        /// Evento disparado ao liberar uma tecla no grid de usuários.
        /// </summary>
        private void DgvGeftb001_KeyUp_1(object sender, KeyEventArgs e)
        {
            Mostrar_Associado();
        }

        /// <summary>
        /// Evento disparado ao pressionar uma tecla no grid de usuários.
        /// </summary>
        private void DgvGeftb001_KeyDown_1(object sender, KeyEventArgs e)
        {
            Mostrar_Associado();
        }

        /// <summary>
        /// Atualiza os dados do usuário após validação dos campos.
        /// </summary>
        private void BtnAtuReg_Click_1(object sender, EventArgs e)
        {
            int critica = IsValidForm();
            if (critica == 0)
            {
                string dt2 = DtpInicio.Value.ToString("yyyy/MM/dd");
                string dt3;
                string dt4 = DateTime.Now.ToString("yyyy/MM/dd");
                bool ativado = false;
                if (TbDtFim.Text == "")
                {
                    ativado = true;
                }
                if (CbxDtFim.Checked == true && ativado == true)
                {
                    const string message = "Quer realmente desligar esse Usuário?";
                    const string caption = "ATENÇÃO";
                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        dt3 = DtpFim.Value.ToString("yyyy/MM/dd");
                        var geftb001 = new Geftb001();
                        geftb001.Update(Convert.ToInt32(TbIdUsuario.Text), dt2, dt3, Convert.ToInt32(CbNivelSeg.Text), dt4);
                        MessageBox.Show("Usuário atualizado com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        LimpaForm();
                        DataTable dt = new DataTable();
                        DgvGeftb001.DataSource = geftb001.SearchUsuario(0, null, dt);
                    }
                }
                else if (CbxDtFim.Checked == false && ativado == false)
                {
                    const string message = "Quer realmente reativar esse Usuário?";
                    const string caption = "ATENÇÃO";
                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        dt3 = null;
                        var geftb001 = new Geftb001();
                        geftb001.Update(Convert.ToInt32(TbIdUsuario.Text), dt2, dt3, Convert.ToInt32(CbNivelSeg.Text), dt4);
                        MessageBox.Show("Usuário atualizado com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        LimpaForm();
                        DataTable dt = new DataTable();
                        DgvGeftb001.DataSource = geftb001.SearchUsuario(0, null, dt);
                    }
                }
                else if (CbxDtFim.Checked == false && ativado == true)
                {
                    dt3 = null;
                    var geftb001 = new Geftb001();
                    geftb001.Update(Convert.ToInt32(TbIdUsuario.Text), dt2, dt3, Convert.ToInt32(CbNivelSeg.Text), dt4);
                    MessageBox.Show("Usuário atualizado com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LimpaForm();
                    DataTable dt = new DataTable();
                    DgvGeftb001.DataSource = geftb001.SearchUsuario(0, null, dt);
                }
            }
        }

        /// <summary>
        /// Limpa os campos do formulário de usuário.
        /// </summary>
        public void LimpaForm()
        {
            TbMatricula.Clear();
            TbNome.Clear();
            CbNivelSeg.Text = "";
        }

        /// <summary>
        /// Fecha o formulário de manutenção de usuário.
        /// </summary>
        private void BtnSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Reseta a senha do usuário para o padrão inicial.
        /// </summary>
        private void BtnResSenha_Click(object sender, EventArgs e)
        {
            string dt4 = DateTime.Now.ToString("yyyy/MM/dd");
            var geftb001 = new Geftb001();
            string senha = "gef@12345";
            geftb001.UpdateSenha(TbMatricula.Text, senha, dt4);
            MessageBox.Show("Senha do usuário resetada", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            LimpaForm();
            DataTable dt = new DataTable();
            DgvGeftb001.DataSource = geftb001.SearchUsuario(0, null, dt);
        }

        /// <summary>
        /// Abre o formulário de busca de associado e preenche os campos do usuário.
        /// </summary>
        private void BtnBuscarAss_Click(object sender, EventArgs e)
        {
            FrmBuscarAssociado frm = new FrmBuscarAssociado();
            frm.ShowDialog();
            TbIdUsuario.Text = ParmGlobal.dados_associado[0];
            TbMatricula.Text = ParmGlobal.dados_associado[1];
            TbNome.Text = ParmGlobal.dados_associado[2];
        }

        /// <summary>
        /// Evento disparado ao alterar o estado do checkbox de data fim.
        /// </summary>
        private void CbxDtFim_CheckedChanged(object sender, EventArgs e)
        {
            if (CbxDtFim.Checked == true)
            {
                DtpFim.Visible = true;
            }
            else
            {
                DtpFim.Visible = false;
            }
        }
    }
}

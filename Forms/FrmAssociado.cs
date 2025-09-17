using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data;
using NovoGEF.Util;
using NovoGEF.Models;
using NovoGEF.fabianoDataSetTableAdapters;

namespace NovoGEF.Forms
{
    /// <summary>
    /// Formulário responsável pelo cadastro, pesquisa e atualização de associados e dependentes.
    /// </summary>
    public partial class FrmAssociado : Form
    {
        Associado _associado = new Associado();
        /// <summary>
        /// Inicializa uma nova instância do formulário de associado.
        /// </summary>
        public FrmAssociado()
        {
            InitializeComponent();
            CbTipoAss.SelectedIndex = 0;
        }

        /// <summary>
        /// Evento disparado ao carregar o formulário. Verifica se o usuário está logado e inicializa variáveis globais.
        /// </summary>
        private void FrmAssociado_Load(object sender, EventArgs e)
        {
            if (ParmGlobal.usuarioId == 0)
            {
                MessageBox.Show("Usuário não logado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BtnAtuReg.Enabled = false;
                BtnCadastrar.Enabled = false;
                BtnPesquisar.Enabled = false;
                BtnCadDep.Enabled   = false;
                BtnLimpForm.Enabled = false;
            }else
            {
                ParmGlobal.tipo = "A";
                ParmGlobal.classificacao = 0;
                ParmGlobal.situacao = 0;
            }
        }

        /// <summary>
        /// Limpa todos os campos do formulário de associado.
        /// </summary>
        private void Limpa_Form()
        {
            if (ParmGlobal.titoudep != 1)
            {
                TbMatricula.Clear();
            }
            CbxMatricula.Checked = false;
            CbxNome.Checked = false;
            TbSearchMatricula.Clear();
            TbNome.Clear();
            TbSearchNome.Clear();
            MskCpf.Clear();
            TbTel1.Clear();
            TbTel2.Clear();
            TbEndereco.Clear();
            TbBairro.Clear();
            TbCidade.Clear();
            MskCep.Clear();
            TbEmail.Clear();
            TbObs.Clear();
            TbNomeCracha.Clear();
            TbMatricula.Clear();
            string dt4 = DateTime.Now.ToString("yyyy/MM/dd");
            DtpInicio.Text = dt4;
            DtpFim.Text = dt4;
            DtpNascimento.Text = dt4;
            DtpFim.Visible = true;
            CbxDtFim.Visible = true;
        }

        /// <summary>
        /// Realiza validações nos campos do formulário de associado.
        /// </summary>
        /// <returns>Retorna 0 se válido, 1 se houver erro.</returns>
        /// <summary>
        /// Evento disparado ao clicar no botão pesquisar. Realiza pesquisa conforme filtros selecionados.
        /// </summary>
        private void Btn_Pesquisar_Click(object sender, EventArgs e)
        {
            if (CbxMatricula.Checked.Equals(false) && CbxNome.Checked.Equals(false))
            {
                Pesquisar_Geftb002(0);
            }
            else if (CbxMatricula.Checked.Equals(true))
            {
                Pesquisar_Geftb002(1);
            }
            else if (CbxNome.Checked.Equals(true))
            {
                Pesquisar_Geftb002(2);
            }
        }

        /// <summary>
        /// Realiza pesquisa de associados conforme filtro informado.
        /// </summary>
        /// <param name="filtro">Filtro de pesquisa: 0=Todos, 1=Matricula, 2=Nome.</param>
        private void Pesquisar_Geftb002(int filtro)
        {
            var dt = new DataTable();
            var geftb002 = new Geftb002();
            if (filtro == 0)
            {
                DgvGeftb002.DataSource = geftb002.Search(ParmGlobal.tipo, ParmGlobal.classificacao, ParmGlobal.situacao, dt);
            }
            else if (filtro == 1)
            {
                DgvGeftb002.DataSource = geftb002.SearchMatricula(ParmGlobal.tipo, ParmGlobal.classificacao, ParmGlobal.situacao, TbSearchMatricula.Text, dt);
            }
            else if (filtro == 2)
            {
                DgvGeftb002.DataSource = geftb002.SearchNome(ParmGlobal.tipo, ParmGlobal.classificacao, ParmGlobal.situacao, TbSearchNome.Text, dt);
            }
            if (dt.Rows.Count > 0)
            {
                DgvGeftb002.Columns[0].Visible = false;
                DgvGeftb002.Columns[2].Visible = false;
                DgvGeftb002.Columns[3].Visible = false;
                DgvGeftb002.Columns[16].Visible = false;
                DgvGeftb002.Columns[17].Visible = false;
            }
        }

        /// <summary>
        /// Exibe os dados do associado selecionado no grid.
        /// </summary>
        private void Mostrar_Associado()
        {
            if (DgvGeftb002.CurrentRow != null)
            {
                TbIdAssociado.Text = DgvGeftb002.Rows[DgvGeftb002.CurrentCell.RowIndex].Cells[0].Value.ToString();
                TbMatricula.Text = DgvGeftb002.Rows[DgvGeftb002.CurrentCell.RowIndex].Cells[1].Value.ToString();
                TbMatricula.Text = DgvGeftb002.Rows[DgvGeftb002.CurrentCell.RowIndex].Cells[1].Value.ToString();
                DtpInicio.Text = DgvGeftb002.Rows[DgvGeftb002.CurrentCell.RowIndex].Cells[2].Value.ToString();
                DtpFim.Text = DgvGeftb002.Rows[DgvGeftb002.CurrentCell.RowIndex].Cells[3].Value.ToString();
                if (DgvGeftb002.Rows[DgvGeftb002.CurrentCell.RowIndex].Cells[3].Value.ToString() == null)
                {
                    CbxDtFim.Checked = false;
                    CbxAssociadoDesligado.Checked = false;
                }
                else
                {
                    CbxDtFim.Checked = true;
                    CbxAssociadoDesligado.Checked = true;
                }
                TbNome.Text = DgvGeftb002.Rows[DgvGeftb002.CurrentCell.RowIndex].Cells[4].Value.ToString();
                DtpNascimento.Text = DgvGeftb002.Rows[DgvGeftb002.CurrentCell.RowIndex].Cells[5].Value.ToString();
                TbEndereco.Text = DgvGeftb002.Rows[DgvGeftb002.CurrentCell.RowIndex].Cells[6].Value.ToString();
                TbBairro.Text = DgvGeftb002.Rows[DgvGeftb002.CurrentCell.RowIndex].Cells[7].Value.ToString();
                TbCidade.Text = DgvGeftb002.Rows[DgvGeftb002.CurrentCell.RowIndex].Cells[8].Value.ToString();
                String cep = DgvGeftb002.Rows[DgvGeftb002.CurrentCell.RowIndex].Cells[9].Value.ToString();
                TbTel1.Text = DgvGeftb002.Rows[DgvGeftb002.CurrentCell.RowIndex].Cells[10].Value.ToString();
                TbTel2.Text = DgvGeftb002.Rows[DgvGeftb002.CurrentCell.RowIndex].Cells[11].Value.ToString();
                String cpf = DgvGeftb002.Rows[DgvGeftb002.CurrentCell.RowIndex].Cells[12].Value.ToString(); 
                TbObs.Text = DgvGeftb002.Rows[DgvGeftb002.CurrentCell.RowIndex].Cells[13].Value.ToString();
                TbEmail.Text = DgvGeftb002.Rows[DgvGeftb002.CurrentCell.RowIndex].Cells[14].Value.ToString();
                CbParentesco.Text = DgvGeftb002.Rows[DgvGeftb002.CurrentCell.RowIndex].Cells[15].Value.ToString();


                // Pega o primeiro nome, do início da string até o primeiro espaço
                int primeiroEspaco = TbNome.Text.IndexOf(' ');
                if (primeiroEspaco>0)
                {
                    string primeiroNome = TbNome.Text.Substring(0, primeiroEspaco);

                    // Encontra o índice do último espaço
                    int ultimoEspaco = TbNome.Text.LastIndexOf(' ');

                    // Pega o último nome, do último espaço até o fim da string
                    string ultimoNome = TbNome.Text.Substring(ultimoEspaco + 1);

                    TbNomeCracha.Text = primeiroNome + " " + ultimoNome;
                } else
                {
                    TbNomeCracha.Text = TbNome.Text;
                }

                cpf = cpf.PadLeft(11, '0');
                cep = cep.PadLeft(8, '0');
                MskCpf.Text = cpf;
                MskCep.Text = cep;
                DgvGeftb002.Columns[0].Visible = false;
                DgvGeftb002.Columns[2].Visible = false;
                DgvGeftb002.Columns[3].Visible = false;
                DgvGeftb002.Columns[16].Visible = false;
                DgvGeftb002.Columns[17].Visible = false;
            }
        }

        /// <summary>
        /// Evento disparado ao clicar em uma célula do grid de associados.
        /// </summary>
        private void DgvGeftb002_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Mostrar_Associado();
        }

        /// <summary>
        /// Evento disparado ao alterar o estado do checkbox de matrícula.
        /// </summary>
        private void Cbx_Matricula_CheckedChanged(object sender, EventArgs e)
        {
            CbxNome.Checked = false;
            TbSearchNome.Text = string.Empty;
            TbSearchMatricula.Text = string.Empty;
        }

        /// <summary>
        /// Evento disparado ao alterar o estado do checkbox de nome.
        /// </summary>
        private void Cbx_Nome_CheckedChanged(object sender, EventArgs e)
        {
            CbxMatricula.Checked = false;
            TbSearchMatricula.Text = string.Empty;
            TbSearchNome.Text = string.Empty;
        }

        /// <summary>
        /// Fecha o formulário de associado.
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
            TbMatricula.Clear();
            BtnCadastrar.Visible = true;
            BtnCadDep.Visible = true;
            BtnLimpForm.Visible = true;
            BtnAtuReg.Visible = true;
            BtnSair.Visible = true;
            BtnConf.Visible = false;
            BtnCancel.Visible = false;
            groupBox3.Enabled = true;
            Limpa_Form();
        }

        /// <summary>
        /// Confirma o cadastro de associado ou dependente após validação dos campos.
        /// </summary>
        private void BtnConf_Click(object sender, EventArgs e)
        {
            String cpf = MskCpf.Text;
            String cep = MskCep.Text;
            _associado.Id_Associado = 0;
            _associado.Matricula = TbMatricula.Text;
            _associado.Nome = TbNome.Text;
            _associado.Dt_Nascimento = DtpNascimento.Value.ToString("yyyy/MM/dd");
            _associado.Dt_Ini = DtpInicio.Value.ToString("yyyy/MM/dd");
            _associado.Dt_Fim = null;
            _associado.Cpf = cpf.PadLeft(11, '0');
            _associado.Tel1 = TbTel1.Text;
            _associado.Tel2 = TbTel2.Text;
            _associado.Email = TbEmail.Text;
            _associado.Endereco = TbEndereco.Text;
            _associado.Bairro = TbBairro.Text;
            _associado.Cidade = TbCidade.Text;
            _associado.Cep = cep.PadLeft(8, '0');
            _associado.Parentesco = CbParentesco.Text;
            _associado.Obs = TbObs.Text;
            _associado.Geftb001_Id_Usuario = ParmGlobal.usuarioId;
            _associado.Dt_Gravacao = DateTime.Now;
            var result = _associado.Insert();
            if (result == "ok")
            {
//                var geftb002 = new Geftb002();
//                geftb002.Insert(ParmGlobal.titoudep, _associado.Matricula, _associado.Nome, _associado.Dt_Nascimento, _associado.Dt_Ini, _associado.Dt_Fim, _associado.Cpf, _associado.Tel1, _associado.Tel2, _associado.Email,
//                            _associado.Endereco, _associado.Bairro, _associado.Cidade, _associado.Cep, _associado.Parentesco, _associado.Obs, _associado.Geftb001_Id_Usuario, _associado.Dt_Gravacao.ToString("dd/MM/yyyy"));
                if (ParmGlobal.titoudep == 0)
                {
                    MessageBox.Show("Associado incluido com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Dependente de associado incluido com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                BtnCadastrar.Visible = true;
                BtnCadDep.Visible = true;
                BtnLimpForm.Visible = true;
                BtnAtuReg.Visible = true;
                BtnSair.Visible = true;
                BtnConf.Visible = false;
                BtnCancel.Visible = false;
                groupBox3.Enabled = true;
                Limpa_Form();
                Limpa_Form();
                Pesquisar_Geftb002(0);
            }
            else
            {
                MessageBox.Show(result, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Limpa os campos do formulário ao clicar no botão Limpar.
        /// </summary>
        private void BtnLimpForm_Click(object sender, EventArgs e)
        {
            TbMatricula.Clear();
            Limpa_Form();
        }

        /// <summary>
        /// Fecha o formulário de associado ao clicar no botão Sair.
        /// </summary>
        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Prepara o formulário para cadastro de associado titular.
        /// </summary>
        private void BtnCadAss_Click(object sender, EventArgs e)
        {
            ParmGlobal.titoudep = 0;
            BtnCadastrar.Visible = false;
            BtnCadDep.Visible = false;
            BtnLimpForm.Visible = false;
            BtnAtuReg.Visible = false;
            BtnSair.Visible = false;
            BtnConf.Visible = true;
            BtnCancel.Visible = true;
            groupBox3.Enabled = false;
            Limpa_Form();
            DtpFim.Visible = false;
            CbxDtFim.Visible = false;
            TbNome.Focus();
        }

        /// <summary>
        /// Prepara o formulário para cadastro de dependente de associado.
        /// </summary>
        private void BtnCadDep_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TbMatricula.Text))
            {
                MessageBox.Show("Para cadastrar um novo dependente você deve primeiro selecionar um titular na lista.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TbMatricula.Focus();
            }else
            {
                ParmGlobal.titoudep = 1;
                BtnCadastrar.Visible = false;
                BtnCadDep.Visible = false;
                BtnLimpForm.Visible = false;
                BtnAtuReg.Visible = false;
                BtnSair.Visible = false;
                BtnConf.Visible = true;
                BtnCancel.Visible = true;
                groupBox3.Enabled = false;
                Limpa_Form();
                DtpFim.Visible = false;
                CbxDtFim.Visible = false;
                TbNome.Focus();
            }
        }

        /// <summary>
        /// Atualiza os dados do associado após validação dos campos.
        /// </summary>
        private void BtnAtuReg_Click(object sender, EventArgs e)
        {
            String cpf = MskCpf.Text;
            String cep = MskCep.Text;
            _associado.Id_Associado = int.Parse(TbIdAssociado.Text);
            _associado.Matricula = TbMatricula.Text;
            _associado.Nome = TbNome.Text;
            _associado.Dt_Nascimento = DtpNascimento.Value.ToString("yyyy/MM/dd");
            _associado.Dt_Ini = DtpInicio.Value.ToString("yyyy/MM/dd");
            _associado.Dt_Fim = null;
            _associado.Cpf = cpf.PadLeft(11, '0');
            _associado.Tel1 = TbTel1.Text;
            _associado.Tel2 = TbTel2.Text;
            _associado.Email = TbEmail.Text;
            _associado.Endereco = TbEndereco.Text;
            _associado.Bairro = TbBairro.Text;
            _associado.Cidade = TbCidade.Text;
            _associado.Cep = cep.PadLeft(8, '0');
            _associado.Parentesco = CbParentesco.Text;
            _associado.Obs = TbObs.Text;
            _associado.Geftb001_Id_Usuario = ParmGlobal.usuarioId;
            _associado.Dt_Gravacao = DateTime.Now;
            if (CbxAssociadoDesligado.Checked  == false && CbxDtFim.Checked == true)
            {
                var result = MessageBox.Show("Quer realmente desligar esse associado?", "ATENÇÃO",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    _associado.Dt_Fim = DtpFim.Value.string("dd/MM/yyyy");
                    var resultValidation = _associado.Update();
                    if (resultValidation == "ok")
                       MessageBox.Show("Associado atualizado com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (CbxAssociadoDesligado.Checked == true && CbxDtFim.Checked == false)
            {
                var result = MessageBox.Show("Quer realmente reativar esse associado?", "ATENÇÃO",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    _associado.Dt_Fim = null;
                    var resultValidation = _associado.Update();
                    if (resultValidation == "ok")
                        MessageBox.Show("Associado atualizado com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            Limpa_Form();
            Pesquisar_Geftb002(0);
        }

        /// <summary>
        /// Evento disparado ao pressionar uma tecla no grid de associados.
        /// </summary>
        private void DgvGeftb002_KeyDown(object sender, KeyEventArgs e)
        {
            Mostrar_Associado();
        }

        /// <summary>
        /// Evento disparado ao pressionar uma tecla no grid de associados.
        /// </summary>
        private void DgvGeftb002_KeyPress(object sender, KeyPressEventArgs e)
        {
            Mostrar_Associado();
        }

        /// <summary>
        /// Evento disparado ao liberar uma tecla no grid de associados.
        /// </summary>
        private void DgvGeftb002_KeyUp(object sender, KeyEventArgs e)
        {
            Mostrar_Associado();
        }

        /// <summary>
        /// Evento disparado ao alterar o tipo de associado selecionado.
        /// </summary>
        private void CbTipoAss_SelectedIndexChanged(object sender, EventArgs e)
        {
            ParmGlobal.tipo = CbTipoAss.SelectedItem.ToString().Substring(0, 1);
        }

        /// <summary>
        /// Evento disparado ao selecionar o tipo titular.
        /// </summary>
        private void RbTitular_CheckedChanged(object sender, EventArgs e)
        {
            if (RbTitular.Checked == true)
            {
                ParmGlobal.classificacao = 1;
            }
        }

        /// <summary>
        /// Evento disparado ao selecionar o tipo todos.
        /// </summary>
        private void RbTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (RbTodos.Checked == true)
            {
                ParmGlobal.classificacao = 0;
            }
        }

        /// <summary>
        /// Evento disparado ao selecionar o tipo dependente.
        /// </summary>
        private void RbDependente_CheckedChanged(object sender, EventArgs e)
        {
            if (RbDependente.Checked == true)
            {
                ParmGlobal.classificacao = 2;
            }
        }

        /// <summary>
        /// Evento disparado ao selecionar situação ativa.
        /// </summary>
        private void RbAtivo_CheckedChanged(object sender, EventArgs e)
        {
            if (RbAtivo.Checked == true)
            {
                ParmGlobal.situacao = 0;
            }
        }

        /// <summary>
        /// Evento disparado ao selecionar situação inativa.
        /// </summary>
        private void RbInativo_CheckedChanged(object sender, EventArgs e)
        {
            if (RbInativo.Checked == true)
            {
                ParmGlobal.situacao = 1;
            }
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

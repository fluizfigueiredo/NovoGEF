using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data;

namespace NovoGEF.Forms
{
    /// <summary>
    /// Formulário responsável pela busca e seleção de associados.
    /// </summary>
    public partial class FrmBuscarAssociado : Form
    {
        /// <summary>
        /// Inicializa uma nova instância do formulário de busca de associado.
        /// </summary>
        public FrmBuscarAssociado()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento disparado ao carregar o formulário. Verifica se o usuário está logado e inicializa os dados.
        /// </summary>
        private void FrmBuscarAssociado_Load(object sender, EventArgs e)
        {
            if (ParmGlobal.usuarioId == 0)
            {
                MessageBox.Show("Usuário não logado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BtnPesquisar.Enabled = false;
            }else
            {
                ParmGlobal.tipo = "F";
                ParmGlobal.classificacao = 0;
                ParmGlobal.situacao = 0;
                Pesquisar_Geftb002(0);
            }
        }

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
                DgvGeftb002.Columns[5].Visible = false;
                DgvGeftb002.Columns[6].Visible = false;
                DgvGeftb002.Columns[7].Visible = false;
                DgvGeftb002.Columns[8].Visible = false;
                DgvGeftb002.Columns[9].Visible = false;
                DgvGeftb002.Columns[10].Visible = false;
                DgvGeftb002.Columns[11].Visible = false;
                DgvGeftb002.Columns[12].Visible = false;
                DgvGeftb002.Columns[13].Visible = false;
                DgvGeftb002.Columns[14].Visible = false;
                DgvGeftb002.Columns[15].Visible = false;
                DgvGeftb002.Columns[16].Visible = false;
                DgvGeftb002.Columns[17].Visible = false;
                DgvGeftb002.Columns[4].Width = 340;
            }
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
        /// Fecha o formulário de busca de associado.
        /// </summary>
        private void FecharFormulárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Confirma a seleção do associado e retorna os dados para o formulário principal.
        /// </summary>
        private void BtnConf_Click(object sender, EventArgs e)
        {   
            ParmGlobal.dados_associado[0] = DgvGeftb002.CurrentRow.Cells[0].Value.ToString();
            ParmGlobal.dados_associado[1] = DgvGeftb002.CurrentRow.Cells[1].Value.ToString(); 
            ParmGlobal.dados_associado[2] = DgvGeftb002.CurrentRow.Cells[4].Value.ToString(); 
            this.Close(); 
        }

        /// <summary>
        /// Fecha o formulário ao clicar no botão Sair.
        /// </summary>
        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

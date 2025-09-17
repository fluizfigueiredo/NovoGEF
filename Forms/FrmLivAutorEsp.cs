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
using System.Runtime.InteropServices.ComTypes;

namespace NovoGEF.Forms
{
    /// <summary>
    /// Formulário responsável pelo cadastro, pesquisa e atualização de autores espirituais de livros.
    /// </summary>
    public partial class FrmLivAutorEsp : Form
    {
        /// <summary>
        /// Inicializa uma nova instância do formulário de autor espiritual de livro.
        /// </summary>
        public FrmLivAutorEsp()
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
            }else
            {
                Pesquisar_Geftb009();
            }
        }

        /// <summary>
        /// Realiza validação do campo nome do autor espiritual.
        /// </summary>
        /// <returns>Retorna 0 se válido, 1 se houver erro.</returns>
        private int IsValidForm()
        {
            if (String.IsNullOrEmpty(TbNomeAutorEsp.Text))
            {
                MessageBox.Show("Campo nome do autor espiritual não aceita vazio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TbNomeAutorEsp.Focus();
                return 1;
            }
            return 0;
        }

        /// <summary>
        /// Exibe os dados do autor espiritual selecionado no grid.
        /// </summary>
        private void Mostrar_Autor()
        {
            if (DgvGeftb009.CurrentRow != null)
            {
                TbIdAutorEsp.Text = DgvGeftb009.Rows[DgvGeftb009.CurrentCell.RowIndex].Cells[0].Value.ToString();
                TbNomeAutorEsp.Text = DgvGeftb009.Rows[DgvGeftb009.CurrentCell.RowIndex].Cells[1].Value.ToString();
            }
        }

        /// <summary>
        /// Pesquisa e carrega os autores espirituais no grid.
        /// </summary>
        private void Pesquisar_Geftb009()
        {
            DataTable dt = new DataTable();
            var geftb009 = new Geftb009();
            DgvGeftb009.DataSource = geftb009.Search(dt);
            if (dt.Rows.Count > 0)
            {
                DgvGeftb009.Columns[0].HeaderText = "Código";
                DgvGeftb009.Columns[1].HeaderText = "Nome do Autor Espiritual";
                DgvGeftb009.Columns[2].Visible = false;
                DgvGeftb009.Columns[3].Visible = false;
                DgvGeftb009.Columns[1].Width = 320;
            }
        }

        /// <summary>
        /// Fecha o formulário de autor espiritual de livro.
        /// </summary>
        private void BtnSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Evento para limpar o formulário (não implementado).
        /// </summary>
        private void BtnLimpForm_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Atualiza os dados do autor espiritual após validação dos campos.
        /// </summary>
        private void BtnAtuReg_Click(object sender, EventArgs e)
        {
            int critica = IsValidForm();
            if (critica == 0)
            {
                string dt4 = DateTime.Now.ToString("yyyy/MM/dd");
                var geftb009 = new Geftb009();
                geftb009.Update(Convert.ToInt32(TbIdAutorEsp.Text), TbNomeAutorEsp.Text, dt4);
                MessageBox.Show("Autor(a) atualizado(a) com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Pesquisar_Geftb009();
                TbIdAutorEsp.Clear();
                TbNomeAutorEsp.Clear();
                TbNomeAutorEsp.Focus();
            }
        }

        /// <summary>
        /// Prepara o formulário para cadastro de novo autor espiritual.
        /// </summary>
        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            BtnCan.Visible = true;
            BtnConf.Visible = true;
            BtnCadastrar.Visible = false;
            BtnAtuReg.Visible = false;
            BtnSair.Visible = false;
            TbIdAutorEsp.Clear();
            TbNomeAutorEsp.Clear();
            TbNomeAutorEsp.Focus();
        }

        /// <summary>
        /// Evento disparado ao pressionar uma tecla no grid de autores espirituais.
        /// </summary>
        private void DgvGeftb009_KeyDown(object sender, KeyEventArgs e)
        {
            Mostrar_Autor();
        }

        /// <summary>
        /// Evento disparado ao pressionar uma tecla no grid de autores espirituais.
        /// </summary>
        private void DgvGeftb009_KeyPress(object sender, KeyPressEventArgs e)
        {
            Mostrar_Autor();
        }

        /// <summary>
        /// Evento disparado ao liberar uma tecla no grid de autores espirituais.
        /// </summary>
        private void DgvGeftb009_KeyUp(object sender, KeyEventArgs e)
        {
            Mostrar_Autor();
        }

        /// <summary>
        /// Evento disparado ao clicar em uma célula do grid de autores espirituais.
        /// </summary>
        private void DgvGeftb009_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Mostrar_Autor();
        }

        /// <summary>
        /// Confirma o cadastro de autor espiritual após validação dos campos.
        /// </summary>
        private void BtnConf_Click(object sender, EventArgs e)
        {
            int critica = IsValidForm();
            if (critica == 0)
            {
                DataTable dt = new DataTable();
                var geftb009 = new Geftb009();
                DgvGeftb009.DataSource = geftb009.SearchNome(TbNomeAutorEsp.Text, dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Autor espiritual já cadastrado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TbNomeAutorEsp.Focus();
                    Pesquisar_Geftb009();
                    TbIdAutorEsp.Clear();
                    TbNomeAutorEsp.Clear();
                    TbNomeAutorEsp.Focus();
                }
                else
                {
                    string dt4 = DateTime.Now.ToString("yyyy/MM/dd");
                    geftb009.Insert(TbNomeAutorEsp.Text, dt4);
                    MessageBox.Show("Autor espiritual incluido(a) com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Pesquisar_Geftb009();
                    BtnCan.Visible = false;
                    BtnConf.Visible = false;
                    BtnCadastrar.Visible = true;
                    BtnAtuReg.Visible = true;
                    BtnSair.Visible = true;
                    TbIdAutorEsp.Clear();
                    TbNomeAutorEsp.Clear();
                    TbNomeAutorEsp.Focus();
                }
            }
        }

        /// <summary>
        /// Cancela a operação e retorna o formulário ao estado inicial.
        /// </summary>
        private void BtnCan_Click(object sender, EventArgs e)
        {
            BtnCan.Visible = false;
            BtnConf.Visible = false;
            BtnCadastrar.Visible = true;
            BtnAtuReg.Visible = true;
            BtnSair.Visible = true;
            TbIdAutorEsp.Clear();
            TbNomeAutorEsp.Clear();
            TbNomeAutorEsp.Focus();
        }
    }
}

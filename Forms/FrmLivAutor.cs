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
    /// Formulário responsável pelo cadastro, pesquisa e atualização de autores de livros.
    /// </summary>
    public partial class FrmLivAutor : Form
    {
        /// <summary>
        /// Inicializa uma nova instância do formulário de autor de livro.
        /// </summary>
        public FrmLivAutor()
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
                Pesquisar_Geftb010();
            }
        }

        /// <summary>
        /// Realiza validação do campo nome do autor.
        /// </summary>
        /// <returns>Retorna 0 se válido, 1 se houver erro.</returns>
        private int IsValidForm()
        {
            if (String.IsNullOrEmpty(TbNomeAutor.Text))
            {
                MessageBox.Show("Campo nome do autor não aceita vazio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TbNomeAutor.Focus();
                return 1;
            }
            return 0;
        }

        /// <summary>
        /// Exibe os dados do autor selecionado no grid.
        /// </summary>
        private void Mostrar_Autor()
        {
            if (DgvGeftb010.CurrentRow != null)
            {
                TbIdAutor.Text = DgvGeftb010.Rows[DgvGeftb010.CurrentCell.RowIndex].Cells[0].Value.ToString();
                TbNomeAutor.Text = DgvGeftb010.Rows[DgvGeftb010.CurrentCell.RowIndex].Cells[1].Value.ToString();
            }
        }

        /// <summary>
        /// Pesquisa e carrega os autores no grid.
        /// </summary>
        private void Pesquisar_Geftb010()
        {
            DataTable dt = new DataTable();
            var geftb010 = new Geftb010();
            DgvGeftb010.DataSource = geftb010.Search(dt);
            if (dt.Rows.Count > 0)
            {
                DgvGeftb010.Columns[0].HeaderText = "Código";
                DgvGeftb010.Columns[1].HeaderText = "Nome do Autor";
                DgvGeftb010.Columns[2].Visible = false;
                DgvGeftb010.Columns[3].Visible = false;
                DgvGeftb010.Columns[1].Width = 320;
            }
        }

        /// <summary>
        /// Fecha o formulário de autor de livro.
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
        /// Atualiza os dados do autor após validação dos campos.
        /// </summary>
        private void BtnAtuReg_Click(object sender, EventArgs e)
        {
            int critica = IsValidForm();
            if (critica == 0)
            {
                string dt4 = DateTime.Now.ToString("yyyy/MM/dd");
                var geftb010 = new Geftb010();
                geftb010.Update(Convert.ToInt32(TbIdAutor.Text), TbNomeAutor.Text, dt4);
                MessageBox.Show("Autor(a) atualizado(a) com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Pesquisar_Geftb010();
                TbIdAutor.Clear();
                TbNomeAutor.Clear();
                TbNomeAutor.Focus();
            }
        }

        /// <summary>
        /// Prepara o formulário para cadastro de novo autor.
        /// </summary>
        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            BtnAtuReg.Visible = false;  
            BtnSair.Visible = false;   
            BtnCadastrar.Visible = false;
            BtnConf.Visible = true;
            BtnCan.Visible = true;
            TbIdAutor.Clear();
            TbNomeAutor.Clear();
            TbNomeAutor.Focus();
        }

        /// <summary>
        /// Evento disparado ao pressionar uma tecla no grid de autores.
        /// </summary>
        private void DgvGeftb010_KeyDown(object sender, KeyEventArgs e)
        {
            Mostrar_Autor();
        }

        /// <summary>
        /// Evento disparado ao pressionar uma tecla no grid de autores.
        /// </summary>
        private void DgvGeftb010_KeyPress(object sender, KeyPressEventArgs e)
        {
            Mostrar_Autor();
        }

        /// <summary>
        /// Evento disparado ao liberar uma tecla no grid de autores.
        /// </summary>
        private void DgvGeftb010_KeyUp(object sender, KeyEventArgs e)
        {
            Mostrar_Autor();
        }

        /// <summary>
        /// Evento disparado ao clicar em uma célula do grid de autores.
        /// </summary>
        private void DgvGeftb010_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Mostrar_Autor();
        }

        /// <summary>
        /// Confirma o cadastro de autor após validação dos campos.
        /// </summary>
        private void BtnConf_Click(object sender, EventArgs e)
        {
            int critica = IsValidForm();
            if (critica == 0)
            {
                DataTable dt = new DataTable();
                var geftb010 = new Geftb010();
                DgvGeftb010.DataSource = geftb010.SearchNome(TbNomeAutor.Text, dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Autor(a) já cadastrado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TbNomeAutor.Focus();
                    Pesquisar_Geftb010();
                }
                else
                {
                    string dt4 = DateTime.Now.ToString("yyyy/MM/dd");
                    geftb010.Insert(TbNomeAutor.Text, dt4);
                    MessageBox.Show("Autor(a) incluido(a) com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    BtnAtuReg.Visible = true;
                    BtnSair.Visible = true;
                    BtnCadastrar.Visible = true;
                    BtnConf.Visible = false;
                    BtnCan.Visible = false;
                    Pesquisar_Geftb010();
                    TbIdAutor.Clear();
                    TbNomeAutor.Clear();
                    TbNomeAutor.Focus();
                }
            }
        }

        /// <summary>
        /// Cancela a operação e retorna o formulário ao estado inicial.
        /// </summary>
        private void BtnCan_Click(object sender, EventArgs e)
        {
            BtnAtuReg.Visible = true;
            BtnSair.Visible = true;
            BtnCadastrar.Visible = true;
            BtnConf.Visible = false;
            BtnCan.Visible = false;
            TbIdAutor.Clear();
            TbNomeAutor.Clear();
            TbNomeAutor.Focus();
        }
    }
}

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
using static NovoGEF.FrmAtividade;
using System.Collections;

namespace NovoGEF.Forms
{
    /// <summary>
    /// Formulário responsável pela alteração de senha do usuário.
    /// </summary>
    public partial class FrmAlteraSenha : Form
    {
        readonly ParmGlobal ParmGlobal = new ParmGlobal(); 

        /// <summary>
        /// Inicializa uma nova instância do formulário de alteração de senha.
        /// </summary>
        /// <param name="matricula">Matrícula do usuário para alteração de senha.</param>
        public FrmAlteraSenha(string matricula)
        {
            InitializeComponent();
            TbMatricula.Text = matricula;
        }

        /// <summary>
        /// Evento disparado ao carregar o formulário de alteração de senha.
        /// </summary>
        private void FormAlteraSenha_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Confirma a alteração de senha do usuário ao clicar no botão Confirmar.
        /// </summary>
        /// <param name="sender">Objeto que disparou o evento.</param>
        /// <param name="e">Argumentos do evento.</param>
        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            string dt4 = DateTime.Now.ToString("yyyy/MM/dd");
            var dt = new DataTable();
            var geftb001 = new Geftb001();
            DgvGeftb001.DataSource = geftb001.Search(TbMatricula.Text, TbSenhaAtual.Text, dt);
            if (DgvGeftb001.RowCount > 0)
            {
                string usu = DgvGeftb001.Rows[index: 0].Cells[0].Value.ToString();
                ParmGlobal.usuarioId = Convert.ToInt32(usu);
                geftb001.UpdateSenha(TbMatricula.Text, TbSenhaNova.Text, dt4);
                MessageBox.Show("Senha do usuário alterada com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("Usuário conectado com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            else
            {
                MessageBox.Show("Senha atual não confere.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TbSenhaAtual.Focus();
            }
        }

        /// <summary>
        /// Confirma a alteração de senha do usuário ao clicar no botão Conf.
        /// </summary>
        /// <param name="sender">Objeto que disparou o evento.</param>
        /// <param name="e">Argumentos do evento.</param>
        private void BtnConf_Click(object sender, EventArgs e)
        {
            string dt4 = DateTime.Now.ToString("yyyy/MM/dd");
            var dt = new DataTable();
            var geftb001 = new Geftb001();
            DgvGeftb001.DataSource = geftb001.Search(TbMatricula.Text, TbSenhaAtual.Text, dt);
            if (DgvGeftb001.RowCount > 0)
            {
                string usu = DgvGeftb001.Rows[index: 0].Cells[0].Value.ToString();
                ParmGlobal.usuarioId = Convert.ToInt32(usu);
                geftb001.UpdateSenha(TbMatricula.Text, TbSenhaNova.Text, dt4);
                MessageBox.Show("Senha do usuário alterada com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("Usuário conectado com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            else
            {
                MessageBox.Show("Senha atual não confere.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TbSenhaAtual.Focus();
            }
        }

        /// <summary>
        /// Fecha o formulário de alteração de senha ao clicar no botão Cancelar.
        /// </summary>
        /// <param name="sender">Objeto que disparou o evento.</param>
        /// <param name="e">Argumentos do evento.</param>
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

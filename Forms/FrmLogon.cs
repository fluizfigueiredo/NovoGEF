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
using static NovoGEF.Forms.FrmAtividade;
using System.Collections;
using System.Diagnostics.Eventing.Reader;

namespace NovoGEF.Forms
{
    /// <summary>
    /// Formulário responsável pelo logon do usuário no sistema.
    /// </summary>
    public partial class FrmLogon : Form
    {
        /// <summary>
        /// Inicializa uma nova instância do formulário de logon.
        /// </summary>
        public FrmLogon()
        {
            InitializeComponent();
            TbMatricula.Text = "F0059700";
            TbSenha.Text = "gef@adm";
        }

        /// <summary>
        /// Evento disparado ao carregar o formulário. Define o foco no campo matrícula.
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            TbMatricula.Focus();
        }

        /// <summary>
        /// Fecha o formulário de logon ao clicar no botão Sair.
        /// </summary>
        private void BtnSair_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Evento para conectar ao sistema (não implementado).
        /// </summary>
        private void BtnConecta_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Confirma o logon do usuário, valida credenciais e inicializa sessão.
        /// </summary>
        private void BtnConf_Click(object sender, EventArgs e)
        {
            if (TbSenha.Text == "gef@12345")
            {
                FrmAlteraSenha frm = new FrmAlteraSenha(TbMatricula.Text);
                Close();
                frm.ShowDialog();
            }
            else
            {
                var dt = new DataTable();
                var geftb001 = new Geftb001();
                DgvGeftb001.DataSource = geftb001.Search(TbMatricula.Text, TbSenha.Text, dt);
                if (DgvGeftb001.RowCount > 0)
                {
                    string usu = DgvGeftb001.Rows[index: 0].Cells[0].Value.ToString();
                    string nomeusu = DgvGeftb001.Rows[index: 0].Cells[1].Value.ToString();
                    string nivel = DgvGeftb001.Rows[index: 0].Cells[2].Value.ToString();
                    ParmGlobal.usuarioId = Convert.ToInt32(usu);
                    ParmGlobal.usuarioNome = nomeusu;
                    ParmGlobal.nivel = Convert.ToInt32(nivel);
                    int hora = DateTime.Now.Hour;
                    var saudacoes = new string[] { "Boa madrugada", "Bom dia", "Boa tarde", "Boa noite" };
                    MessageBox.Show($"{saudacoes[hora / 6]} " + nomeusu + "! Você foi conectado com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    FrmPrincipal.ActiveForm.Text = "Novo Sistema Integrado do GEF" + " - Usuário: " + ParmGlobal.usuarioNome + " - Nível: " + ParmGlobal.nivel;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuário não encontrado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        /// <summary>
        /// Cancela o logon e fecha o formulário.
        /// </summary>
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

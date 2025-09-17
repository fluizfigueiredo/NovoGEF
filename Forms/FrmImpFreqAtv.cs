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

namespace NovoGEF.Forms
{
    /// <summary>
    /// Formulário responsável pela geração do relatório de frequência de atividades.
    /// </summary>
    public partial class FrmImpFreqAtv : Form
    {
        readonly ParmGlobal ParmGlobal = new ParmGlobal();

        /// <summary>
        /// Inicializa uma nova instância do formulário de impressão de frequência de atividade.
        /// </summary>
        /// <param name="dtagenda">Data da agenda para geração do relatório.</param>
        public FrmImpFreqAtv(string dtagenda)
        {
            InitializeComponent();
            TbDtAgenda.Text = dtagenda;
        }

        /// <summary>
        /// Evento disparado ao carregar o formulário. Carrega as atividades disponíveis para a data informada.
        /// </summary>
        private void FrmImpFreqAtv_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            var geftb005 = new Geftb005();
            CbAtividade.DataSource = geftb005.SearchAgendaAtv(TbDtAgenda.Text,dt);
            if (dt.Rows.Count > 0)
            {
                CbAtividade.ValueMember = dt.Columns[0].ColumnName.ToString();
                CbAtividade.DisplayMember = dt.Columns[1].ColumnName.ToString();
            }
            else
            {
                MessageBox.Show("Não existem registros cadastrados.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Gera o relatório de presença da atividade selecionada.
        /// </summary>
        private void BtnConf_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            var geftb005 = new Geftb005();
            DataTable dtAgenda = geftb005.SearchPresAtv(TbDtAgenda.Text, Convert.ToInt32(CbAtividade.SelectedValue), dt);
            if (dtAgenda.Rows.Count > 0)
            {
                int idatividade = dtAgenda.Rows[0].Field<Int32>("geftb003_atividade_id_atividade");
                string nomeatividade = dtAgenda.Rows[0].Field<string>("descricao");
                ParmGlobal.Titulo = "Relatório de Presença - " + nomeatividade + "\n\n";
                string tituloNome = nomeatividade.Replace(" ", "_");
                tituloNome = tituloNome.Replace("/", "_");
                ParmGlobal.nomeArquivo = ParmGlobal.caminho + @"Relatorio\PresencaAtividade_" + tituloNome + "_" + DateTime.Now.ToString("yyyy.MM.dd.HH.mm.ss") + ".pdf";
                RelPDF_PresAtividade.GerarRelatorioPDF(dtAgenda);
            }
            else
            {
                MessageBox.Show("Não existem registros para imprimir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Fecha o formulário de impressão de frequência de atividade.
        /// </summary>
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

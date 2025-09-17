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

namespace NovoGEF.Forms
{
    /// <summary>
    /// Formulário responsável pela associação e gerenciamento de atividades dos associados.
    /// </summary>
    public partial class FrmAssXAtv : Form
    {
        /// <summary>
        /// Inicializa uma nova instância do formulário de associação de atividades.
        /// </summary>
        public FrmAssXAtv()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento disparado ao carregar o formulário. Inicializa controles e carrega dados de atividades.
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            if (ParmGlobal.usuarioId == 0)
            {
                MessageBox.Show("Usuário não logado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BtnAtiva.Enabled = false;
                BtnDesativa.Enabled = false;
            }else
            {
                ParmGlobal.privez = 0;
                ParmGlobal.tipo = "A";
                ParmGlobal.classificacao = 0;
                ParmGlobal.situacao = 0;
                CbTipoAss.SelectedIndex = 0;
                DataTable  dt = new DataTable();
                var geftb003 = new Geftb003();
                DgvGeftb003.DataSource = geftb003.Search(0, dt);
                if (dt.Rows.Count > 0 )
                {
                    DgvGeftb003.Columns[2].Width = 240;
                    DgvGeftb003.Columns[3].Visible = false;
                    DgvGeftb003.Columns[4].Visible = false;
                    DgvGeftb003.Columns[5].Visible = false;
                    DgvGeftb003.Columns[6].Visible = false;
                    DgvGeftb003.Columns[7].Visible = false;
                    DgvGeftb003.Columns[8].Visible = false;
                    DgvGeftb003.Columns[9].Visible = false;
                    DgvGeftb003.Columns[10].Visible = false;
                    DgvGeftb003.Columns[11].Visible = false;
                    DgvGeftb003.Columns[12].Visible = false;
                }else
                {
                    MessageBox.Show("Não existem registros cadastrados.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        /// <summary>
        /// Fecha o formulário de associação de atividades.
        /// </summary>
        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Carrega as atividades associadas ao associado selecionado.
        /// </summary>
        private void ReadGeftb002()
        {
            ParmGlobal.idassociado = Convert.ToInt32(CbAssociado.SelectedValue.ToString());
            var geftb004 = new Geftb004();
            DgvGeftb004.DataSource = geftb004.Search(ParmGlobal.idassociado);
            
            DgvGeftb004.Columns[0].Visible = false;
            DgvGeftb004.Columns[3].Visible = false;
            DgvGeftb004.Columns[4].Visible = false;
            DgvGeftb004.Columns[5].Visible = false;
            DgvGeftb004.Columns[6].Visible = false;
            DgvGeftb004.Columns[1].HeaderText = "Matricula";
            DgvGeftb004.Columns[2].HeaderText = "Atividade";
        }

        /// <summary>
        /// Ativa uma atividade para o associado selecionado.
        /// </summary>
        private void BtnAtiva_Click(object sender, EventArgs e)
        {
            string dt1 = DateTime.Now.ToString("yyyy/MM/dd");
            string dt2 = DateTime.Now.ToString("yyyy/MM/dd");
            string dt3 = null;
            string CodAtv = DgvGeftb003.Rows[DgvGeftb003.CurrentCell.RowIndex].Cells[0].Value.ToString();

            var geftb004 = new Geftb004();
            var dt = new DataTable();

            dataGridView1.DataSource = geftb004.SearchAssAtv(ParmGlobal.idassociado, Convert.ToInt32(CodAtv), dt);
            if (dt.Rows.Count > 0)
            {
                string dt4 = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[6].Value.ToString();
                if (dt4 != "")
                {
                    var res = MessageBox.Show("Associado já possui essa atividade associada e a mesma está desativada. Gostaria de ativar essa atividade?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (res == DialogResult.Yes)
                    {
                        string id = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
                        geftb004.Update(Convert.ToInt32(id), dt3, dt2);
                        MessageBox.Show("Associado atualizado com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        DgvGeftb004.DataSource = geftb004.Search(ParmGlobal.idassociado);
                    }
                }
                else if (dt4 == "")
                {
                    MessageBox.Show("Atividade já cadastrada para este associado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    DgvGeftb004.DataSource = geftb004.Search(ParmGlobal.idassociado);
                }
                else
                {
                    geftb004.Insert(ParmGlobal.idassociado, Convert.ToInt32(CodAtv), dt1, dt3, dt2);
                    MessageBox.Show("Associado atualizado com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    DgvGeftb004.DataSource = geftb004.Search(ParmGlobal.idassociado);
                }
            }
            else
            {
                geftb004.Insert(ParmGlobal.idassociado, Convert.ToInt32(CodAtv), dt1, dt3, dt2);
                MessageBox.Show("Associado atualizado com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DgvGeftb004.DataSource = geftb004.Search(ParmGlobal.idassociado);
            }
        }

        /// <summary>
        /// Desativa a atividade selecionada do associado.
        /// </summary>
        private void BtnDesativa_Click(object sender, EventArgs e)
        {
            if (DgvGeftb004.RowCount > 0 && DgvGeftb004.SelectedRows.Count > 0)
            {
                string dt1 = DateTime.Now.ToString("yyyy/MM/dd");
                string dt2 = DateTime.Now.ToString("yyyy/MM/dd");
                string id = DgvGeftb004.Rows[DgvGeftb004.CurrentCell.RowIndex].Cells[0].Value.ToString();
                var geftb004 = new Geftb004();
                geftb004.Update(Convert.ToInt32(id), dt1, dt2);
                MessageBox.Show("Associado atualizado com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DgvGeftb004.DataSource = geftb004.Search(ParmGlobal.idassociado);
            }
        }

        /// <summary>
        /// Evento disparado ao alterar o tipo de associado selecionado.
        /// Atualiza a lista de associados conforme o tipo.
        /// </summary>
        private void CbTipoAss_SelectedIndexChanged(object sender, EventArgs e)
        {
            ParmGlobal.tipo = CbTipoAss.SelectedItem.ToString().Substring(0,1);
            DataTable dt = new DataTable();
            var geftb002 = new Geftb002();
            CbAssociado.DataSource = geftb002.SearchIdNome(ParmGlobal.tipo, dt);
            if (dt.Rows.Count > 0)
            {
                CbAssociado.ValueMember = dt.Columns[0].ColumnName.ToString();
                CbAssociado.DisplayMember = dt.Columns[1].ColumnName.ToString();
            }
        }

        /// <summary>
        /// Evento disparado ao alterar o associado selecionado.
        /// Carrega as atividades do associado após a terceira seleção.
        /// </summary>
        private void CbAssociado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ParmGlobal.privez < 2)
            {
                ParmGlobal.privez++;
            }
            else
            {
                ReadGeftb002();
            }
        }
    }
}

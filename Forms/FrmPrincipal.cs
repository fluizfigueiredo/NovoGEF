using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace NovoGEF.Forms
{
    /// <summary>
    /// Formulário principal do sistema, responsável pela navegação entre módulos e gerenciamento de janelas MDI.
    /// </summary>
    public partial class FrmPrincipal : Form
    {
        private Form frmAtivo;

        /// <summary>
        /// Inicializa uma nova instância do formulário principal.
        /// </summary>
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Exibe um novo formulário filho, fechando o anterior se necessário.
        /// </summary>
        /// <param name="frm">Formulário a ser exibido.</param>
        private void ShowNewForm(Form frm)
        {
            ActiveFormClose();
            frmAtivo = frm;
            frm.TopLevel = false;
            frm.MdiParent = this;
            PanelForm.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        /// <summary>
        /// Fecha o formulário filho ativo, se houver.
        /// </summary>
        private void ActiveFormClose()
        {
            frmAtivo?.Close();
        }

        /// <summary>
        /// Abre um arquivo de texto usando o diálogo padrão do Windows.
        /// </summary>
        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*"
            };
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        /// <summary>
        /// Salva um arquivo de texto usando o diálogo padrão do Windows.
        /// </summary>
        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*"
            };
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        /// <summary>
        /// Fecha o formulário principal.
        /// </summary>
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Organiza as janelas MDI em cascata.
        /// </summary>
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        /// <summary>
        /// Organiza as janelas MDI verticalmente.
        /// </summary>
        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        /// <summary>
        /// Organiza as janelas MDI horizontalmente.
        /// </summary>
        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        /// <summary>
        /// Organiza os ícones das janelas MDI.
        /// </summary>
        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        /// <summary>
        /// Fecha todos os formulários filhos abertos.
        /// </summary>
        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        /// <summary>
        /// Abre o formulário de logon.
        /// </summary>
        private void LoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowNewForm(new FrmLogon());
        }

        /// <summary>
        /// Abre o formulário de cadastro de associados, se o usuário tiver permissão.
        /// </summary>
        private void CadastroDeAssociadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ParmGlobal.nivel == 5)
            {
                ShowNewForm(new FrmAssociado());
            }
            else
            {
                MessageBox.Show(ParmGlobal.usuarioNome + " seu usuário não tem permissão para acessar esta funcionalidade.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Abre o formulário de atividades do associado, se o usuário tiver permissão.
        /// </summary>
        private void AtividadesDoAssociadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ParmGlobal.nivel == 5)
            {
                ShowNewForm(new FrmAssXAtv());
            }
            else
            {
                MessageBox.Show(ParmGlobal.usuarioNome + " seu usuário não tem permissão para acessar esta funcionalidade.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Abre o formulário de agenda, se o usuário tiver permissão.
        /// </summary>
        private void AgendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ParmGlobal.nivel == 5)
            {
                ShowNewForm(new FrmAgenda());
            }
            else
            {
                MessageBox.Show(ParmGlobal.usuarioNome + " seu usuário não tem permissão para acessar esta funcionalidade.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Abre o formulário de tabela de atividades, se o usuário tiver permissão.
        /// </summary>
        private void TabelaDeAtividadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ParmGlobal.nivel == 5)
            {
                ShowNewForm(new FrmAtividade());
            }
            else
            {
                MessageBox.Show(ParmGlobal.usuarioNome + " seu usuário não tem permissão para acessar esta funcionalidade.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Abre o formulário de tabela de usuários, se o usuário tiver permissão.
        /// </summary>
        private void TabelaUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ParmGlobal.nivel == 5)
            {
                ShowNewForm(new FrmManterUsuario());
            }else
            {
                MessageBox.Show(ParmGlobal.usuarioNome + " seu usuário não tem permissão para acessar esta funcionalidade.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Abre o formulário de tabela de autores, se o usuário tiver permissão.
        /// </summary>
        private void TabelaDeAutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ParmGlobal.nivel == 5)
            {
                ShowNewForm(new FrmLivAutor());
            }
            else
            {
                MessageBox.Show(ParmGlobal.usuarioNome + " seu usuário não tem permissão para acessar esta funcionalidade.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Abre o formulário de tabela de autores espirituais, se o usuário tiver permissão.
        /// </summary>
        private void TabelaDeAutorEspiritualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ParmGlobal.nivel == 5)
            {
                ShowNewForm(new FrmLivAutorEsp());
            }
            else
            {
                MessageBox.Show(ParmGlobal.usuarioNome + " seu usuário não tem permissão para acessar esta funcionalidade.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Abre o formulário de tabela de editoras, se o usuário tiver permissão.
        /// </summary>
        private void TabelaDeEditoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ParmGlobal.nivel == 5)
            {
                ShowNewForm(new FrmLivEditora());
            }
            else
            {
                MessageBox.Show(ParmGlobal.usuarioNome + " seu usuário não tem permissão para acessar esta funcionalidade.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Abre o formulário de livraria, se o usuário tiver permissão.
        /// </summary>
        private void LivrariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ParmGlobal.nivel == 5)
            {
                ShowNewForm(new FrmLivraria());
            }
            else
            {
                MessageBox.Show(ParmGlobal.usuarioNome + " seu usuário não tem permissão para acessar esta funcionalidade.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Fecha o formulário principal ao clicar em "Sair".
        /// </summary>
        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Evento disparado ao carregar o formulário principal.
        /// </summary>
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Evento disparado ao pintar o painel de formulários.
        /// </summary>
        private void PanelForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

namespace NovoGEF.Forms
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.associadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeAssociadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atividadesDoAssociadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manutençãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabelaDeArividadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetarSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabelaDeAutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabelaDeAutorEspiritualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabelaDeEditoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livrariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.PanelForm = new System.Windows.Forms.Panel();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.associadoToolStripMenuItem,
            this.manutençãoToolStripMenuItem,
            this.livrariaToolStripMenuItem,
            this.SairToolStripMenuItem,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(909, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("loginToolStripMenuItem.Image")));
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.LoginToolStripMenuItem_Click);
            // 
            // associadoToolStripMenuItem
            // 
            this.associadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agendaToolStripMenuItem,
            this.cadastroDeAssociadosToolStripMenuItem,
            this.atividadesDoAssociadoToolStripMenuItem});
            this.associadoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("associadoToolStripMenuItem.Image")));
            this.associadoToolStripMenuItem.Name = "associadoToolStripMenuItem";
            this.associadoToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.associadoToolStripMenuItem.Text = "&Associado";
            // 
            // agendaToolStripMenuItem
            // 
            this.agendaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("agendaToolStripMenuItem.Image")));
            this.agendaToolStripMenuItem.Name = "agendaToolStripMenuItem";
            this.agendaToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.agendaToolStripMenuItem.Text = "Agenda";
            this.agendaToolStripMenuItem.Click += new System.EventHandler(this.AgendaToolStripMenuItem_Click);
            // 
            // cadastroDeAssociadosToolStripMenuItem
            // 
            this.cadastroDeAssociadosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastroDeAssociadosToolStripMenuItem.Image")));
            this.cadastroDeAssociadosToolStripMenuItem.Name = "cadastroDeAssociadosToolStripMenuItem";
            this.cadastroDeAssociadosToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.cadastroDeAssociadosToolStripMenuItem.Text = "Cadastro de Associados";
            this.cadastroDeAssociadosToolStripMenuItem.Click += new System.EventHandler(this.CadastroDeAssociadosToolStripMenuItem_Click);
            // 
            // atividadesDoAssociadoToolStripMenuItem
            // 
            this.atividadesDoAssociadoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("atividadesDoAssociadoToolStripMenuItem.Image")));
            this.atividadesDoAssociadoToolStripMenuItem.Name = "atividadesDoAssociadoToolStripMenuItem";
            this.atividadesDoAssociadoToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.atividadesDoAssociadoToolStripMenuItem.Text = "Atividades do Associado";
            this.atividadesDoAssociadoToolStripMenuItem.Click += new System.EventHandler(this.AtividadesDoAssociadoToolStripMenuItem_Click);
            // 
            // manutençãoToolStripMenuItem
            // 
            this.manutençãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabelaDeArividadesToolStripMenuItem,
            this.resetarSenhaToolStripMenuItem,
            this.tabelaDeAutorToolStripMenuItem,
            this.tabelaDeAutorEspiritualToolStripMenuItem,
            this.tabelaDeEditoraToolStripMenuItem});
            this.manutençãoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("manutençãoToolStripMenuItem.Image")));
            this.manutençãoToolStripMenuItem.Name = "manutençãoToolStripMenuItem";
            this.manutençãoToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.manutençãoToolStripMenuItem.Text = "&Manutenção";
            // 
            // tabelaDeArividadesToolStripMenuItem
            // 
            this.tabelaDeArividadesToolStripMenuItem.Name = "tabelaDeArividadesToolStripMenuItem";
            this.tabelaDeArividadesToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.tabelaDeArividadesToolStripMenuItem.Text = "Tabela de Atividades";
            this.tabelaDeArividadesToolStripMenuItem.Click += new System.EventHandler(this.TabelaDeAtividadesToolStripMenuItem_Click);
            // 
            // resetarSenhaToolStripMenuItem
            // 
            this.resetarSenhaToolStripMenuItem.Name = "resetarSenhaToolStripMenuItem";
            this.resetarSenhaToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.resetarSenhaToolStripMenuItem.Text = "Tabela de Usuario";
            this.resetarSenhaToolStripMenuItem.Click += new System.EventHandler(this.TabelaUsuarioToolStripMenuItem_Click);
            // 
            // tabelaDeAutorToolStripMenuItem
            // 
            this.tabelaDeAutorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tabelaDeAutorToolStripMenuItem.Image")));
            this.tabelaDeAutorToolStripMenuItem.Name = "tabelaDeAutorToolStripMenuItem";
            this.tabelaDeAutorToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.tabelaDeAutorToolStripMenuItem.Text = "Tabela de Autor";
            this.tabelaDeAutorToolStripMenuItem.Visible = false;
            this.tabelaDeAutorToolStripMenuItem.Click += new System.EventHandler(this.TabelaDeAutorToolStripMenuItem_Click);
            // 
            // tabelaDeAutorEspiritualToolStripMenuItem
            // 
            this.tabelaDeAutorEspiritualToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tabelaDeAutorEspiritualToolStripMenuItem.Image")));
            this.tabelaDeAutorEspiritualToolStripMenuItem.Name = "tabelaDeAutorEspiritualToolStripMenuItem";
            this.tabelaDeAutorEspiritualToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.tabelaDeAutorEspiritualToolStripMenuItem.Text = "Tabela de Autor Espiritual";
            this.tabelaDeAutorEspiritualToolStripMenuItem.Visible = false;
            this.tabelaDeAutorEspiritualToolStripMenuItem.Click += new System.EventHandler(this.TabelaDeAutorEspiritualToolStripMenuItem_Click);
            // 
            // tabelaDeEditoraToolStripMenuItem
            // 
            this.tabelaDeEditoraToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tabelaDeEditoraToolStripMenuItem.Image")));
            this.tabelaDeEditoraToolStripMenuItem.Name = "tabelaDeEditoraToolStripMenuItem";
            this.tabelaDeEditoraToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.tabelaDeEditoraToolStripMenuItem.Text = "Tabela de Editora";
            this.tabelaDeEditoraToolStripMenuItem.Visible = false;
            this.tabelaDeEditoraToolStripMenuItem.Click += new System.EventHandler(this.TabelaDeEditoraToolStripMenuItem_Click);
            // 
            // livrariaToolStripMenuItem
            // 
            this.livrariaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("livrariaToolStripMenuItem.Image")));
            this.livrariaToolStripMenuItem.Name = "livrariaToolStripMenuItem";
            this.livrariaToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.livrariaToolStripMenuItem.Text = "&Livraria";
            this.livrariaToolStripMenuItem.Visible = false;
            this.livrariaToolStripMenuItem.Click += new System.EventHandler(this.LivrariaToolStripMenuItem_Click);
            // 
            // SairToolStripMenuItem
            // 
            this.SairToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("SairToolStripMenuItem.Image")));
            this.SairToolStripMenuItem.Name = "SairToolStripMenuItem";
            this.SairToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.SairToolStripMenuItem.Text = "Sair";
            this.SairToolStripMenuItem.Click += new System.EventHandler(this.SairToolStripMenuItem_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator8,
            this.aboutToolStripMenuItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(50, 24);
            this.helpMenu.Text = "&Ajuda";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.contentsToolStripMenuItem.Text = "&Conteúdo";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("indexToolStripMenuItem.Image")));
            this.indexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.indexToolStripMenuItem.Text = "&Índice";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("searchToolStripMenuItem.Image")));
            this.searchToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.searchToolStripMenuItem.Text = "&Procurar";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(170, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.aboutToolStripMenuItem.Text = "&Sobre ... ...";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 521);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(909, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // PanelForm
            // 
            this.PanelForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelForm.Location = new System.Drawing.Point(0, 28);
            this.PanelForm.Name = "PanelForm";
            this.PanelForm.Size = new System.Drawing.Size(909, 493);
            this.PanelForm.TabIndex = 4;
            this.PanelForm.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelForm_Paint);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 543);
            this.Controls.Add(this.PanelForm);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.Text = "Novo Sistema Integrado do GEF";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem associadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeAssociadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atividadesDoAssociadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manutençãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabelaDeArividadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetarSenhaToolStripMenuItem;
        private System.Windows.Forms.Panel PanelForm;
        private System.Windows.Forms.ToolStripMenuItem tabelaDeAutorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabelaDeAutorEspiritualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabelaDeEditoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem livrariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SairToolStripMenuItem;
    }
}




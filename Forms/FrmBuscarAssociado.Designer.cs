namespace NovoGEF.Forms
{
    partial class FrmBuscarAssociado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscarAssociado));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CbxMatricula = new System.Windows.Forms.CheckBox();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.TbSearchNome = new System.Windows.Forms.TextBox();
            this.CbxNome = new System.Windows.Forms.CheckBox();
            this.TbSearchMatricula = new System.Windows.Forms.TextBox();
            this.DgvGeftb002 = new System.Windows.Forms.DataGridView();
            this.cancelarAtualizaçãoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnConf = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGeftb002)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CbxMatricula);
            this.groupBox3.Controls.Add(this.BtnPesquisar);
            this.groupBox3.Controls.Add(this.TbSearchNome);
            this.groupBox3.Controls.Add(this.CbxNome);
            this.groupBox3.Controls.Add(this.TbSearchMatricula);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(125, 23);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(905, 98);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtro";
            // 
            // CbxMatricula
            // 
            this.CbxMatricula.AutoSize = true;
            this.CbxMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxMatricula.Location = new System.Drawing.Point(25, 27);
            this.CbxMatricula.Name = "CbxMatricula";
            this.CbxMatricula.Size = new System.Drawing.Size(89, 20);
            this.CbxMatricula.TabIndex = 1;
            this.CbxMatricula.Text = "Matricula";
            this.CbxMatricula.UseVisualStyleBackColor = true;
            this.CbxMatricula.CheckedChanged += new System.EventHandler(this.Cbx_Matricula_CheckedChanged);
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.BtnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPesquisar.ForeColor = System.Drawing.Color.White;
            this.BtnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("BtnPesquisar.Image")));
            this.BtnPesquisar.Location = new System.Drawing.Point(749, 21);
            this.BtnPesquisar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(142, 62);
            this.BtnPesquisar.TabIndex = 22;
            this.BtnPesquisar.Text = "Pesquisar";
            this.BtnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPesquisar.UseVisualStyleBackColor = false;
            this.BtnPesquisar.Click += new System.EventHandler(this.Btn_Pesquisar_Click);
            // 
            // TbSearchNome
            // 
            this.TbSearchNome.BackColor = System.Drawing.SystemColors.Window;
            this.TbSearchNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbSearchNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbSearchNome.Location = new System.Drawing.Point(165, 49);
            this.TbSearchNome.Margin = new System.Windows.Forms.Padding(2);
            this.TbSearchNome.MaxLength = 60;
            this.TbSearchNome.Name = "TbSearchNome";
            this.TbSearchNome.Size = new System.Drawing.Size(551, 22);
            this.TbSearchNome.TabIndex = 55;
            // 
            // CbxNome
            // 
            this.CbxNome.AutoSize = true;
            this.CbxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxNome.Location = new System.Drawing.Point(165, 27);
            this.CbxNome.Name = "CbxNome";
            this.CbxNome.Size = new System.Drawing.Size(67, 20);
            this.CbxNome.TabIndex = 0;
            this.CbxNome.Text = "Nome";
            this.CbxNome.UseVisualStyleBackColor = true;
            this.CbxNome.CheckedChanged += new System.EventHandler(this.Cbx_Nome_CheckedChanged);
            // 
            // TbSearchMatricula
            // 
            this.TbSearchMatricula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbSearchMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbSearchMatricula.Location = new System.Drawing.Point(24, 48);
            this.TbSearchMatricula.Margin = new System.Windows.Forms.Padding(2);
            this.TbSearchMatricula.MaxLength = 10;
            this.TbSearchMatricula.Name = "TbSearchMatricula";
            this.TbSearchMatricula.Size = new System.Drawing.Size(98, 22);
            this.TbSearchMatricula.TabIndex = 54;
            this.TbSearchMatricula.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DgvGeftb002
            // 
            this.DgvGeftb002.AllowUserToAddRows = false;
            this.DgvGeftb002.AllowUserToDeleteRows = false;
            this.DgvGeftb002.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvGeftb002.Location = new System.Drawing.Point(130, 142);
            this.DgvGeftb002.Margin = new System.Windows.Forms.Padding(2);
            this.DgvGeftb002.MultiSelect = false;
            this.DgvGeftb002.Name = "DgvGeftb002";
            this.DgvGeftb002.ReadOnly = true;
            this.DgvGeftb002.RowHeadersWidth = 51;
            this.DgvGeftb002.RowTemplate.Height = 24;
            this.DgvGeftb002.Size = new System.Drawing.Size(890, 479);
            this.DgvGeftb002.TabIndex = 16;
            // 
            // cancelarAtualizaçãoToolStripMenuItem1
            // 
            this.cancelarAtualizaçãoToolStripMenuItem1.Name = "cancelarAtualizaçãoToolStripMenuItem1";
            this.cancelarAtualizaçãoToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.panel1.Controls.Add(this.BtnSair);
            this.panel1.Controls.Add(this.BtnConf);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 640);
            this.panel1.TabIndex = 57;
            // 
            // BtnSair
            // 
            this.BtnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.BtnSair.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSair.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.BtnSair.FlatAppearance.BorderSize = 0;
            this.BtnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.BtnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.ForeColor = System.Drawing.Color.White;
            this.BtnSair.Image = ((System.Drawing.Image)(resources.GetObject("BtnSair.Image")));
            this.BtnSair.Location = new System.Drawing.Point(0, 80);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(100, 80);
            this.BtnSair.TabIndex = 8;
            this.BtnSair.Text = "Fechar";
            this.BtnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnConf
            // 
            this.BtnConf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.BtnConf.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnConf.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.BtnConf.FlatAppearance.BorderSize = 0;
            this.BtnConf.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.BtnConf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.BtnConf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConf.ForeColor = System.Drawing.Color.White;
            this.BtnConf.Image = ((System.Drawing.Image)(resources.GetObject("BtnConf.Image")));
            this.BtnConf.Location = new System.Drawing.Point(0, 0);
            this.BtnConf.Name = "BtnConf";
            this.BtnConf.Size = new System.Drawing.Size(100, 80);
            this.BtnConf.TabIndex = 6;
            this.BtnConf.Text = "Confirmar Seleção";
            this.BtnConf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnConf.UseVisualStyleBackColor = false;
            this.BtnConf.Click += new System.EventHandler(this.BtnConf_Click);
            // 
            // FrmBuscarAssociado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1055, 640);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DgvGeftb002);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmBuscarAssociado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Busca de Associado";
            this.Load += new System.EventHandler(this.FrmBuscarAssociado_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGeftb002)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView DgvGeftb002;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.TextBox TbSearchNome;
        private System.Windows.Forms.TextBox TbSearchMatricula;
        private System.Windows.Forms.CheckBox CbxMatricula;
        private System.Windows.Forms.CheckBox CbxNome;
        private System.Windows.Forms.ToolStripMenuItem cancelarAtualizaçãoToolStripMenuItem1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnConf;
    }
}


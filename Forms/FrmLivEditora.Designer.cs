namespace NovoGEF.Forms
{
    partial class FrmLivEditora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLivEditora));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.TbCodigo = new System.Windows.Forms.TextBox();
            this.TbDescricao = new System.Windows.Forms.TextBox();
            this.TbTel1 = new System.Windows.Forms.TextBox();
            this.TbTel2 = new System.Windows.Forms.TextBox();
            this.TbEmail = new System.Windows.Forms.TextBox();
            this.DgvGeftb011 = new System.Windows.Forms.DataGridView();
            this.MskCnpj = new System.Windows.Forms.MaskedTextBox();
            this.cancelarAtualizaçãoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnCan = new System.Windows.Forms.Button();
            this.BtnConf = new System.Windows.Forms.Button();
            this.BtnLimpForm = new System.Windows.Forms.Button();
            this.BtnAtuReg = new System.Windows.Forms.Button();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGeftb011)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(238, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome da Editora";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(814, 29);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "CNPJ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(133, 92);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 16);
            this.label12.TabIndex = 11;
            this.label12.Text = "Tel 1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(219, 92);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 16);
            this.label13.TabIndex = 12;
            this.label13.Text = "Tel 2";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(307, 92);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 16);
            this.label14.TabIndex = 13;
            this.label14.Text = "e-Mail";
            // 
            // TbCodigo
            // 
            this.TbCodigo.BackColor = System.Drawing.Color.Indigo;
            this.TbCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbCodigo.ForeColor = System.Drawing.Color.White;
            this.TbCodigo.Location = new System.Drawing.Point(128, 44);
            this.TbCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.TbCodigo.MaxLength = 10;
            this.TbCodigo.Name = "TbCodigo";
            this.TbCodigo.ReadOnly = true;
            this.TbCodigo.Size = new System.Drawing.Size(81, 22);
            this.TbCodigo.TabIndex = 3;
            this.TbCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TbDescricao
            // 
            this.TbDescricao.BackColor = System.Drawing.SystemColors.Window;
            this.TbDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbDescricao.Location = new System.Drawing.Point(236, 45);
            this.TbDescricao.Margin = new System.Windows.Forms.Padding(2);
            this.TbDescricao.MaxLength = 60;
            this.TbDescricao.Name = "TbDescricao";
            this.TbDescricao.Size = new System.Drawing.Size(551, 22);
            this.TbDescricao.TabIndex = 5;
            // 
            // TbTel1
            // 
            this.TbTel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbTel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbTel1.Location = new System.Drawing.Point(129, 109);
            this.TbTel1.Margin = new System.Windows.Forms.Padding(2);
            this.TbTel1.MaxLength = 9;
            this.TbTel1.Name = "TbTel1";
            this.TbTel1.Size = new System.Drawing.Size(73, 22);
            this.TbTel1.TabIndex = 8;
            this.TbTel1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TbTel2
            // 
            this.TbTel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbTel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbTel2.Location = new System.Drawing.Point(214, 110);
            this.TbTel2.Margin = new System.Windows.Forms.Padding(2);
            this.TbTel2.MaxLength = 9;
            this.TbTel2.Name = "TbTel2";
            this.TbTel2.Size = new System.Drawing.Size(74, 22);
            this.TbTel2.TabIndex = 9;
            this.TbTel2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TbEmail
            // 
            this.TbEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbEmail.Location = new System.Drawing.Point(305, 110);
            this.TbEmail.Margin = new System.Windows.Forms.Padding(2);
            this.TbEmail.MaxLength = 100;
            this.TbEmail.Name = "TbEmail";
            this.TbEmail.Size = new System.Drawing.Size(732, 22);
            this.TbEmail.TabIndex = 10;
            // 
            // DgvGeftb011
            // 
            this.DgvGeftb011.AllowUserToAddRows = false;
            this.DgvGeftb011.AllowUserToDeleteRows = false;
            this.DgvGeftb011.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvGeftb011.Location = new System.Drawing.Point(128, 160);
            this.DgvGeftb011.Margin = new System.Windows.Forms.Padding(2);
            this.DgvGeftb011.MultiSelect = false;
            this.DgvGeftb011.Name = "DgvGeftb011";
            this.DgvGeftb011.ReadOnly = true;
            this.DgvGeftb011.RowHeadersWidth = 51;
            this.DgvGeftb011.RowTemplate.Height = 24;
            this.DgvGeftb011.Size = new System.Drawing.Size(909, 479);
            this.DgvGeftb011.TabIndex = 16;
            this.DgvGeftb011.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGeftb011_CellClick);
            this.DgvGeftb011.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DgvGeftb011_KeyDown);
            this.DgvGeftb011.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DgvGeftb011_KeyPress);
            this.DgvGeftb011.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DgvGeftb011_KeyUp);
            // 
            // MskCnpj
            // 
            this.MskCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MskCnpj.Location = new System.Drawing.Point(812, 45);
            this.MskCnpj.Mask = "00.000.000/0000-00";
            this.MskCnpj.Name = "MskCnpj";
            this.MskCnpj.Size = new System.Drawing.Size(136, 22);
            this.MskCnpj.TabIndex = 51;
            this.MskCnpj.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MskCnpj.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
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
            this.panel1.Controls.Add(this.BtnCan);
            this.panel1.Controls.Add(this.BtnConf);
            this.panel1.Controls.Add(this.BtnLimpForm);
            this.panel1.Controls.Add(this.BtnAtuReg);
            this.panel1.Controls.Add(this.BtnCadastrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 663);
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
            this.BtnSair.Location = new System.Drawing.Point(0, 400);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(100, 80);
            this.BtnSair.TabIndex = 8;
            this.BtnSair.Text = "Fechar";
            this.BtnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnCan
            // 
            this.BtnCan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.BtnCan.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCan.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.BtnCan.FlatAppearance.BorderSize = 0;
            this.BtnCan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.BtnCan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.BtnCan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCan.ForeColor = System.Drawing.Color.White;
            this.BtnCan.Image = ((System.Drawing.Image)(resources.GetObject("BtnCan.Image")));
            this.BtnCan.Location = new System.Drawing.Point(0, 320);
            this.BtnCan.Name = "BtnCan";
            this.BtnCan.Size = new System.Drawing.Size(100, 80);
            this.BtnCan.TabIndex = 10;
            this.BtnCan.Text = "Cancelar";
            this.BtnCan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnCan.UseVisualStyleBackColor = false;
            this.BtnCan.Visible = false;
            this.BtnCan.Click += new System.EventHandler(this.BtnCan_Click);
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
            this.BtnConf.Location = new System.Drawing.Point(0, 240);
            this.BtnConf.Name = "BtnConf";
            this.BtnConf.Size = new System.Drawing.Size(100, 80);
            this.BtnConf.TabIndex = 9;
            this.BtnConf.Text = "Confirmar";
            this.BtnConf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnConf.UseVisualStyleBackColor = false;
            this.BtnConf.Visible = false;
            this.BtnConf.Click += new System.EventHandler(this.BtnConf_Click);
            // 
            // BtnLimpForm
            // 
            this.BtnLimpForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.BtnLimpForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnLimpForm.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.BtnLimpForm.FlatAppearance.BorderSize = 0;
            this.BtnLimpForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.BtnLimpForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.BtnLimpForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpForm.ForeColor = System.Drawing.Color.White;
            this.BtnLimpForm.Image = ((System.Drawing.Image)(resources.GetObject("BtnLimpForm.Image")));
            this.BtnLimpForm.Location = new System.Drawing.Point(0, 160);
            this.BtnLimpForm.Name = "BtnLimpForm";
            this.BtnLimpForm.Size = new System.Drawing.Size(100, 80);
            this.BtnLimpForm.TabIndex = 5;
            this.BtnLimpForm.Text = "Limpar Formulário";
            this.BtnLimpForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnLimpForm.UseVisualStyleBackColor = false;
            this.BtnLimpForm.Click += new System.EventHandler(this.BtnLimpForm_Click);
            // 
            // BtnAtuReg
            // 
            this.BtnAtuReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.BtnAtuReg.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAtuReg.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.BtnAtuReg.FlatAppearance.BorderSize = 0;
            this.BtnAtuReg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.BtnAtuReg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.BtnAtuReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAtuReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtuReg.ForeColor = System.Drawing.Color.White;
            this.BtnAtuReg.Image = ((System.Drawing.Image)(resources.GetObject("BtnAtuReg.Image")));
            this.BtnAtuReg.Location = new System.Drawing.Point(0, 80);
            this.BtnAtuReg.Name = "BtnAtuReg";
            this.BtnAtuReg.Size = new System.Drawing.Size(100, 80);
            this.BtnAtuReg.TabIndex = 4;
            this.BtnAtuReg.Text = "Alterar Registro";
            this.BtnAtuReg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnAtuReg.UseVisualStyleBackColor = false;
            this.BtnAtuReg.Click += new System.EventHandler(this.BtnAtuReg_Click);
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.BtnCadastrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.BtnCadastrar.FlatAppearance.BorderSize = 0;
            this.BtnCadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.BtnCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.BtnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastrar.ForeColor = System.Drawing.Color.White;
            this.BtnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCadastrar.Image")));
            this.BtnCadastrar.Location = new System.Drawing.Point(0, 0);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(100, 80);
            this.BtnCadastrar.TabIndex = 0;
            this.BtnCadastrar.Text = "Incluir Editora";
            this.BtnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnCadastrar.UseVisualStyleBackColor = false;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // FrmLivEditora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1062, 663);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MskCnpj);
            this.Controls.Add(this.DgvGeftb011);
            this.Controls.Add(this.TbEmail);
            this.Controls.Add(this.TbTel2);
            this.Controls.Add(this.TbTel1);
            this.Controls.Add(this.TbDescricao);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbCodigo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmLivEditora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Editoras";
            this.Load += new System.EventHandler(this.FrmLivEditora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvGeftb011)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TbCodigo;
        private System.Windows.Forms.TextBox TbDescricao;
        private System.Windows.Forms.TextBox TbTel1;
        private System.Windows.Forms.TextBox TbTel2;
        private System.Windows.Forms.TextBox TbEmail;
        private System.Windows.Forms.DataGridView DgvGeftb011;
        private System.Windows.Forms.MaskedTextBox MskCnpj;
        private System.Windows.Forms.ToolStripMenuItem cancelarAtualizaçãoToolStripMenuItem1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.Button BtnLimpForm;
        private System.Windows.Forms.Button BtnAtuReg;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnCan;
        private System.Windows.Forms.Button BtnConf;
    }
}


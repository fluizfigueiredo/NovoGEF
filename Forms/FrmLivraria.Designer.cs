namespace NovoGEF.Forms
{
    partial class FrmLivraria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLivraria));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.TbIdLivraria = new System.Windows.Forms.TextBox();
            this.TbTitulo = new System.Windows.Forms.TextBox();
            this.TbEstoque = new System.Windows.Forms.TextBox();
            this.TbAssunto = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TbSearchAssunto = new System.Windows.Forms.TextBox();
            this.CbxAssunto = new System.Windows.Forms.CheckBox();
            this.CbxCodigo = new System.Windows.Forms.CheckBox();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.TbSearchTitulo = new System.Windows.Forms.TextBox();
            this.CbxTitulo = new System.Windows.Forms.CheckBox();
            this.TbSearchCodigo = new System.Windows.Forms.TextBox();
            this.DgvGeftb012 = new System.Windows.Forms.DataGridView();
            this.cancelarAtualizaçãoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnConf = new System.Windows.Forms.Button();
            this.BtnLimpForm = new System.Windows.Forms.Button();
            this.BtnAtuReg = new System.Windows.Forms.Button();
            this.BtnCadEditora = new System.Windows.Forms.Button();
            this.BtnCadAutorEsp = new System.Windows.Forms.Button();
            this.BtnCadAutor = new System.Windows.Forms.Button();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.CbEditora = new System.Windows.Forms.ComboBox();
            this.CbAutor = new System.Windows.Forms.ComboBox();
            this.CbAutorEsp = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TbVlUnitario = new System.Windows.Forms.TextBox();
            this.TbVlLivraria = new System.Windows.Forms.TextBox();
            this.TbVlFeira = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGeftb012)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 171);
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
            this.label3.Location = new System.Drawing.Point(231, 171);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Título";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(372, 340);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Valor Livraria";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(508, 340);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Valor Feira";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(128, 338);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "Estoque";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(127, 224);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 16);
            this.label15.TabIndex = 14;
            this.label15.Text = "Assunto";
            // 
            // TbIdLivraria
            // 
            this.TbIdLivraria.BackColor = System.Drawing.Color.Indigo;
            this.TbIdLivraria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbIdLivraria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbIdLivraria.ForeColor = System.Drawing.Color.White;
            this.TbIdLivraria.Location = new System.Drawing.Point(125, 189);
            this.TbIdLivraria.Margin = new System.Windows.Forms.Padding(2);
            this.TbIdLivraria.MaxLength = 10;
            this.TbIdLivraria.Name = "TbIdLivraria";
            this.TbIdLivraria.ReadOnly = true;
            this.TbIdLivraria.Size = new System.Drawing.Size(81, 22);
            this.TbIdLivraria.TabIndex = 0;
            this.TbIdLivraria.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TbTitulo
            // 
            this.TbTitulo.BackColor = System.Drawing.SystemColors.Window;
            this.TbTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbTitulo.Location = new System.Drawing.Point(229, 190);
            this.TbTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.TbTitulo.MaxLength = 60;
            this.TbTitulo.Name = "TbTitulo";
            this.TbTitulo.Size = new System.Drawing.Size(551, 22);
            this.TbTitulo.TabIndex = 1;
            // 
            // TbEstoque
            // 
            this.TbEstoque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbEstoque.Location = new System.Drawing.Point(125, 356);
            this.TbEstoque.Margin = new System.Windows.Forms.Padding(2);
            this.TbEstoque.MaxLength = 4;
            this.TbEstoque.Name = "TbEstoque";
            this.TbEstoque.Size = new System.Drawing.Size(67, 22);
            this.TbEstoque.TabIndex = 6;
            this.TbEstoque.Text = "0";
            this.TbEstoque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TbAssunto
            // 
            this.TbAssunto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbAssunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbAssunto.Location = new System.Drawing.Point(125, 241);
            this.TbAssunto.Margin = new System.Windows.Forms.Padding(2);
            this.TbAssunto.MaxLength = 100;
            this.TbAssunto.Name = "TbAssunto";
            this.TbAssunto.Size = new System.Drawing.Size(747, 22);
            this.TbAssunto.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TbSearchAssunto);
            this.groupBox3.Controls.Add(this.CbxAssunto);
            this.groupBox3.Controls.Add(this.CbxCodigo);
            this.groupBox3.Controls.Add(this.BtnPesquisar);
            this.groupBox3.Controls.Add(this.TbSearchTitulo);
            this.groupBox3.Controls.Add(this.CbxTitulo);
            this.groupBox3.Controls.Add(this.TbSearchCodigo);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(216, 23);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(905, 128);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtro";
            // 
            // TbSearchAssunto
            // 
            this.TbSearchAssunto.BackColor = System.Drawing.SystemColors.Window;
            this.TbSearchAssunto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbSearchAssunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbSearchAssunto.Location = new System.Drawing.Point(126, 87);
            this.TbSearchAssunto.Margin = new System.Windows.Forms.Padding(2);
            this.TbSearchAssunto.MaxLength = 100;
            this.TbSearchAssunto.Name = "TbSearchAssunto";
            this.TbSearchAssunto.Size = new System.Drawing.Size(551, 22);
            this.TbSearchAssunto.TabIndex = 57;
            // 
            // CbxAssunto
            // 
            this.CbxAssunto.AutoSize = true;
            this.CbxAssunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxAssunto.Location = new System.Drawing.Point(25, 87);
            this.CbxAssunto.Name = "CbxAssunto";
            this.CbxAssunto.Size = new System.Drawing.Size(81, 20);
            this.CbxAssunto.TabIndex = 56;
            this.CbxAssunto.Text = "Assunto";
            this.CbxAssunto.UseVisualStyleBackColor = true;
            this.CbxAssunto.CheckedChanged += new System.EventHandler(this.CbxAssunto_CheckedChanged);
            // 
            // CbxCodigo
            // 
            this.CbxCodigo.AutoSize = true;
            this.CbxCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxCodigo.Location = new System.Drawing.Point(25, 24);
            this.CbxCodigo.Name = "CbxCodigo";
            this.CbxCodigo.Size = new System.Drawing.Size(76, 20);
            this.CbxCodigo.TabIndex = 1;
            this.CbxCodigo.Text = "Código";
            this.CbxCodigo.UseVisualStyleBackColor = true;
            this.CbxCodigo.CheckedChanged += new System.EventHandler(this.CbxCodigo_CheckedChanged);
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.BtnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPesquisar.ForeColor = System.Drawing.Color.White;
            this.BtnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("BtnPesquisar.Image")));
            this.BtnPesquisar.Location = new System.Drawing.Point(749, 15);
            this.BtnPesquisar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(142, 62);
            this.BtnPesquisar.TabIndex = 22;
            this.BtnPesquisar.Text = "Pesquisar";
            this.BtnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPesquisar.UseVisualStyleBackColor = false;
            this.BtnPesquisar.Click += new System.EventHandler(this.Btn_Pesquisar_Click);
            // 
            // TbSearchTitulo
            // 
            this.TbSearchTitulo.BackColor = System.Drawing.SystemColors.Window;
            this.TbSearchTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbSearchTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbSearchTitulo.Location = new System.Drawing.Point(126, 55);
            this.TbSearchTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.TbSearchTitulo.MaxLength = 100;
            this.TbSearchTitulo.Name = "TbSearchTitulo";
            this.TbSearchTitulo.Size = new System.Drawing.Size(551, 22);
            this.TbSearchTitulo.TabIndex = 55;
            // 
            // CbxTitulo
            // 
            this.CbxTitulo.AutoSize = true;
            this.CbxTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxTitulo.Location = new System.Drawing.Point(25, 55);
            this.CbxTitulo.Name = "CbxTitulo";
            this.CbxTitulo.Size = new System.Drawing.Size(65, 20);
            this.CbxTitulo.TabIndex = 0;
            this.CbxTitulo.Text = "Título";
            this.CbxTitulo.UseVisualStyleBackColor = true;
            this.CbxTitulo.CheckedChanged += new System.EventHandler(this.CbxTitulo_CheckedChanged);
            // 
            // TbSearchCodigo
            // 
            this.TbSearchCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbSearchCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbSearchCodigo.Location = new System.Drawing.Point(126, 22);
            this.TbSearchCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.TbSearchCodigo.MaxLength = 10;
            this.TbSearchCodigo.Name = "TbSearchCodigo";
            this.TbSearchCodigo.Size = new System.Drawing.Size(98, 22);
            this.TbSearchCodigo.TabIndex = 54;
            this.TbSearchCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DgvGeftb012
            // 
            this.DgvGeftb012.AllowUserToAddRows = false;
            this.DgvGeftb012.AllowUserToDeleteRows = false;
            this.DgvGeftb012.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvGeftb012.Location = new System.Drawing.Point(125, 400);
            this.DgvGeftb012.Margin = new System.Windows.Forms.Padding(2);
            this.DgvGeftb012.MultiSelect = false;
            this.DgvGeftb012.Name = "DgvGeftb012";
            this.DgvGeftb012.ReadOnly = true;
            this.DgvGeftb012.RowHeadersWidth = 51;
            this.DgvGeftb012.RowTemplate.Height = 24;
            this.DgvGeftb012.Size = new System.Drawing.Size(1079, 431);
            this.DgvGeftb012.TabIndex = 16;
            this.DgvGeftb012.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGeftb002_CellClick);
            this.DgvGeftb012.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DgvGeftb002_KeyDown);
            this.DgvGeftb012.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DgvGeftb002_KeyPress);
            this.DgvGeftb012.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DgvGeftb002_KeyUp);
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
            this.panel1.Controls.Add(this.BtnRefresh);
            this.panel1.Controls.Add(this.BtnCancel);
            this.panel1.Controls.Add(this.BtnConf);
            this.panel1.Controls.Add(this.BtnLimpForm);
            this.panel1.Controls.Add(this.BtnAtuReg);
            this.panel1.Controls.Add(this.BtnCadEditora);
            this.panel1.Controls.Add(this.BtnCadAutorEsp);
            this.panel1.Controls.Add(this.BtnCadAutor);
            this.panel1.Controls.Add(this.BtnCadastrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 858);
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
            this.BtnSair.Location = new System.Drawing.Point(0, 720);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(100, 80);
            this.BtnSair.TabIndex = 8;
            this.BtnSair.Text = "Fechar";
            this.BtnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.BtnRefresh.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.BtnRefresh.FlatAppearance.BorderSize = 0;
            this.BtnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.BtnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRefresh.ForeColor = System.Drawing.Color.White;
            this.BtnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("BtnRefresh.Image")));
            this.BtnRefresh.Location = new System.Drawing.Point(0, 640);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(100, 80);
            this.BtnRefresh.TabIndex = 11;
            this.BtnRefresh.Text = "Atualizar Formulário";
            this.BtnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnRefresh.UseVisualStyleBackColor = false;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.BtnCancel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.BtnCancel.FlatAppearance.BorderSize = 0;
            this.BtnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.BtnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancel.Image")));
            this.BtnCancel.Location = new System.Drawing.Point(0, 560);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(100, 80);
            this.BtnCancel.TabIndex = 7;
            this.BtnCancel.Text = "Cancelar Inclusão";
            this.BtnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Visible = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
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
            this.BtnConf.Location = new System.Drawing.Point(0, 480);
            this.BtnConf.Name = "BtnConf";
            this.BtnConf.Size = new System.Drawing.Size(100, 80);
            this.BtnConf.TabIndex = 6;
            this.BtnConf.Text = "Confirmar Inclusão";
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
            this.BtnLimpForm.Location = new System.Drawing.Point(0, 400);
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
            this.BtnAtuReg.Location = new System.Drawing.Point(0, 320);
            this.BtnAtuReg.Name = "BtnAtuReg";
            this.BtnAtuReg.Size = new System.Drawing.Size(100, 80);
            this.BtnAtuReg.TabIndex = 4;
            this.BtnAtuReg.Text = "Alterar Registro";
            this.BtnAtuReg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnAtuReg.UseVisualStyleBackColor = false;
            this.BtnAtuReg.Click += new System.EventHandler(this.BtnAtuReg_Click);
            // 
            // BtnCadEditora
            // 
            this.BtnCadEditora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.BtnCadEditora.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCadEditora.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.BtnCadEditora.FlatAppearance.BorderSize = 0;
            this.BtnCadEditora.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.BtnCadEditora.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.BtnCadEditora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadEditora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadEditora.ForeColor = System.Drawing.Color.White;
            this.BtnCadEditora.Image = ((System.Drawing.Image)(resources.GetObject("BtnCadEditora.Image")));
            this.BtnCadEditora.Location = new System.Drawing.Point(0, 240);
            this.BtnCadEditora.Name = "BtnCadEditora";
            this.BtnCadEditora.Size = new System.Drawing.Size(100, 80);
            this.BtnCadEditora.TabIndex = 10;
            this.BtnCadEditora.Text = "Editora";
            this.BtnCadEditora.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnCadEditora.UseVisualStyleBackColor = false;
            this.BtnCadEditora.Click += new System.EventHandler(this.BtnCadEditora_Click);
            // 
            // BtnCadAutorEsp
            // 
            this.BtnCadAutorEsp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.BtnCadAutorEsp.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCadAutorEsp.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.BtnCadAutorEsp.FlatAppearance.BorderSize = 0;
            this.BtnCadAutorEsp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.BtnCadAutorEsp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.BtnCadAutorEsp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadAutorEsp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadAutorEsp.ForeColor = System.Drawing.Color.White;
            this.BtnCadAutorEsp.Image = ((System.Drawing.Image)(resources.GetObject("BtnCadAutorEsp.Image")));
            this.BtnCadAutorEsp.Location = new System.Drawing.Point(0, 160);
            this.BtnCadAutorEsp.Name = "BtnCadAutorEsp";
            this.BtnCadAutorEsp.Size = new System.Drawing.Size(100, 80);
            this.BtnCadAutorEsp.TabIndex = 9;
            this.BtnCadAutorEsp.Text = "Autor(a) Espiritual";
            this.BtnCadAutorEsp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnCadAutorEsp.UseVisualStyleBackColor = false;
            this.BtnCadAutorEsp.Click += new System.EventHandler(this.BtnCadAutorEsp_Click);
            // 
            // BtnCadAutor
            // 
            this.BtnCadAutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.BtnCadAutor.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCadAutor.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.BtnCadAutor.FlatAppearance.BorderSize = 0;
            this.BtnCadAutor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.BtnCadAutor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.BtnCadAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadAutor.ForeColor = System.Drawing.Color.White;
            this.BtnCadAutor.Image = ((System.Drawing.Image)(resources.GetObject("BtnCadAutor.Image")));
            this.BtnCadAutor.Location = new System.Drawing.Point(0, 80);
            this.BtnCadAutor.Name = "BtnCadAutor";
            this.BtnCadAutor.Size = new System.Drawing.Size(100, 80);
            this.BtnCadAutor.TabIndex = 3;
            this.BtnCadAutor.Text = "Autor(a)";
            this.BtnCadAutor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnCadAutor.UseVisualStyleBackColor = false;
            this.BtnCadAutor.Click += new System.EventHandler(this.BtnCadAutor_Click);
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
            this.BtnCadastrar.Text = "Incluir Livro";
            this.BtnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnCadastrar.UseVisualStyleBackColor = false;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadAss_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(235, 339);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(102, 16);
            this.label17.TabIndex = 65;
            this.label17.Text = "Valor Unitário";
            // 
            // CbEditora
            // 
            this.CbEditora.FormattingEnabled = true;
            this.CbEditora.ItemHeight = 16;
            this.CbEditora.Location = new System.Drawing.Point(709, 296);
            this.CbEditora.Name = "CbEditora";
            this.CbEditora.Size = new System.Drawing.Size(210, 24);
            this.CbEditora.TabIndex = 69;
            // 
            // CbAutor
            // 
            this.CbAutor.FormattingEnabled = true;
            this.CbAutor.ItemHeight = 16;
            this.CbAutor.Location = new System.Drawing.Point(125, 296);
            this.CbAutor.Name = "CbAutor";
            this.CbAutor.Size = new System.Drawing.Size(271, 24);
            this.CbAutor.TabIndex = 70;
            // 
            // CbAutorEsp
            // 
            this.CbAutorEsp.FormattingEnabled = true;
            this.CbAutorEsp.ItemHeight = 16;
            this.CbAutorEsp.Location = new System.Drawing.Point(443, 296);
            this.CbAutorEsp.Name = "CbAutorEsp";
            this.CbAutorEsp.Size = new System.Drawing.Size(217, 24);
            this.CbAutorEsp.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 277);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 75;
            this.label2.Text = "Autor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(440, 277);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 76;
            this.label4.Text = "Autor Espiritual";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(706, 277);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 77;
            this.label5.Text = "Editora";
            // 
            // TbVlUnitario
            // 
            this.TbVlUnitario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbVlUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbVlUnitario.Location = new System.Drawing.Point(238, 356);
            this.TbVlUnitario.Margin = new System.Windows.Forms.Padding(2);
            this.TbVlUnitario.MaxLength = 4;
            this.TbVlUnitario.Name = "TbVlUnitario";
            this.TbVlUnitario.Size = new System.Drawing.Size(57, 22);
            this.TbVlUnitario.TabIndex = 78;
            this.TbVlUnitario.Text = "0,00";
            this.TbVlUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TbVlUnitario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbVlUnitario_KeyPress);
            // 
            // TbVlLivraria
            // 
            this.TbVlLivraria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbVlLivraria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbVlLivraria.Location = new System.Drawing.Point(375, 358);
            this.TbVlLivraria.Margin = new System.Windows.Forms.Padding(2);
            this.TbVlLivraria.MaxLength = 4;
            this.TbVlLivraria.Name = "TbVlLivraria";
            this.TbVlLivraria.Size = new System.Drawing.Size(58, 22);
            this.TbVlLivraria.TabIndex = 79;
            this.TbVlLivraria.Text = "0.00";
            this.TbVlLivraria.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TbVlLivraria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbVlLivraria_KeyPress);
            // 
            // TbVlFeira
            // 
            this.TbVlFeira.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbVlFeira.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbVlFeira.Location = new System.Drawing.Point(511, 358);
            this.TbVlFeira.Margin = new System.Windows.Forms.Padding(2);
            this.TbVlFeira.MaxLength = 4;
            this.TbVlFeira.Name = "TbVlFeira";
            this.TbVlFeira.Size = new System.Drawing.Size(58, 22);
            this.TbVlFeira.TabIndex = 80;
            this.TbVlFeira.Text = "0.00";
            this.TbVlFeira.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TbVlFeira.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbVlFeira_KeyPress);
            // 
            // FrmLivraria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1239, 858);
            this.Controls.Add(this.TbVlFeira);
            this.Controls.Add(this.TbVlLivraria);
            this.Controls.Add(this.TbVlUnitario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CbAutorEsp);
            this.Controls.Add(this.CbAutor);
            this.Controls.Add(this.CbEditora);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DgvGeftb012);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.TbAssunto);
            this.Controls.Add(this.TbEstoque);
            this.Controls.Add(this.TbTitulo);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbIdLivraria);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmLivraria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Livros";
            this.Load += new System.EventHandler(this.FrmLivraria_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGeftb012)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TbIdLivraria;
        private System.Windows.Forms.TextBox TbTitulo;
        private System.Windows.Forms.TextBox TbEstoque;
        private System.Windows.Forms.TextBox TbAssunto;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView DgvGeftb012;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.TextBox TbSearchTitulo;
        private System.Windows.Forms.TextBox TbSearchCodigo;
        private System.Windows.Forms.CheckBox CbxCodigo;
        private System.Windows.Forms.CheckBox CbxTitulo;
        private System.Windows.Forms.ToolStripMenuItem cancelarAtualizaçãoToolStripMenuItem1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.Button BtnLimpForm;
        private System.Windows.Forms.Button BtnAtuReg;
        private System.Windows.Forms.Button BtnCadAutor;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnConf;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox CbEditora;
        private System.Windows.Forms.ComboBox CbAutor;
        private System.Windows.Forms.ComboBox CbAutorEsp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TbSearchAssunto;
        private System.Windows.Forms.CheckBox CbxAssunto;
        private System.Windows.Forms.TextBox TbVlUnitario;
        private System.Windows.Forms.TextBox TbVlLivraria;
        private System.Windows.Forms.TextBox TbVlFeira;
        private System.Windows.Forms.Button BtnCadEditora;
        private System.Windows.Forms.Button BtnCadAutorEsp;
        private System.Windows.Forms.Button BtnRefresh;
    }
}


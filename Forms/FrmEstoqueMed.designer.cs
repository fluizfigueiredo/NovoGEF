namespace NovoGEF.Forms
{
    partial class FrmEstoqueMed
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstoqueMed));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.TbIdEstoqueMed = new System.Windows.Forms.TextBox();
            this.TbNomeCom = new System.Windows.Forms.TextBox();
            this.TbNomeQui = new System.Windows.Forms.TextBox();
            this.DtpValidade = new System.Windows.Forms.DateTimePicker();
            this.DgvGeftb008 = new System.Windows.Forms.DataGridView();
            this.cbGrFarmaco = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnConf = new System.Windows.Forms.Button();
            this.BtnLimpForm = new System.Windows.Forms.Button();
            this.BtnAtuReg = new System.Windows.Forms.Button();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.TbPrateleira = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TbEstoque = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TbLote = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGeftb008)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 28);
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
            this.label3.Location = new System.Drawing.Point(246, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome Comercial";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(227, 80);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Data de Validade";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(609, 28);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Nome Químico";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(575, 81);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(114, 16);
            this.label14.TabIndex = 13;
            this.label14.Text = "Grupo Farmaco";
            // 
            // TbIdEstoqueMed
            // 
            this.TbIdEstoqueMed.BackColor = System.Drawing.Color.Indigo;
            this.TbIdEstoqueMed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbIdEstoqueMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbIdEstoqueMed.ForeColor = System.Drawing.Color.White;
            this.TbIdEstoqueMed.Location = new System.Drawing.Point(135, 46);
            this.TbIdEstoqueMed.Margin = new System.Windows.Forms.Padding(2);
            this.TbIdEstoqueMed.MaxLength = 10;
            this.TbIdEstoqueMed.Name = "TbIdEstoqueMed";
            this.TbIdEstoqueMed.ReadOnly = true;
            this.TbIdEstoqueMed.Size = new System.Drawing.Size(82, 22);
            this.TbIdEstoqueMed.TabIndex = 3;
            this.TbIdEstoqueMed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TbNomeCom
            // 
            this.TbNomeCom.BackColor = System.Drawing.SystemColors.Window;
            this.TbNomeCom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbNomeCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbNomeCom.Location = new System.Drawing.Point(244, 46);
            this.TbNomeCom.Margin = new System.Windows.Forms.Padding(2);
            this.TbNomeCom.MaxLength = 30;
            this.TbNomeCom.Name = "TbNomeCom";
            this.TbNomeCom.Size = new System.Drawing.Size(332, 22);
            this.TbNomeCom.TabIndex = 0;
            // 
            // TbNomeQui
            // 
            this.TbNomeQui.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbNomeQui.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbNomeQui.Location = new System.Drawing.Point(605, 46);
            this.TbNomeQui.Margin = new System.Windows.Forms.Padding(2);
            this.TbNomeQui.MaxLength = 30;
            this.TbNomeQui.Name = "TbNomeQui";
            this.TbNomeQui.Size = new System.Drawing.Size(332, 22);
            this.TbNomeQui.TabIndex = 1;
            // 
            // DtpValidade
            // 
            this.DtpValidade.CalendarTitleBackColor = System.Drawing.Color.Indigo;
            this.DtpValidade.CustomFormat = "";
            this.DtpValidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpValidade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpValidade.Location = new System.Drawing.Point(225, 97);
            this.DtpValidade.Margin = new System.Windows.Forms.Padding(2);
            this.DtpValidade.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DtpValidade.Name = "DtpValidade";
            this.DtpValidade.Size = new System.Drawing.Size(92, 22);
            this.DtpValidade.TabIndex = 3;
            this.DtpValidade.Value = new System.DateTime(2023, 10, 6, 0, 0, 0, 0);
            // 
            // DgvGeftb008
            // 
            this.DgvGeftb008.AllowUserToAddRows = false;
            this.DgvGeftb008.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvGeftb008.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvGeftb008.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvGeftb008.Location = new System.Drawing.Point(126, 143);
            this.DgvGeftb008.Margin = new System.Windows.Forms.Padding(2);
            this.DgvGeftb008.MultiSelect = false;
            this.DgvGeftb008.Name = "DgvGeftb008";
            this.DgvGeftb008.ReadOnly = true;
            this.DgvGeftb008.RowHeadersWidth = 51;
            this.DgvGeftb008.RowTemplate.Height = 24;
            this.DgvGeftb008.Size = new System.Drawing.Size(870, 560);
            this.DgvGeftb008.TabIndex = 16;
            this.DgvGeftb008.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGeftb008_CellClick);
            this.DgvGeftb008.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DgvGeftb008_KeyDown);
            this.DgvGeftb008.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DgvGeftb008_KeyPress);
            this.DgvGeftb008.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DgvGeftb008_KeyUp);
            // 
            // cbGrFarmaco
            // 
            this.cbGrFarmaco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGrFarmaco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGrFarmaco.FormattingEnabled = true;
            this.cbGrFarmaco.Location = new System.Drawing.Point(571, 97);
            this.cbGrFarmaco.Name = "cbGrFarmaco";
            this.cbGrFarmaco.Size = new System.Drawing.Size(257, 24);
            this.cbGrFarmaco.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.panel1.Controls.Add(this.BtnSair);
            this.panel1.Controls.Add(this.BtnCancel);
            this.panel1.Controls.Add(this.BtnConf);
            this.panel1.Controls.Add(this.BtnLimpForm);
            this.panel1.Controls.Add(this.BtnAtuReg);
            this.panel1.Controls.Add(this.BtnCadastrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 727);
            this.panel1.TabIndex = 66;
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
            this.BtnSair.TabIndex = 73;
            this.BtnSair.Text = "Fechar";
            this.BtnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click_1);
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
            this.BtnCancel.Location = new System.Drawing.Point(0, 320);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(100, 80);
            this.BtnCancel.TabIndex = 72;
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
            this.BtnConf.Location = new System.Drawing.Point(0, 240);
            this.BtnConf.Name = "BtnConf";
            this.BtnConf.Size = new System.Drawing.Size(100, 80);
            this.BtnConf.TabIndex = 71;
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
            this.BtnLimpForm.Location = new System.Drawing.Point(0, 160);
            this.BtnLimpForm.Name = "BtnLimpForm";
            this.BtnLimpForm.Size = new System.Drawing.Size(100, 80);
            this.BtnLimpForm.TabIndex = 70;
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
            this.BtnAtuReg.TabIndex = 69;
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
            this.BtnCadastrar.TabIndex = 68;
            this.BtnCadastrar.Text = "Incluir Medicamento";
            this.BtnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnCadastrar.UseVisualStyleBackColor = false;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // TbPrateleira
            // 
            this.TbPrateleira.BackColor = System.Drawing.SystemColors.Window;
            this.TbPrateleira.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbPrateleira.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbPrateleira.Location = new System.Drawing.Point(379, 99);
            this.TbPrateleira.Margin = new System.Windows.Forms.Padding(2);
            this.TbPrateleira.MaxLength = 10;
            this.TbPrateleira.Name = "TbPrateleira";
            this.TbPrateleira.Size = new System.Drawing.Size(77, 22);
            this.TbPrateleira.TabIndex = 4;
            this.TbPrateleira.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(381, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 67;
            this.label2.Text = "Prateleira";
            // 
            // TbEstoque
            // 
            this.TbEstoque.BackColor = System.Drawing.SystemColors.Window;
            this.TbEstoque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbEstoque.Location = new System.Drawing.Point(478, 99);
            this.TbEstoque.Margin = new System.Windows.Forms.Padding(2);
            this.TbEstoque.MaxLength = 10;
            this.TbEstoque.Name = "TbEstoque";
            this.TbEstoque.Size = new System.Drawing.Size(68, 22);
            this.TbEstoque.TabIndex = 5;
            this.TbEstoque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(482, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 69;
            this.label4.Text = "Estoque";
            // 
            // TbLote
            // 
            this.TbLote.BackColor = System.Drawing.SystemColors.Window;
            this.TbLote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbLote.Location = new System.Drawing.Point(133, 100);
            this.TbLote.Margin = new System.Windows.Forms.Padding(2);
            this.TbLote.MaxLength = 10;
            this.TbLote.Name = "TbLote";
            this.TbLote.Size = new System.Drawing.Size(68, 22);
            this.TbLote.TabIndex = 2;
            this.TbLote.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(137, 81);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 71;
            this.label5.Text = "Lote";
            // 
            // FrmEstoqueMed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1020, 727);
            this.Controls.Add(this.TbLote);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TbEstoque);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TbPrateleira);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbGrFarmaco);
            this.Controls.Add(this.DgvGeftb008);
            this.Controls.Add(this.DtpValidade);
            this.Controls.Add(this.TbNomeQui);
            this.Controls.Add(this.TbNomeCom);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbIdEstoqueMed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmEstoqueMed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Controle de Estoque dos Medicamentos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvGeftb008)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TbIdEstoqueMed;
        private System.Windows.Forms.TextBox TbNomeCom;
        private System.Windows.Forms.TextBox TbNomeQui;
        private System.Windows.Forms.DateTimePicker DtpValidade;
        private System.Windows.Forms.DataGridView DgvGeftb008;
        private System.Windows.Forms.ComboBox cbGrFarmaco;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnConf;
        private System.Windows.Forms.Button BtnLimpForm;
        private System.Windows.Forms.Button BtnAtuReg;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.TextBox TbPrateleira;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbEstoque;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbLote;
        private System.Windows.Forms.Label label5;
    }
}


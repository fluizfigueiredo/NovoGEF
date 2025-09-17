namespace NovoGEF.Forms
{
    partial class FrmAgenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgenda));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TbNome = new System.Windows.Forms.TextBox();
            this.TbJustificativa = new System.Windows.Forms.TextBox();
            this.DtpAtividade = new System.Windows.Forms.DateTimePicker();
            this.cancelarAtualizaçãoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnImprime = new System.Windows.Forms.Button();
            this.BtnImpRecBolsa = new System.Windows.Forms.Button();
            this.BtnAltReg = new System.Windows.Forms.Button();
            this.RbPresenca = new System.Windows.Forms.RadioButton();
            this.RbFalta = new System.Windows.Forms.RadioButton();
            this.CbxVestuario = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TbHrEnt = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.DgvGeftb005 = new System.Windows.Forms.DataGridView();
            this.TbIdAssociado = new System.Windows.Forms.TextBox();
            this.TbSigla = new System.Windows.Forms.TextBox();
            this.TbMatricula = new System.Windows.Forms.MaskedTextBox();
            this.TbIdAgenda = new System.Windows.Forms.TextBox();
            this.DgvGeftb003 = new System.Windows.Forms.DataGridView();
            this.DgvGeftb0051 = new System.Windows.Forms.DataGridView();
            this.DgvGeftb004 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGeftb005)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGeftb003)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGeftb0051)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGeftb004)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 648);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricula";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(129, 27);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Data da Atividade";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(123, 36);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Justificativa";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(417, 648);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Nome";
            // 
            // TbNome
            // 
            this.TbNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.TbNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbNome.ForeColor = System.Drawing.Color.White;
            this.TbNome.Location = new System.Drawing.Point(413, 667);
            this.TbNome.Margin = new System.Windows.Forms.Padding(2);
            this.TbNome.MaxLength = 60;
            this.TbNome.Name = "TbNome";
            this.TbNome.ReadOnly = true;
            this.TbNome.Size = new System.Drawing.Size(551, 22);
            this.TbNome.TabIndex = 5;
            // 
            // TbJustificativa
            // 
            this.TbJustificativa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbJustificativa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbJustificativa.Location = new System.Drawing.Point(121, 55);
            this.TbJustificativa.Margin = new System.Windows.Forms.Padding(2);
            this.TbJustificativa.MaxLength = 60;
            this.TbJustificativa.Name = "TbJustificativa";
            this.TbJustificativa.Size = new System.Drawing.Size(435, 22);
            this.TbJustificativa.TabIndex = 11;
            // 
            // DtpAtividade
            // 
            this.DtpAtividade.CalendarTitleBackColor = System.Drawing.Color.Indigo;
            this.DtpAtividade.CustomFormat = "";
            this.DtpAtividade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpAtividade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpAtividade.Location = new System.Drawing.Point(131, 44);
            this.DtpAtividade.Margin = new System.Windows.Forms.Padding(2);
            this.DtpAtividade.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DtpAtividade.Name = "DtpAtividade";
            this.DtpAtividade.Size = new System.Drawing.Size(107, 26);
            this.DtpAtividade.TabIndex = 1;
            this.DtpAtividade.Value = new System.DateTime(2023, 10, 6, 0, 0, 0, 0);
            this.DtpAtividade.ValueChanged += new System.EventHandler(this.DtpAtividade_ValueChanged);
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
            this.panel1.Controls.Add(this.BtnImprime);
            this.panel1.Controls.Add(this.BtnImpRecBolsa);
            this.panel1.Controls.Add(this.BtnAltReg);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 826);
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
            this.BtnSair.Location = new System.Drawing.Point(0, 192);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(100, 64);
            this.BtnSair.TabIndex = 8;
            this.BtnSair.Text = "Fechar";
            this.BtnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnImprime
            // 
            this.BtnImprime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.BtnImprime.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnImprime.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.BtnImprime.FlatAppearance.BorderSize = 0;
            this.BtnImprime.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.BtnImprime.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.BtnImprime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImprime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImprime.ForeColor = System.Drawing.Color.White;
            this.BtnImprime.Image = ((System.Drawing.Image)(resources.GetObject("BtnImprime.Image")));
            this.BtnImprime.Location = new System.Drawing.Point(0, 128);
            this.BtnImprime.Name = "BtnImprime";
            this.BtnImprime.Size = new System.Drawing.Size(100, 64);
            this.BtnImprime.TabIndex = 10;
            this.BtnImprime.Text = "Imprime Presença Atividaddes";
            this.BtnImprime.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnImprime.UseVisualStyleBackColor = false;
            this.BtnImprime.Click += new System.EventHandler(this.BtnImprime_Click);
            // 
            // BtnImpRecBolsa
            // 
            this.BtnImpRecBolsa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.BtnImpRecBolsa.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnImpRecBolsa.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.BtnImpRecBolsa.FlatAppearance.BorderSize = 0;
            this.BtnImpRecBolsa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.BtnImpRecBolsa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.BtnImpRecBolsa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImpRecBolsa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImpRecBolsa.ForeColor = System.Drawing.Color.White;
            this.BtnImpRecBolsa.Image = ((System.Drawing.Image)(resources.GetObject("BtnImpRecBolsa.Image")));
            this.BtnImpRecBolsa.Location = new System.Drawing.Point(0, 64);
            this.BtnImpRecBolsa.Name = "BtnImpRecBolsa";
            this.BtnImpRecBolsa.Size = new System.Drawing.Size(100, 64);
            this.BtnImpRecBolsa.TabIndex = 9;
            this.BtnImpRecBolsa.Text = "Imprime Rec Bolsa";
            this.BtnImpRecBolsa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnImpRecBolsa.UseVisualStyleBackColor = false;
            this.BtnImpRecBolsa.Click += new System.EventHandler(this.BtnImpRecBolsa_Click);
            // 
            // BtnAltReg
            // 
            this.BtnAltReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.BtnAltReg.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAltReg.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.BtnAltReg.FlatAppearance.BorderSize = 0;
            this.BtnAltReg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.BtnAltReg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.BtnAltReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAltReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAltReg.ForeColor = System.Drawing.Color.White;
            this.BtnAltReg.Image = ((System.Drawing.Image)(resources.GetObject("BtnAltReg.Image")));
            this.BtnAltReg.Location = new System.Drawing.Point(0, 0);
            this.BtnAltReg.Name = "BtnAltReg";
            this.BtnAltReg.Size = new System.Drawing.Size(100, 64);
            this.BtnAltReg.TabIndex = 4;
            this.BtnAltReg.Text = "Alterar Registro";
            this.BtnAltReg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnAltReg.UseVisualStyleBackColor = false;
            this.BtnAltReg.Click += new System.EventHandler(this.BtnAtuReg_Click);
            // 
            // RbPresenca
            // 
            this.RbPresenca.AutoSize = true;
            this.RbPresenca.Checked = true;
            this.RbPresenca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbPresenca.Location = new System.Drawing.Point(9, 17);
            this.RbPresenca.Name = "RbPresenca";
            this.RbPresenca.Size = new System.Drawing.Size(91, 20);
            this.RbPresenca.TabIndex = 60;
            this.RbPresenca.TabStop = true;
            this.RbPresenca.Text = "Presença";
            this.RbPresenca.UseVisualStyleBackColor = true;
            // 
            // RbFalta
            // 
            this.RbFalta.AutoSize = true;
            this.RbFalta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbFalta.Location = new System.Drawing.Point(121, 17);
            this.RbFalta.Name = "RbFalta";
            this.RbFalta.Size = new System.Drawing.Size(60, 20);
            this.RbFalta.TabIndex = 61;
            this.RbFalta.Text = "Falta";
            this.RbFalta.UseVisualStyleBackColor = true;
            this.RbFalta.CheckedChanged += new System.EventHandler(this.RbFalta_CheckedChanged);
            // 
            // CbxVestuario
            // 
            this.CbxVestuario.AutoSize = true;
            this.CbxVestuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxVestuario.Location = new System.Drawing.Point(14, 19);
            this.CbxVestuario.Name = "CbxVestuario";
            this.CbxVestuario.Size = new System.Drawing.Size(92, 20);
            this.CbxVestuario.TabIndex = 65;
            this.CbxVestuario.Text = "Vestuário";
            this.CbxVestuario.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CbxVestuario);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(579, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(127, 49);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Necessidades";
            this.groupBox1.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.TbHrEnt);
            this.groupBox2.Controls.Add(this.RbFalta);
            this.groupBox2.Controls.Add(this.RbPresenca);
            this.groupBox2.Controls.Add(this.TbJustificativa);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(228, 704);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(737, 89);
            this.groupBox2.TabIndex = 67;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Assiduidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 79;
            this.label2.Text = "Entrada";
            // 
            // TbHrEnt
            // 
            this.TbHrEnt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.TbHrEnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbHrEnt.ForeColor = System.Drawing.Color.White;
            this.TbHrEnt.Location = new System.Drawing.Point(33, 54);
            this.TbHrEnt.Mask = "00:00";
            this.TbHrEnt.Name = "TbHrEnt";
            this.TbHrEnt.Size = new System.Drawing.Size(48, 22);
            this.TbHrEnt.TabIndex = 78;
            this.TbHrEnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TbHrEnt.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(914, 11);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(150, 54);
            this.dataGridView1.TabIndex = 69;
            this.dataGridView1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Indigo;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(296, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(2, 39);
            this.label3.TabIndex = 73;
            // 
            // DgvGeftb005
            // 
            this.DgvGeftb005.AllowUserToAddRows = false;
            this.DgvGeftb005.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvGeftb005.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvGeftb005.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvGeftb005.Location = new System.Drawing.Point(131, 106);
            this.DgvGeftb005.Margin = new System.Windows.Forms.Padding(2);
            this.DgvGeftb005.MultiSelect = false;
            this.DgvGeftb005.Name = "DgvGeftb005";
            this.DgvGeftb005.ReadOnly = true;
            this.DgvGeftb005.RowHeadersWidth = 51;
            this.DgvGeftb005.RowTemplate.Height = 24;
            this.DgvGeftb005.Size = new System.Drawing.Size(1197, 526);
            this.DgvGeftb005.TabIndex = 16;
            this.DgvGeftb005.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGeftb002_CellClick);
            this.DgvGeftb005.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DgvGeftb005_KeyDown);
            this.DgvGeftb005.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DgvGeftb005_KeyPress);
            this.DgvGeftb005.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DgvGeftb005_KeyUp);
            // 
            // TbIdAssociado
            // 
            this.TbIdAssociado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbIdAssociado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbIdAssociado.Location = new System.Drawing.Point(125, 695);
            this.TbIdAssociado.Margin = new System.Windows.Forms.Padding(2);
            this.TbIdAssociado.MaxLength = 60;
            this.TbIdAssociado.Name = "TbIdAssociado";
            this.TbIdAssociado.Size = new System.Drawing.Size(52, 22);
            this.TbIdAssociado.TabIndex = 75;
            this.TbIdAssociado.Visible = false;
            // 
            // TbSigla
            // 
            this.TbSigla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbSigla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbSigla.Location = new System.Drawing.Point(125, 725);
            this.TbSigla.Margin = new System.Windows.Forms.Padding(2);
            this.TbSigla.MaxLength = 60;
            this.TbSigla.Name = "TbSigla";
            this.TbSigla.Size = new System.Drawing.Size(52, 22);
            this.TbSigla.TabIndex = 76;
            this.TbSigla.Visible = false;
            // 
            // TbMatricula
            // 
            this.TbMatricula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.TbMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbMatricula.ForeColor = System.Drawing.Color.White;
            this.TbMatricula.Location = new System.Drawing.Point(235, 666);
            this.TbMatricula.Mask = "A00000-00";
            this.TbMatricula.Name = "TbMatricula";
            this.TbMatricula.Size = new System.Drawing.Size(111, 22);
            this.TbMatricula.TabIndex = 77;
            this.TbMatricula.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TbMatricula.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // TbIdAgenda
            // 
            this.TbIdAgenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbIdAgenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbIdAgenda.Location = new System.Drawing.Point(125, 666);
            this.TbIdAgenda.Margin = new System.Windows.Forms.Padding(2);
            this.TbIdAgenda.MaxLength = 60;
            this.TbIdAgenda.Name = "TbIdAgenda";
            this.TbIdAgenda.Size = new System.Drawing.Size(52, 22);
            this.TbIdAgenda.TabIndex = 78;
            this.TbIdAgenda.Visible = false;
            // 
            // DgvGeftb003
            // 
            this.DgvGeftb003.AllowUserToAddRows = false;
            this.DgvGeftb003.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvGeftb003.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvGeftb003.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvGeftb003.Location = new System.Drawing.Point(334, 36);
            this.DgvGeftb003.Margin = new System.Windows.Forms.Padding(2);
            this.DgvGeftb003.MultiSelect = false;
            this.DgvGeftb003.Name = "DgvGeftb003";
            this.DgvGeftb003.ReadOnly = true;
            this.DgvGeftb003.RowHeadersWidth = 51;
            this.DgvGeftb003.RowTemplate.Height = 24;
            this.DgvGeftb003.Size = new System.Drawing.Size(86, 28);
            this.DgvGeftb003.TabIndex = 80;
            // 
            // DgvGeftb0051
            // 
            this.DgvGeftb0051.AllowUserToAddRows = false;
            this.DgvGeftb0051.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvGeftb0051.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvGeftb0051.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvGeftb0051.Location = new System.Drawing.Point(334, 36);
            this.DgvGeftb0051.Margin = new System.Windows.Forms.Padding(2);
            this.DgvGeftb0051.MultiSelect = false;
            this.DgvGeftb0051.Name = "DgvGeftb0051";
            this.DgvGeftb0051.ReadOnly = true;
            this.DgvGeftb0051.RowHeadersWidth = 51;
            this.DgvGeftb0051.RowTemplate.Height = 24;
            this.DgvGeftb0051.Size = new System.Drawing.Size(86, 28);
            this.DgvGeftb0051.TabIndex = 81;
            // 
            // DgvGeftb004
            // 
            this.DgvGeftb004.AllowUserToAddRows = false;
            this.DgvGeftb004.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvGeftb004.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvGeftb004.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvGeftb004.Location = new System.Drawing.Point(334, 36);
            this.DgvGeftb004.Margin = new System.Windows.Forms.Padding(2);
            this.DgvGeftb004.MultiSelect = false;
            this.DgvGeftb004.Name = "DgvGeftb004";
            this.DgvGeftb004.ReadOnly = true;
            this.DgvGeftb004.RowHeadersWidth = 51;
            this.DgvGeftb004.RowTemplate.Height = 24;
            this.DgvGeftb004.Size = new System.Drawing.Size(86, 28);
            this.DgvGeftb004.TabIndex = 83;
            // 
            // FrmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1358, 826);
            this.Controls.Add(this.TbIdAgenda);
            this.Controls.Add(this.TbMatricula);
            this.Controls.Add(this.TbSigla);
            this.Controls.Add(this.TbIdAssociado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DgvGeftb005);
            this.Controls.Add(this.DtpAtividade);
            this.Controls.Add(this.TbNome);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvGeftb003);
            this.Controls.Add(this.DgvGeftb0051);
            this.Controls.Add(this.DgvGeftb004);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmAgenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agendas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGeftb005)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGeftb003)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGeftb0051)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGeftb004)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TbNome;
        private System.Windows.Forms.TextBox TbJustificativa;
        private System.Windows.Forms.DateTimePicker DtpAtividade;
        private System.Windows.Forms.ToolStripMenuItem cancelarAtualizaçãoToolStripMenuItem1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnAltReg;
        private System.Windows.Forms.Button BtnImpRecBolsa;
        private System.Windows.Forms.Button BtnImprime;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.RadioButton RbPresenca;
        private System.Windows.Forms.RadioButton RbFalta;
        private System.Windows.Forms.CheckBox CbxVestuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DgvGeftb005;
        private System.Windows.Forms.TextBox TbIdAssociado;
        private System.Windows.Forms.TextBox TbSigla;
        private System.Windows.Forms.MaskedTextBox TbMatricula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox TbHrEnt;
        private System.Windows.Forms.TextBox TbIdAgenda;
        private System.Windows.Forms.DataGridView DgvGeftb003;
        private System.Windows.Forms.DataGridView DgvGeftb0051;
        private System.Windows.Forms.DataGridView DgvGeftb004;
    }
}


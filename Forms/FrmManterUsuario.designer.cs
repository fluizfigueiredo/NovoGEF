namespace NovoGEF.Forms
{
    partial class FrmManterUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManterUsuario));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TbMatricula = new System.Windows.Forms.TextBox();
            this.TbNome = new System.Windows.Forms.TextBox();
            this.DtpFim = new System.Windows.Forms.DateTimePicker();
            this.DtpInicio = new System.Windows.Forms.DateTimePicker();
            this.CbxDtFim = new System.Windows.Forms.CheckBox();
            this.cancelarAtualizaçãoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnBuscarAss = new System.Windows.Forms.Button();
            this.BtnResSenha = new System.Windows.Forms.Button();
            this.BtnAtuReg = new System.Windows.Forms.Button();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.TbDtFim = new System.Windows.Forms.TextBox();
            this.CbNivelSeg = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.DgvGeftb001 = new System.Windows.Forms.DataGridView();
            this.TbIdUsuario = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGeftb001)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(327, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(127, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Data de Cadastro";
            // 
            // TbMatricula
            // 
            this.TbMatricula.BackColor = System.Drawing.Color.Indigo;
            this.TbMatricula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbMatricula.ForeColor = System.Drawing.Color.White;
            this.TbMatricula.Location = new System.Drawing.Point(134, 91);
            this.TbMatricula.Margin = new System.Windows.Forms.Padding(2);
            this.TbMatricula.MaxLength = 10;
            this.TbMatricula.Name = "TbMatricula";
            this.TbMatricula.ReadOnly = true;
            this.TbMatricula.Size = new System.Drawing.Size(100, 22);
            this.TbMatricula.TabIndex = 3;
            this.TbMatricula.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TbNome
            // 
            this.TbNome.BackColor = System.Drawing.Color.Indigo;
            this.TbNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbNome.ForeColor = System.Drawing.Color.White;
            this.TbNome.Location = new System.Drawing.Point(325, 92);
            this.TbNome.Margin = new System.Windows.Forms.Padding(2);
            this.TbNome.MaxLength = 60;
            this.TbNome.Name = "TbNome";
            this.TbNome.ReadOnly = true;
            this.TbNome.Size = new System.Drawing.Size(530, 22);
            this.TbNome.TabIndex = 5;
            // 
            // DtpFim
            // 
            this.DtpFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFim.Location = new System.Drawing.Point(264, 39);
            this.DtpFim.Margin = new System.Windows.Forms.Padding(2);
            this.DtpFim.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DtpFim.Name = "DtpFim";
            this.DtpFim.Size = new System.Drawing.Size(93, 22);
            this.DtpFim.TabIndex = 2;
            this.DtpFim.Value = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DtpFim.Visible = false;
            // 
            // DtpInicio
            // 
            this.DtpInicio.CalendarTitleBackColor = System.Drawing.Color.Indigo;
            this.DtpInicio.CustomFormat = "";
            this.DtpInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpInicio.Location = new System.Drawing.Point(125, 39);
            this.DtpInicio.Margin = new System.Windows.Forms.Padding(2);
            this.DtpInicio.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DtpInicio.Name = "DtpInicio";
            this.DtpInicio.Size = new System.Drawing.Size(92, 22);
            this.DtpInicio.TabIndex = 1;
            this.DtpInicio.Value = new System.DateTime(2025, 8, 19, 0, 0, 0, 0);
            // 
            // CbxDtFim
            // 
            this.CbxDtFim.AutoSize = true;
            this.CbxDtFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxDtFim.Location = new System.Drawing.Point(264, 22);
            this.CbxDtFim.Name = "CbxDtFim";
            this.CbxDtFim.Size = new System.Drawing.Size(181, 20);
            this.CbxDtFim.TabIndex = 53;
            this.CbxDtFim.Text = "Data de Desligamento";
            this.CbxDtFim.UseVisualStyleBackColor = true;
            this.CbxDtFim.CheckedChanged += new System.EventHandler(this.CbxDtFim_CheckedChanged);
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
            this.panel1.Controls.Add(this.BtnBuscarAss);
            this.panel1.Controls.Add(this.BtnResSenha);
            this.panel1.Controls.Add(this.BtnAtuReg);
            this.panel1.Controls.Add(this.BtnCadastrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 406);
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
            this.BtnSair.Location = new System.Drawing.Point(0, 320);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(100, 80);
            this.BtnSair.TabIndex = 9;
            this.BtnSair.Text = "Fechar";
            this.BtnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click_1);
            // 
            // BtnBuscarAss
            // 
            this.BtnBuscarAss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.BtnBuscarAss.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnBuscarAss.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.BtnBuscarAss.FlatAppearance.BorderSize = 0;
            this.BtnBuscarAss.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.BtnBuscarAss.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.BtnBuscarAss.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarAss.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarAss.ForeColor = System.Drawing.Color.White;
            this.BtnBuscarAss.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscarAss.Image")));
            this.BtnBuscarAss.Location = new System.Drawing.Point(0, 240);
            this.BtnBuscarAss.Name = "BtnBuscarAss";
            this.BtnBuscarAss.Size = new System.Drawing.Size(100, 80);
            this.BtnBuscarAss.TabIndex = 10;
            this.BtnBuscarAss.Text = "Buscar Usuario";
            this.BtnBuscarAss.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnBuscarAss.UseVisualStyleBackColor = false;
            this.BtnBuscarAss.Click += new System.EventHandler(this.BtnBuscarAss_Click);
            // 
            // BtnResSenha
            // 
            this.BtnResSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.BtnResSenha.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnResSenha.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.BtnResSenha.FlatAppearance.BorderSize = 0;
            this.BtnResSenha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.BtnResSenha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.BtnResSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnResSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnResSenha.ForeColor = System.Drawing.Color.White;
            this.BtnResSenha.Image = ((System.Drawing.Image)(resources.GetObject("BtnResSenha.Image")));
            this.BtnResSenha.Location = new System.Drawing.Point(0, 160);
            this.BtnResSenha.Name = "BtnResSenha";
            this.BtnResSenha.Size = new System.Drawing.Size(100, 80);
            this.BtnResSenha.TabIndex = 8;
            this.BtnResSenha.Text = "Resetar Senha";
            this.BtnResSenha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnResSenha.UseVisualStyleBackColor = false;
            this.BtnResSenha.Click += new System.EventHandler(this.BtnResSenha_Click);
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
            this.BtnAtuReg.Click += new System.EventHandler(this.BtnAtuReg_Click_1);
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
            this.BtnCadastrar.Text = "Incluir Associado";
            this.BtnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnCadastrar.UseVisualStyleBackColor = false;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadAss_Click);
            // 
            // TbDtFim
            // 
            this.TbDtFim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbDtFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbDtFim.Location = new System.Drawing.Point(312, 133);
            this.TbDtFim.Margin = new System.Windows.Forms.Padding(2);
            this.TbDtFim.Name = "TbDtFim";
            this.TbDtFim.Size = new System.Drawing.Size(28, 19);
            this.TbDtFim.TabIndex = 59;
            this.TbDtFim.Text = "123";
            this.TbDtFim.Visible = false;
            // 
            // CbNivelSeg
            // 
            this.CbNivelSeg.FormattingEnabled = true;
            this.CbNivelSeg.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.CbNivelSeg.Location = new System.Drawing.Point(127, 142);
            this.CbNivelSeg.Margin = new System.Windows.Forms.Padding(2);
            this.CbNivelSeg.Name = "CbNivelSeg";
            this.CbNivelSeg.Size = new System.Drawing.Size(64, 24);
            this.CbNivelSeg.TabIndex = 17;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(131, 123);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(144, 16);
            this.label18.TabIndex = 66;
            this.label18.Text = "Nível de Segurança";
            // 
            // DgvGeftb001
            // 
            this.DgvGeftb001.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvGeftb001.Location = new System.Drawing.Point(128, 181);
            this.DgvGeftb001.Name = "DgvGeftb001";
            this.DgvGeftb001.RowHeadersWidth = 51;
            this.DgvGeftb001.Size = new System.Drawing.Size(727, 203);
            this.DgvGeftb001.TabIndex = 68;
            this.DgvGeftb001.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGeftb001_CellClick_1);
            this.DgvGeftb001.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DgvGeftb001_KeyDown_1);
            this.DgvGeftb001.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DgvGeftb001_KeyPress_1);
            this.DgvGeftb001.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DgvGeftb001_KeyUp_1);
            // 
            // TbIdUsuario
            // 
            this.TbIdUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbIdUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbIdUsuario.Location = new System.Drawing.Point(359, 133);
            this.TbIdUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.TbIdUsuario.Name = "TbIdUsuario";
            this.TbIdUsuario.Size = new System.Drawing.Size(28, 19);
            this.TbIdUsuario.TabIndex = 69;
            this.TbIdUsuario.Text = "0";
            this.TbIdUsuario.Visible = false;
            // 
            // FrmManterUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(879, 406);
            this.Controls.Add(this.TbIdUsuario);
            this.Controls.Add(this.DgvGeftb001);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.CbNivelSeg);
            this.Controls.Add(this.TbDtFim);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CbxDtFim);
            this.Controls.Add(this.DtpInicio);
            this.Controls.Add(this.DtpFim);
            this.Controls.Add(this.TbNome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbMatricula);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmManterUsuario";
            this.Text = "Cadastro de Usuários";
            this.Load += new System.EventHandler(this.FrmManterUsuario_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvGeftb001)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TbMatricula;
        private System.Windows.Forms.TextBox TbNome;
        private System.Windows.Forms.DateTimePicker DtpFim;
        private System.Windows.Forms.DateTimePicker DtpInicio;
        private System.Windows.Forms.CheckBox CbxDtFim;
        private System.Windows.Forms.ToolStripMenuItem cancelarAtualizaçãoToolStripMenuItem1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.Button BtnAtuReg;
        private System.Windows.Forms.Button BtnResSenha;
        private System.Windows.Forms.TextBox TbDtFim;
        private System.Windows.Forms.ComboBox CbNivelSeg;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView DgvGeftb001;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnBuscarAss;
        private System.Windows.Forms.TextBox TbIdUsuario;
    }
}


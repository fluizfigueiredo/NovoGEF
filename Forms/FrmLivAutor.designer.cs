namespace NovoGEF.Forms
{
    partial class FrmLivAutor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLivAutor));
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TbIdAutor = new System.Windows.Forms.TextBox();
            this.TbNomeAutor = new System.Windows.Forms.TextBox();
            this.DgvGeftb010 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnCan = new System.Windows.Forms.Button();
            this.BtnConf = new System.Windows.Forms.Button();
            this.BtnAtuReg = new System.Windows.Forms.Button();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGeftb010)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(231, 40);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Nome do Autor";
            // 
            // TbIdAutor
            // 
            this.TbIdAutor.BackColor = System.Drawing.Color.Indigo;
            this.TbIdAutor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbIdAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbIdAutor.ForeColor = System.Drawing.Color.White;
            this.TbIdAutor.Location = new System.Drawing.Point(126, 58);
            this.TbIdAutor.Margin = new System.Windows.Forms.Padding(2);
            this.TbIdAutor.MaxLength = 10;
            this.TbIdAutor.Name = "TbIdAutor";
            this.TbIdAutor.ReadOnly = true;
            this.TbIdAutor.Size = new System.Drawing.Size(82, 22);
            this.TbIdAutor.TabIndex = 3;
            this.TbIdAutor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TbNomeAutor
            // 
            this.TbNomeAutor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbNomeAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbNomeAutor.Location = new System.Drawing.Point(229, 58);
            this.TbNomeAutor.Margin = new System.Windows.Forms.Padding(2);
            this.TbNomeAutor.MaxLength = 60;
            this.TbNomeAutor.Name = "TbNomeAutor";
            this.TbNomeAutor.Size = new System.Drawing.Size(438, 22);
            this.TbNomeAutor.TabIndex = 12;
            // 
            // DgvGeftb010
            // 
            this.DgvGeftb010.AllowUserToAddRows = false;
            this.DgvGeftb010.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvGeftb010.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvGeftb010.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvGeftb010.Location = new System.Drawing.Point(126, 100);
            this.DgvGeftb010.Margin = new System.Windows.Forms.Padding(2);
            this.DgvGeftb010.MultiSelect = false;
            this.DgvGeftb010.Name = "DgvGeftb010";
            this.DgvGeftb010.ReadOnly = true;
            this.DgvGeftb010.RowHeadersWidth = 51;
            this.DgvGeftb010.RowTemplate.Height = 24;
            this.DgvGeftb010.Size = new System.Drawing.Size(541, 560);
            this.DgvGeftb010.TabIndex = 16;
            this.DgvGeftb010.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGeftb010_CellClick);
            this.DgvGeftb010.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DgvGeftb010_KeyDown);
            this.DgvGeftb010.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DgvGeftb010_KeyPress);
            this.DgvGeftb010.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DgvGeftb010_KeyUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.panel1.Controls.Add(this.BtnSair);
            this.panel1.Controls.Add(this.BtnCan);
            this.panel1.Controls.Add(this.BtnConf);
            this.panel1.Controls.Add(this.BtnAtuReg);
            this.panel1.Controls.Add(this.BtnCadastrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 681);
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
            this.BtnSair.Location = new System.Drawing.Point(0, 320);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(100, 80);
            this.BtnSair.TabIndex = 73;
            this.BtnSair.Text = "Fechar";
            this.BtnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click_1);
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
            this.BtnCan.Location = new System.Drawing.Point(0, 240);
            this.BtnCan.Name = "BtnCan";
            this.BtnCan.Size = new System.Drawing.Size(100, 80);
            this.BtnCan.TabIndex = 75;
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
            this.BtnConf.Location = new System.Drawing.Point(0, 160);
            this.BtnConf.Name = "BtnConf";
            this.BtnConf.Size = new System.Drawing.Size(100, 80);
            this.BtnConf.TabIndex = 74;
            this.BtnConf.Text = "Confirmar";
            this.BtnConf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnConf.UseVisualStyleBackColor = false;
            this.BtnConf.Visible = false;
            this.BtnConf.Click += new System.EventHandler(this.BtnConf_Click);
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
            this.BtnAtuReg.Text = "Alterar Autor";
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
            this.BtnCadastrar.Text = "Incluir Autor";
            this.BtnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnCadastrar.UseVisualStyleBackColor = false;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // FrmLivAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(694, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DgvGeftb010);
            this.Controls.Add(this.TbNomeAutor);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbIdAutor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmLivAutor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Autores";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvGeftb010)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TbIdAutor;
        private System.Windows.Forms.TextBox TbNomeAutor;
        private System.Windows.Forms.DataGridView DgvGeftb010;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnAtuReg;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.Button BtnCan;
        private System.Windows.Forms.Button BtnConf;
    }
}


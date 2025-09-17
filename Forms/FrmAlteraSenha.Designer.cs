namespace NovoGEF.Forms
{
    partial class FrmAlteraSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlteraSenha));
            this.TbSenhaAtual = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DgvGeftb001 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.TbMatricula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TbSenhaNova = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnConf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGeftb001)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbSenhaAtual
            // 
            this.TbSenhaAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbSenhaAtual.Location = new System.Drawing.Point(139, 89);
            this.TbSenhaAtual.Name = "TbSenhaAtual";
            this.TbSenhaAtual.PasswordChar = '*';
            this.TbSenhaAtual.Size = new System.Drawing.Size(133, 22);
            this.TbSenhaAtual.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(142, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 62;
            this.label2.Text = "Senha Atual";
            // 
            // DgvGeftb001
            // 
            this.DgvGeftb001.AllowUserToAddRows = false;
            this.DgvGeftb001.AllowUserToDeleteRows = false;
            this.DgvGeftb001.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvGeftb001.Enabled = false;
            this.DgvGeftb001.Location = new System.Drawing.Point(14, 106);
            this.DgvGeftb001.Margin = new System.Windows.Forms.Padding(2);
            this.DgvGeftb001.MultiSelect = false;
            this.DgvGeftb001.Name = "DgvGeftb001";
            this.DgvGeftb001.ReadOnly = true;
            this.DgvGeftb001.RowHeadersWidth = 51;
            this.DgvGeftb001.RowTemplate.Height = 24;
            this.DgvGeftb001.Size = new System.Drawing.Size(123, 54);
            this.DgvGeftb001.TabIndex = 6;
            this.DgvGeftb001.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(134, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 71;
            this.label4.Text = "Matricula";
            // 
            // TbMatricula
            // 
            this.TbMatricula.BackColor = System.Drawing.Color.Indigo;
            this.TbMatricula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbMatricula.ForeColor = System.Drawing.Color.White;
            this.TbMatricula.Location = new System.Drawing.Point(137, 35);
            this.TbMatricula.Margin = new System.Windows.Forms.Padding(2);
            this.TbMatricula.MaxLength = 10;
            this.TbMatricula.Name = "TbMatricula";
            this.TbMatricula.ReadOnly = true;
            this.TbMatricula.Size = new System.Drawing.Size(95, 22);
            this.TbMatricula.TabIndex = 1;
            this.TbMatricula.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 77;
            this.label1.Text = "Senha Nova";
            // 
            // TbSenhaNova
            // 
            this.TbSenhaNova.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbSenhaNova.Location = new System.Drawing.Point(139, 141);
            this.TbSenhaNova.Name = "TbSenhaNova";
            this.TbSenhaNova.PasswordChar = '*';
            this.TbSenhaNova.Size = new System.Drawing.Size(133, 22);
            this.TbSenhaNova.TabIndex = 76;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.panel1.Controls.Add(this.BtnCancel);
            this.panel1.Controls.Add(this.BtnConf);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 184);
            this.panel1.TabIndex = 78;
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
            this.BtnCancel.Location = new System.Drawing.Point(0, 80);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(100, 80);
            this.BtnCancel.TabIndex = 73;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnCancel.UseVisualStyleBackColor = false;
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
            this.BtnConf.Location = new System.Drawing.Point(0, 0);
            this.BtnConf.Name = "BtnConf";
            this.BtnConf.Size = new System.Drawing.Size(100, 80);
            this.BtnConf.TabIndex = 72;
            this.BtnConf.Text = "Confirmar";
            this.BtnConf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnConf.UseVisualStyleBackColor = false;
            this.BtnConf.Click += new System.EventHandler(this.BtnConf_Click);
            // 
            // FrmAlteraSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(340, 184);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbSenhaNova);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TbMatricula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbSenhaAtual);
            this.Controls.Add(this.DgvGeftb001);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1300, 980);
            this.MinimizeBox = false;
            this.Name = "FrmAlteraSenha";
            this.Text = "Manutenção de Senha";
            ((System.ComponentModel.ISupportInitialize)(this.DgvGeftb001)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TbSenhaAtual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DgvGeftb001;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbMatricula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbSenhaNova;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnConf;
        private System.Windows.Forms.Button BtnCancel;
    }
}


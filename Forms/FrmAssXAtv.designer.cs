namespace NovoGEF
{
    partial class FrmAssXAtv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAssXAtv));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CbTipoAss = new System.Windows.Forms.ComboBox();
            this.cancelarAtualizaçãoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSair = new System.Windows.Forms.Button();
            this.DgvGeftb003 = new System.Windows.Forms.DataGridView();
            this.DgvGeftb004 = new System.Windows.Forms.DataGridView();
            this.BtnAtiva = new System.Windows.Forms.Button();
            this.BtnDesativa = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CbAssociado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGeftb003)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGeftb004)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CbTipoAss
            // 
            this.CbTipoAss.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbTipoAss.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbTipoAss.FormattingEnabled = true;
            this.CbTipoAss.Items.AddRange(new object[] {
            "ASSISTIDO",
            "FREQUENTADOR",
            "GESTANTE"});
            this.CbTipoAss.Location = new System.Drawing.Point(163, 40);
            this.CbTipoAss.Margin = new System.Windows.Forms.Padding(2);
            this.CbTipoAss.Name = "CbTipoAss";
            this.CbTipoAss.Size = new System.Drawing.Size(209, 24);
            this.CbTipoAss.TabIndex = 16;
            this.CbTipoAss.SelectedIndexChanged += new System.EventHandler(this.CbTipoAss_SelectedIndexChanged);
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
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 459);
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
            this.BtnSair.Location = new System.Drawing.Point(0, 0);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(100, 80);
            this.BtnSair.TabIndex = 8;
            this.BtnSair.Text = "Fechar";
            this.BtnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // DgvGeftb003
            // 
            this.DgvGeftb003.AllowUserToAddRows = false;
            this.DgvGeftb003.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvGeftb003.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvGeftb003.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvGeftb003.Location = new System.Drawing.Point(128, 101);
            this.DgvGeftb003.Margin = new System.Windows.Forms.Padding(2);
            this.DgvGeftb003.MultiSelect = false;
            this.DgvGeftb003.Name = "DgvGeftb003";
            this.DgvGeftb003.ReadOnly = true;
            this.DgvGeftb003.RowHeadersWidth = 51;
            this.DgvGeftb003.RowTemplate.Height = 24;
            this.DgvGeftb003.Size = new System.Drawing.Size(499, 335);
            this.DgvGeftb003.TabIndex = 59;
            // 
            // DgvGeftb004
            // 
            this.DgvGeftb004.AllowUserToAddRows = false;
            this.DgvGeftb004.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvGeftb004.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvGeftb004.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvGeftb004.Location = new System.Drawing.Point(827, 101);
            this.DgvGeftb004.Margin = new System.Windows.Forms.Padding(2);
            this.DgvGeftb004.MultiSelect = false;
            this.DgvGeftb004.Name = "DgvGeftb004";
            this.DgvGeftb004.ReadOnly = true;
            this.DgvGeftb004.RowHeadersWidth = 51;
            this.DgvGeftb004.RowTemplate.Height = 24;
            this.DgvGeftb004.Size = new System.Drawing.Size(322, 335);
            this.DgvGeftb004.TabIndex = 60;
            // 
            // BtnAtiva
            // 
            this.BtnAtiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtiva.Image = ((System.Drawing.Image)(resources.GetObject("BtnAtiva.Image")));
            this.BtnAtiva.Location = new System.Drawing.Point(683, 174);
            this.BtnAtiva.Name = "BtnAtiva";
            this.BtnAtiva.Size = new System.Drawing.Size(90, 79);
            this.BtnAtiva.TabIndex = 63;
            this.BtnAtiva.Tag = "";
            this.BtnAtiva.UseVisualStyleBackColor = true;
            this.BtnAtiva.Click += new System.EventHandler(this.BtnAtiva_Click);
            // 
            // BtnDesativa
            // 
            this.BtnDesativa.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDesativa.Image = ((System.Drawing.Image)(resources.GetObject("BtnDesativa.Image")));
            this.BtnDesativa.Location = new System.Drawing.Point(683, 284);
            this.BtnDesativa.Name = "BtnDesativa";
            this.BtnDesativa.Size = new System.Drawing.Size(90, 79);
            this.BtnDesativa.TabIndex = 64;
            this.BtnDesativa.UseVisualStyleBackColor = true;
            this.BtnDesativa.Click += new System.EventHandler(this.BtnDesativa_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(462, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(164, 56);
            this.dataGridView1.TabIndex = 69;
            // 
            // CbAssociado
            // 
            this.CbAssociado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbAssociado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbAssociado.FormattingEnabled = true;
            this.CbAssociado.Location = new System.Drawing.Point(400, 40);
            this.CbAssociado.Name = "CbAssociado";
            this.CbAssociado.Size = new System.Drawing.Size(749, 24);
            this.CbAssociado.TabIndex = 71;
            this.CbAssociado.SelectedIndexChanged += new System.EventHandler(this.CbAssociado_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(404, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 72;
            this.label3.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(166, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 73;
            this.label4.Text = "Tipo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 16);
            this.label1.TabIndex = 74;
            this.label1.Text = "Atividades Elegíveis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(830, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 16);
            this.label2.TabIndex = 75;
            this.label2.Text = "Atividades do Associado";
            // 
            // FrmAssXAtv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1208, 459);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CbTipoAss);
            this.Controls.Add(this.CbAssociado);
            this.Controls.Add(this.BtnDesativa);
            this.Controls.Add(this.BtnAtiva);
            this.Controls.Add(this.DgvGeftb004);
            this.Controls.Add(this.DgvGeftb003);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAssXAtv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Atividades do Associado";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvGeftb003)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGeftb004)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CbTipoAss;
        private System.Windows.Forms.ToolStripMenuItem cancelarAtualizaçãoToolStripMenuItem1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.DataGridView DgvGeftb003;
        private System.Windows.Forms.DataGridView DgvGeftb004;
        private System.Windows.Forms.Button BtnAtiva;
        private System.Windows.Forms.Button BtnDesativa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox CbAssociado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


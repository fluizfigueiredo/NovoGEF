namespace NovoGEF.Forms
{
    partial class FrmImpFreqAtv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmImpFreqAtv));
            this.label2 = new System.Windows.Forms.Label();
            this.DgvGeftb003 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnConf = new System.Windows.Forms.Button();
            this.CbAtividade = new System.Windows.Forms.ComboBox();
            this.TbDtAgenda = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGeftb003)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 16);
            this.label2.TabIndex = 62;
            this.label2.Text = "Selecione a atividade que deseja imprimir";
            // 
            // DgvGeftb003
            // 
            this.DgvGeftb003.AllowUserToAddRows = false;
            this.DgvGeftb003.AllowUserToDeleteRows = false;
            this.DgvGeftb003.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvGeftb003.Enabled = false;
            this.DgvGeftb003.Location = new System.Drawing.Point(14, 106);
            this.DgvGeftb003.Margin = new System.Windows.Forms.Padding(2);
            this.DgvGeftb003.MultiSelect = false;
            this.DgvGeftb003.Name = "DgvGeftb003";
            this.DgvGeftb003.ReadOnly = true;
            this.DgvGeftb003.RowHeadersWidth = 51;
            this.DgvGeftb003.RowTemplate.Height = 24;
            this.DgvGeftb003.Size = new System.Drawing.Size(123, 54);
            this.DgvGeftb003.TabIndex = 6;
            this.DgvGeftb003.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.panel1.Controls.Add(this.BtnCancel);
            this.panel1.Controls.Add(this.BtnConf);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 176);
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
            // CbAtividade
            // 
            this.CbAtividade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbAtividade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbAtividade.FormattingEnabled = true;
            this.CbAtividade.Location = new System.Drawing.Point(132, 71);
            this.CbAtividade.Name = "CbAtividade";
            this.CbAtividade.Size = new System.Drawing.Size(447, 24);
            this.CbAtividade.TabIndex = 79;
            // 
            // TbDtAgenda
            // 
            this.TbDtAgenda.Location = new System.Drawing.Point(106, 12);
            this.TbDtAgenda.Name = "TbDtAgenda";
            this.TbDtAgenda.Size = new System.Drawing.Size(152, 20);
            this.TbDtAgenda.TabIndex = 80;
            this.TbDtAgenda.Visible = false;
            // 
            // FrmImpFreqAtv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(615, 176);
            this.Controls.Add(this.TbDtAgenda);
            this.Controls.Add(this.CbAtividade);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DgvGeftb003);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1300, 980);
            this.MinimizeBox = false;
            this.Name = "FrmImpFreqAtv";
            this.Text = "Relatórios de Presença por Atividade";
            this.Load += new System.EventHandler(this.FrmImpFreqAtv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvGeftb003)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DgvGeftb003;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnConf;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.ComboBox CbAtividade;
        private System.Windows.Forms.TextBox TbDtAgenda;
    }
}


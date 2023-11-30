namespace sistema_estoque
{
    partial class FormListaUnidadesMedida
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListaUnidadesMedida));
            this.txtPesqUM = new System.Windows.Forms.TextBox();
            this.dgvUnidadesMedida = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.btnNovaUM = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnidadesMedida)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPesqUM
            // 
            this.txtPesqUM.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesqUM.Location = new System.Drawing.Point(746, 10);
            this.txtPesqUM.Name = "txtPesqUM";
            this.txtPesqUM.Size = new System.Drawing.Size(210, 26);
            this.txtPesqUM.TabIndex = 59;
            this.txtPesqUM.TextChanged += new System.EventHandler(this.txtPesqUM_TextChanged);
            // 
            // dgvUnidadesMedida
            // 
            this.dgvUnidadesMedida.AllowUserToAddRows = false;
            this.dgvUnidadesMedida.AllowUserToDeleteRows = false;
            this.dgvUnidadesMedida.AllowUserToResizeColumns = false;
            this.dgvUnidadesMedida.AllowUserToResizeRows = false;
            this.dgvUnidadesMedida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUnidadesMedida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUnidadesMedida.BackgroundColor = System.Drawing.Color.White;
            this.dgvUnidadesMedida.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUnidadesMedida.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUnidadesMedida.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUnidadesMedida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUnidadesMedida.EnableHeadersVisualStyles = false;
            this.dgvUnidadesMedida.GridColor = System.Drawing.Color.Silver;
            this.dgvUnidadesMedida.Location = new System.Drawing.Point(12, 50);
            this.dgvUnidadesMedida.Name = "dgvUnidadesMedida";
            this.dgvUnidadesMedida.ReadOnly = true;
            this.dgvUnidadesMedida.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvUnidadesMedida.RowHeadersVisible = false;
            this.dgvUnidadesMedida.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvUnidadesMedida.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUnidadesMedida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUnidadesMedida.Size = new System.Drawing.Size(1035, 399);
            this.dgvUnidadesMedida.TabIndex = 58;
            this.dgvUnidadesMedida.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnidadesMedida_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Location = new System.Drawing.Point(12, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(16, 29);
            this.panel1.TabIndex = 57;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(31, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(343, 32);
            this.label12.TabIndex = 56;
            this.label12.Text = "Lista de Unidades de Medida";
            // 
            // btnNovaUM
            // 
            this.btnNovaUM.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnNovaUM.FlatAppearance.BorderSize = 0;
            this.btnNovaUM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaUM.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaUM.ForeColor = System.Drawing.Color.White;
            this.btnNovaUM.Location = new System.Drawing.Point(962, 7);
            this.btnNovaUM.Name = "btnNovaUM";
            this.btnNovaUM.Size = new System.Drawing.Size(85, 32);
            this.btnNovaUM.TabIndex = 60;
            this.btnNovaUM.Text = "Adicionar";
            this.btnNovaUM.UseVisualStyleBackColor = false;
            this.btnNovaUM.Click += new System.EventHandler(this.btnNovaUM_Click);
            // 
            // FormListaUnidadesMedida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1059, 461);
            this.Controls.Add(this.btnNovaUM);
            this.Controls.Add(this.txtPesqUM);
            this.Controls.Add(this.dgvUnidadesMedida);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormListaUnidadesMedida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Unidade de sMedida";
            this.Load += new System.EventHandler(this.FormListaUnidadesMedida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnidadesMedida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPesqUM;
        public System.Windows.Forms.DataGridView dgvUnidadesMedida;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnNovaUM;
    }
}
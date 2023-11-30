namespace sistema_estoque
{
    partial class FormListaMarca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListaMarca));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNovaMarca = new System.Windows.Forms.Button();
            this.txtPesqMarca = new System.Windows.Forms.TextBox();
            this.btnExcluirMarca = new System.Windows.Forms.Button();
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::sistema_estoque.Properties.Resources.search;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(931, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
            // 
            // btnNovaMarca
            // 
            this.btnNovaMarca.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnNovaMarca.FlatAppearance.BorderSize = 0;
            this.btnNovaMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaMarca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaMarca.ForeColor = System.Drawing.Color.White;
            this.btnNovaMarca.Location = new System.Drawing.Point(962, 7);
            this.btnNovaMarca.Name = "btnNovaMarca";
            this.btnNovaMarca.Size = new System.Drawing.Size(85, 32);
            this.btnNovaMarca.TabIndex = 64;
            this.btnNovaMarca.Text = "Adicionar";
            this.btnNovaMarca.UseVisualStyleBackColor = false;
            this.btnNovaMarca.Click += new System.EventHandler(this.btnNovoForne_Click);
            // 
            // txtPesqMarca
            // 
            this.txtPesqMarca.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesqMarca.Location = new System.Drawing.Point(747, 10);
            this.txtPesqMarca.Name = "txtPesqMarca";
            this.txtPesqMarca.Size = new System.Drawing.Size(210, 26);
            this.txtPesqMarca.TabIndex = 63;
            this.txtPesqMarca.TextChanged += new System.EventHandler(this.txtPesqForne_TextChanged);
            // 
            // btnExcluirMarca
            // 
            this.btnExcluirMarca.BackColor = System.Drawing.Color.Tomato;
            this.btnExcluirMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirMarca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirMarca.ForeColor = System.Drawing.Color.White;
            this.btnExcluirMarca.Location = new System.Drawing.Point(300, 6);
            this.btnExcluirMarca.Name = "btnExcluirMarca";
            this.btnExcluirMarca.Size = new System.Drawing.Size(85, 32);
            this.btnExcluirMarca.TabIndex = 62;
            this.btnExcluirMarca.Text = "Excluir";
            this.btnExcluirMarca.UseVisualStyleBackColor = false;
            this.btnExcluirMarca.Click += new System.EventHandler(this.btnExcluirMarca_Click);
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.AllowUserToAddRows = false;
            this.dgvMarcas.AllowUserToDeleteRows = false;
            this.dgvMarcas.AllowUserToResizeColumns = false;
            this.dgvMarcas.AllowUserToResizeRows = false;
            this.dgvMarcas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMarcas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMarcas.BackgroundColor = System.Drawing.Color.White;
            this.dgvMarcas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMarcas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMarcas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMarcas.EnableHeadersVisualStyles = false;
            this.dgvMarcas.GridColor = System.Drawing.Color.Silver;
            this.dgvMarcas.Location = new System.Drawing.Point(12, 50);
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.ReadOnly = true;
            this.dgvMarcas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMarcas.RowHeadersVisible = false;
            this.dgvMarcas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvMarcas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMarcas.Size = new System.Drawing.Size(1035, 399);
            this.dgvMarcas.TabIndex = 61;
            this.dgvMarcas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMarcas_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Location = new System.Drawing.Point(12, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(16, 29);
            this.panel1.TabIndex = 60;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(31, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(191, 32);
            this.label12.TabIndex = 59;
            this.label12.Text = "Lista de Marcas";
            // 
            // FormListaMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1059, 461);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnNovaMarca);
            this.Controls.Add(this.txtPesqMarca);
            this.Controls.Add(this.btnExcluirMarca);
            this.Controls.Add(this.dgvMarcas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormListaMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Marcas";
            this.Load += new System.EventHandler(this.FormListaMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNovaMarca;
        private System.Windows.Forms.TextBox txtPesqMarca;
        private System.Windows.Forms.Button btnExcluirMarca;
        private System.Windows.Forms.DataGridView dgvMarcas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
    }
}
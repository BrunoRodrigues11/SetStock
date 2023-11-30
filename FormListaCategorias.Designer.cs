namespace sistema_estoque
{
    partial class FormListaCategorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListaCategorias));
            this.txtPesqCat = new System.Windows.Forms.TextBox();
            this.btnEscluirCat = new System.Windows.Forms.Button();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.btnNovaCat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPesqCat
            // 
            this.txtPesqCat.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesqCat.Location = new System.Drawing.Point(747, 10);
            this.txtPesqCat.Name = "txtPesqCat";
            this.txtPesqCat.Size = new System.Drawing.Size(210, 26);
            this.txtPesqCat.TabIndex = 42;
            this.txtPesqCat.TextChanged += new System.EventHandler(this.txtPesqCat_TextChanged);
            // 
            // btnEscluirCat
            // 
            this.btnEscluirCat.BackColor = System.Drawing.Color.Tomato;
            this.btnEscluirCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEscluirCat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscluirCat.ForeColor = System.Drawing.Color.White;
            this.btnEscluirCat.Location = new System.Drawing.Point(267, 7);
            this.btnEscluirCat.Name = "btnEscluirCat";
            this.btnEscluirCat.Size = new System.Drawing.Size(85, 32);
            this.btnEscluirCat.TabIndex = 41;
            this.btnEscluirCat.Text = "Excluir";
            this.btnEscluirCat.UseVisualStyleBackColor = false;
            this.btnEscluirCat.Click += new System.EventHandler(this.btnEscluirCat_Click);
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.AllowUserToAddRows = false;
            this.dgvCategorias.AllowUserToDeleteRows = false;
            this.dgvCategorias.AllowUserToResizeColumns = false;
            this.dgvCategorias.AllowUserToResizeRows = false;
            this.dgvCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategorias.BackgroundColor = System.Drawing.Color.White;
            this.dgvCategorias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCategorias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCategorias.EnableHeadersVisualStyles = false;
            this.dgvCategorias.GridColor = System.Drawing.Color.Silver;
            this.dgvCategorias.Location = new System.Drawing.Point(12, 50);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.ReadOnly = true;
            this.dgvCategorias.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCategorias.RowHeadersVisible = false;
            this.dgvCategorias.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCategorias.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategorias.Size = new System.Drawing.Size(1035, 399);
            this.dgvCategorias.TabIndex = 38;
            this.dgvCategorias.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategorias_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Location = new System.Drawing.Point(12, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(16, 29);
            this.panel1.TabIndex = 37;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(31, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(230, 32);
            this.label12.TabIndex = 36;
            this.label12.Text = "Lista de Categorias";
            // 
            // btnNovaCat
            // 
            this.btnNovaCat.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnNovaCat.FlatAppearance.BorderSize = 0;
            this.btnNovaCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaCat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaCat.ForeColor = System.Drawing.Color.White;
            this.btnNovaCat.Location = new System.Drawing.Point(962, 7);
            this.btnNovaCat.Name = "btnNovaCat";
            this.btnNovaCat.Size = new System.Drawing.Size(85, 32);
            this.btnNovaCat.TabIndex = 43;
            this.btnNovaCat.Text = "Adicionar";
            this.btnNovaCat.UseVisualStyleBackColor = false;
            this.btnNovaCat.Click += new System.EventHandler(this.btnNovaCat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::sistema_estoque.Properties.Resources.search;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(931, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // FormListaCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1059, 461);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnNovaCat);
            this.Controls.Add(this.txtPesqCat);
            this.Controls.Add(this.btnEscluirCat);
            this.Controls.Add(this.dgvCategorias);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormListaCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Categorias";
            this.Load += new System.EventHandler(this.FormListaCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPesqCat;
        private System.Windows.Forms.Button btnEscluirCat;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnNovaCat;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
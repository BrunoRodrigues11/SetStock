namespace sistema_estoque
{
    partial class FormListaFornecedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListaFornecedores));
            this.btnNovaMarca = new System.Windows.Forms.Button();
            this.txtPesqForne = new System.Windows.Forms.TextBox();
            this.btnEscluirForne = new System.Windows.Forms.Button();
            this.dgvFornecedores = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.btnNovaMarca.TabIndex = 57;
            this.btnNovaMarca.Text = "Adicionar";
            this.btnNovaMarca.UseVisualStyleBackColor = false;
            this.btnNovaMarca.Click += new System.EventHandler(this.btnNovaMarca_Click);
            // 
            // txtPesqForne
            // 
            this.txtPesqForne.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesqForne.Location = new System.Drawing.Point(747, 10);
            this.txtPesqForne.Name = "txtPesqForne";
            this.txtPesqForne.Size = new System.Drawing.Size(210, 26);
            this.txtPesqForne.TabIndex = 56;
            this.txtPesqForne.TextChanged += new System.EventHandler(this.txtPesqForne_TextChanged);
            // 
            // btnEscluirForne
            // 
            this.btnEscluirForne.BackColor = System.Drawing.Color.Tomato;
            this.btnEscluirForne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEscluirForne.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscluirForne.ForeColor = System.Drawing.Color.White;
            this.btnEscluirForne.Location = new System.Drawing.Point(300, 6);
            this.btnEscluirForne.Name = "btnEscluirForne";
            this.btnEscluirForne.Size = new System.Drawing.Size(85, 32);
            this.btnEscluirForne.TabIndex = 55;
            this.btnEscluirForne.Text = "Excluir";
            this.btnEscluirForne.UseVisualStyleBackColor = false;
            this.btnEscluirForne.Click += new System.EventHandler(this.btnEscluirForne_Click);
            // 
            // dgvFornecedores
            // 
            this.dgvFornecedores.AllowUserToAddRows = false;
            this.dgvFornecedores.AllowUserToDeleteRows = false;
            this.dgvFornecedores.AllowUserToResizeColumns = false;
            this.dgvFornecedores.AllowUserToResizeRows = false;
            this.dgvFornecedores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFornecedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFornecedores.BackgroundColor = System.Drawing.Color.White;
            this.dgvFornecedores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvFornecedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFornecedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvFornecedores.EnableHeadersVisualStyles = false;
            this.dgvFornecedores.GridColor = System.Drawing.Color.Silver;
            this.dgvFornecedores.Location = new System.Drawing.Point(12, 50);
            this.dgvFornecedores.Name = "dgvFornecedores";
            this.dgvFornecedores.ReadOnly = true;
            this.dgvFornecedores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvFornecedores.RowHeadersVisible = false;
            this.dgvFornecedores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvFornecedores.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFornecedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFornecedores.Size = new System.Drawing.Size(1035, 399);
            this.dgvFornecedores.TabIndex = 54;
            this.dgvFornecedores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFornecedores_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Location = new System.Drawing.Point(12, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(16, 29);
            this.panel1.TabIndex = 53;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(31, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(263, 32);
            this.label12.TabIndex = 52;
            this.label12.Text = "Lista de Fornecedores";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::sistema_estoque.Properties.Resources.search;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(931, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // FormListaFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1059, 461);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnNovaMarca);
            this.Controls.Add(this.txtPesqForne);
            this.Controls.Add(this.btnEscluirForne);
            this.Controls.Add(this.dgvFornecedores);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormListaFornecedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Fornecedores";
            this.Load += new System.EventHandler(this.FormListaFornecedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNovaMarca;
        private System.Windows.Forms.TextBox txtPesqForne;
        private System.Windows.Forms.Button btnEscluirForne;
        private System.Windows.Forms.DataGridView dgvFornecedores;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
    }
}
namespace sistema_estoque
{
    partial class FormListaProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListaProdutos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.btnEscluirProd = new System.Windows.Forms.Button();
            this.txtPesqProd = new System.Windows.Forms.TextBox();
            this.btnNovoProd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Location = new System.Drawing.Point(12, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(16, 29);
            this.panel1.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(31, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(214, 32);
            this.label12.TabIndex = 28;
            this.label12.Text = "Lista de Produtos";
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToResizeColumns = false;
            this.dgvProdutos.AllowUserToResizeRows = false;
            this.dgvProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdutos.BackgroundColor = System.Drawing.Color.White;
            this.dgvProdutos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProdutos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProdutos.EnableHeadersVisualStyles = false;
            this.dgvProdutos.GridColor = System.Drawing.Color.Silver;
            this.dgvProdutos.Location = new System.Drawing.Point(12, 50);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProdutos.RowHeadersVisible = false;
            this.dgvProdutos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvProdutos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(1035, 399);
            this.dgvProdutos.TabIndex = 30;
            this.dgvProdutos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellDoubleClick);
            // 
            // btnEscluirProd
            // 
            this.btnEscluirProd.BackColor = System.Drawing.Color.Tomato;
            this.btnEscluirProd.FlatAppearance.BorderSize = 0;
            this.btnEscluirProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEscluirProd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscluirProd.ForeColor = System.Drawing.Color.White;
            this.btnEscluirProd.Location = new System.Drawing.Point(264, 7);
            this.btnEscluirProd.Name = "btnEscluirProd";
            this.btnEscluirProd.Size = new System.Drawing.Size(85, 32);
            this.btnEscluirProd.TabIndex = 33;
            this.btnEscluirProd.Text = "Excluir";
            this.btnEscluirProd.UseVisualStyleBackColor = false;
            this.btnEscluirProd.Click += new System.EventHandler(this.btnEscluirProd_Click);
            // 
            // txtPesqProd
            // 
            this.txtPesqProd.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesqProd.Location = new System.Drawing.Point(747, 10);
            this.txtPesqProd.Name = "txtPesqProd";
            this.txtPesqProd.Size = new System.Drawing.Size(210, 26);
            this.txtPesqProd.TabIndex = 34;
            this.txtPesqProd.TextChanged += new System.EventHandler(this.txtPesqProd_TextChanged);
            // 
            // btnNovoProd
            // 
            this.btnNovoProd.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnNovoProd.FlatAppearance.BorderSize = 0;
            this.btnNovoProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoProd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoProd.ForeColor = System.Drawing.Color.White;
            this.btnNovoProd.Location = new System.Drawing.Point(962, 7);
            this.btnNovoProd.Name = "btnNovoProd";
            this.btnNovoProd.Size = new System.Drawing.Size(85, 32);
            this.btnNovoProd.TabIndex = 31;
            this.btnNovoProd.Text = "Adicionar";
            this.btnNovoProd.UseVisualStyleBackColor = false;
            this.btnNovoProd.Click += new System.EventHandler(this.btnNovoProd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::sistema_estoque.Properties.Resources.search;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(931, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // FormListaProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1059, 461);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPesqProd);
            this.Controls.Add(this.btnEscluirProd);
            this.Controls.Add(this.btnNovoProd);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormListaProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Produtos";
            this.Load += new System.EventHandler(this.FormListaProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Button btnNovoProd;
        private System.Windows.Forms.Button btnEscluirProd;
        private System.Windows.Forms.TextBox txtPesqProd;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
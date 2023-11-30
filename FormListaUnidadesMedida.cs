using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_estoque
{
    public partial class FormListaUnidadesMedida : Form
    {
        public string idUMSelected = "";

        public FormListaUnidadesMedida()
        {
            InitializeComponent();
        }

        private void btnNovaUM_Click(object sender, EventArgs e)
        {
            FormCadUnidadeMedida formCadUM = new FormCadUnidadeMedida();
            this.Hide();
            formCadUM.ShowDialog();
        }

        private void dgvUnidadesMedida_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idUMSelected = dgvUnidadesMedida.CurrentRow.Cells[0].Value.ToString();
            FormEditUnidadeMedida formEditUM = new FormEditUnidadeMedida(idUMSelected);
            this.Hide();
            formEditUM.ShowDialog();
        }

        private void FormListaUnidadesMedida_Load(object sender, EventArgs e)
        {
            loadUM();
        }

        private void txtPesqUM_TextChanged(object sender, EventArgs e)
        {
            pesqUM();
        }

        private void loadUM()
        {
            try
            {
                bancodedados banco = new bancodedados();
                SqlConnection con;
                con = banco.abrir_conexao();
                try
                {
                    string query = @"SELECT * FROM vw_pesq_um";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvUnidadesMedida.DataSource = dt;
                    con.Close();
                }
                catch (SqlException msgE)
                {
                    MessageBox.Show("Erro ao carregar dados do banco de dados \n" + msgE.Message);
                }

            }
            catch (SqlException erro)
            {
                MessageBox.Show("Erro ao se conectar no banco de dados \n" + erro.Message);
            }
        }

        private void pesqUM()
        {
            try
            {
                bancodedados banco = new bancodedados();
                SqlConnection con;
                con = banco.abrir_conexao();
                try
                {
                    String strUM = txtPesqUM.Text;
                    string query = @"SELECT * FROM vw_pesq_um WHERE Descrição LIKE '%" + strUM + "%'";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvUnidadesMedida.DataSource = dt;
                    con.Close();
                }
                catch (SqlException msgE)
                {
                    MessageBox.Show("Erro ao carregar dados do banco de dados \n" + msgE.Message);
                }

            }
            catch (SqlException erro)
            {
                MessageBox.Show("Erro ao se conectar no banco de dados \n" + erro.Message);
            }
        }

    }
}

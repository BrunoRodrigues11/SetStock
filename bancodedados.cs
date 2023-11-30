using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace sistema_estoque
{
    class bancodedados
    {
        string server = @"DESKTOP-3268\SQLEXPRESS";
        string database = "dbSetStock";      
        SqlConnection con;

        public SqlConnection abrir_conexao()
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=" + server + ";Initial Catalog= "+ database +";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            con.Open();
            return con;
        }

        public DataTable dql(string sql)
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var con = abrir_conexao();
                var cmd = con.CreateCommand();
                cmd.CommandText = sql;
                da = new SqlDataAdapter(cmd.CommandText, con);
                da.Fill(dt);
                con.Close();
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

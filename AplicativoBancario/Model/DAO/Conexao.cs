using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoBancario.Model.DAO
{
    internal class Conexao
    {
        private SqlConnection conexao = new SqlConnection();

        public Conexao()
        {
            conexao.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=db_bancario;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }

        public SqlConnection Conectar()
        {
            if(conexao.State == System.Data.ConnectionState.Closed)
            {
                conexao.Open();
            }

            return conexao;
        }

        public SqlConnection Desconectar()
        {
            if(conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();
            }

            return conexao;
        }
    }
}

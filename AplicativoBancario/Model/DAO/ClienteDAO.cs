using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoBancario.Model.DAO
{
    internal class ClienteDAO : IDAO<Cliente>
    {
        Conexao conexao = new Conexao();

        SqlCommand comandoSql = new SqlCommand();

        public void Adicionar(Cliente cliente)
        {
            comandoSql.CommandText = "INSERT INTO clientes(nome, cpf) VALUES (@nome, @cpf) ";
            comandoSql.Parameters.AddWithValue("@nome", cliente.Nome);
            comandoSql.Parameters.AddWithValue("@cpf", cliente.Cpf);

            try
            {
                comandoSql.Connection = conexao.Conectar();
                comandoSql.ExecuteNonQuery();
            }
            catch (SqlException e)
            {

            }
            finally
            {
                comandoSql.Connection = conexao.Desconectar();
            }
        }

        public Cliente ConcultarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> ConsultarTodos()
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public Cliente Editar(Cliente cliente)
        {
            throw new NotImplementedException();
        }
    }
}

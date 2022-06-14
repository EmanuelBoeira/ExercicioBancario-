using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoBancario.Model.DAO
{
    internal class ContaPoupancaDAO : IDAO<Conta>
    {
        Conexao conexao = new Conexao();

        SqlCommand comandoSql = new SqlCommand();
        public void Adicionar(Conta conta)
        {
            comandoSql.CommandText = "INSERT INTO contas(agencia, numero, cliente_id, saldo) VALUES (@agencia, @numero, @cliente_id, @saldo) ";
            comandoSql.Parameters.AddWithValue("@agencia", conta.Agencia);
            comandoSql.Parameters.AddWithValue("@numero", conta.Numero);
            comandoSql.Parameters.AddWithValue("@cliente_id", conta.Cliente.Id);
            comandoSql.Parameters.AddWithValue("@saldo", conta.Saldo);
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

        public Conta ConcultarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Conta> ConsultarTodos()
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public Conta Editar(Conta obj)
        {
            throw new NotImplementedException();
        }
    }
}

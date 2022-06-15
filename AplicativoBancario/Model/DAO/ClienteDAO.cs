using System;
using System.Collections.Generic;
using System.Data.SqlClient;

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
                Console.WriteLine(e);
            }
            finally
            {
                comandoSql.Connection = conexao.Desconectar();
            }
        }

        public Cliente ConcultarPorId(int id)
        {
            comandoSql.CommandText = "SELECT * FROM clientes WHERE id = @id";
            comandoSql.Parameters.AddWithValue("@id", id);

            Cliente cliente = new Cliente();

            try
            {
                comandoSql.Connection = conexao.Conectar();

                SqlDataReader leitorBd = comandoSql.ExecuteReader();

                while (leitorBd.Read())
                {       
                    cliente.Id = leitorBd.GetInt32(0);
                    cliente.Nome = leitorBd.GetString(1);
                    cliente.Cpf = leitorBd.GetString(2);
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                comandoSql.Connection = conexao.Desconectar();
            }

            return cliente;
        }

        public List<Cliente> ConsultarTodos()
        {
            comandoSql.CommandText = "SELECT * FROM clientes";

            List<Cliente> clientes = new List<Cliente>();

            try
            {
                comandoSql.Connection = conexao.Conectar();

                SqlDataReader leitorBd = comandoSql.ExecuteReader();

                while (leitorBd.Read())
                {
                    Cliente cliente = new Cliente();

                    cliente.Id = leitorBd.GetInt32(0);
                    cliente.Nome = leitorBd.GetString(1);
                    cliente.Cpf = leitorBd.GetString(2);

                    clientes.Add(cliente);
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                comandoSql.Connection = conexao.Desconectar();
            }

            return clientes;
        }

        public void Deletar(int id)
        {
            comandoSql.CommandText = "DELETE FROM clientes WHERE id = @id";
            comandoSql.Parameters.AddWithValue("@id", id);

            try
            {
                comandoSql.Connection = conexao.Conectar();
                comandoSql.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                comandoSql.Connection = conexao.Desconectar();
            }
        }

        public void Editar(Cliente cliente)
        {
            comandoSql.CommandText = "UPDATE clientes SET nome = @nome, cpf = @cpf WHERE id = @id";
            comandoSql.Parameters.AddWithValue("@nome", cliente.Nome);
            comandoSql.Parameters.AddWithValue("@cpf", cliente.Cpf);
            comandoSql.Parameters.AddWithValue("@id", cliente.Id);

            try
            {
                comandoSql.Connection = conexao.Conectar();
                comandoSql.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                comandoSql.Connection = conexao.Desconectar();
            }
        }
    }
}

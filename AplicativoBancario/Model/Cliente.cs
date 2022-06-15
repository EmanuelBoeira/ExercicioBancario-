using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoBancario.Model
{
    internal class Cliente
    {
        public int Id { get; set; } 
        public string Nome { get; set; }
        public string Cpf { get; set; }

        public Cliente()
        {

        }
        public Cliente(string nome, string cpf)
        {
            this.Nome = nome;
            this.Cpf = cpf;
        }
    }
}

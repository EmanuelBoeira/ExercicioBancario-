using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoBancario.Model
{
    internal class ContaPoupanca : Conta
    {
        public ContaPoupanca(int agencia, int numero, Cliente cliente) : base(agencia, numero, cliente)
        {
            this.Agencia = agencia;
            this.Numero = numero;
            this.Cliente = cliente;
        }

        public ContaPoupanca()
        {
           
        }
    }
}

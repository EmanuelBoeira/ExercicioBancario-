using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoBancario.Model
{
    internal class ContaCorrente : Conta
    {
        public ContaCorrente(int agencia, int numero, Cliente cliente) : base(agencia, numero, cliente)
        {
            this.Agencia = agencia;
            this.Numero = numero;
            this.Cliente = cliente;
        }
    }
}

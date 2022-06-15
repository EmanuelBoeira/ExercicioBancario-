using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoBancario.Model
{
    internal abstract class Conta
    {
        public int Id { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public double Saldo { get; set; }

        public Cliente Cliente { get; set; }

        public Conta()
        {
            
        }

        public Conta(int agencia, int numero, Cliente cliente)
        {
            this.Agencia = agencia;
            this.Numero = numero;
            this.Cliente = cliente;
        }

        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        public void Sacar(double valor)
        {
            if(valor < this.Saldo)
            {
                this.Saldo -= valor;
            }
        }


    }
}

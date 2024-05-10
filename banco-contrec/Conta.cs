using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banco
{
    public class Conta
    {
        // Atributos da conta bancária.
        private int numero;
        private double saldo;

        public double Saldo { get => saldo; set => saldo = value; }
        public int Numero { get => numero; set => numero = value; }

        public Conta(int numero, double saldo)
        {
            this.numero = numero;
            this.Saldo = saldo;
        }

        // Metodos
        public void sacar(double valor)
        {

            if (this.Saldo >= valor) { this.Saldo -= valor; }
        }

        public bool diferente(double valor)
        {
            if (this.Saldo >= valor) {
                this.Saldo -= valor;
                return true;
            } else
            {
                return false;
            }
        }

        public void depositar(double valor)
        {
            this.Saldo += valor;
        }

        public double retornarSaldo()
        {
            return Saldo;
        }

    }
}

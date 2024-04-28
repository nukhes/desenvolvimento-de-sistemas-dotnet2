using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banco
{
    class PFisica : Cliente
    {
        private long cpf;
        private string nome;
        private string rg;
        public long Cpf { get => cpf; set => cpf = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Rg { get => rg; set => rg = value; }

        public PFisica(long cpf, string nome, string rg, string telefone, string endereco, string email)
        {
            this.cpf = cpf;
            this.nome = nome;
            this.rg = rg;
            this.Telefone = telefone;
            this.Endereco = endereco;
            this.Email = email;
        }

        public string alertarDados()
        {
            return ("\nRG: " + this.rg +
                   "\nCPF: " + this.cpf +
                   "\nEnd: " + this.Endereco +
                   "\nFone: " + this.Telefone +
                   "\nEmail: " + this.Email);
        }
    }
}

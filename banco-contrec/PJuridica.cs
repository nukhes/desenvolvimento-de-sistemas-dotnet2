using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banco
{
    class PJuridica : Cliente
    {

        Random rnd = new Random();
        private string razaoSocial;
        private string inscricaoEstadual;
        public long Cnpj { get; set; }
        public string RazaoSocial { get => razaoSocial; set => razaoSocial = value; }
        public string InscricaoEstadual { get => inscricaoEstadual; set => inscricaoEstadual = value; }

        public PJuridica(long cnpj, string razaoSocial, string inscricaoEstadual, string telefone, string endereco, string email)
        {
            this.Cnpj = cnpj;
            this.RazaoSocial = razaoSocial;
            this.InscricaoEstadual = inscricaoEstadual;
            this.Telefone = telefone;
            this.Endereco = endereco;
            this.Email = email;
        }

        public string alertarDados()
        {
            return ("\nInscrição Estadual: " + this.InscricaoEstadual +
                   "\nCNPJ: " + this.Cnpj +
                   "\nRazao Social: " + this.RazaoSocial +
                   "\nEndereco: " + this.Endereco +
                   "\nFone: " + this.Telefone +
                   "\nEmail: " + this.Email);
        }
        public void CadastrarJuridica(long cpf, string nome, string rg, string endereco, string telefone, string email)
        {
            this.Cnpj = cpf;
            this.RazaoSocial = nome;
            this.InscricaoEstadual = rg;
            this.Telefone = telefone;
            this.Endereco = endereco;
            this.Email = email;
            this.Conta = new Conta(rnd.Next(1,9999), 1100);
        }

    }
}

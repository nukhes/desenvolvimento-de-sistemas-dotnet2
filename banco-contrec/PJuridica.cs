using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banco
{
    class PJuridica : Cliente
    {
        private long cnpj;
        private string razaoSocial;
        private string inscricaoEstadual;
        public long Cnpj { get => cnpj; set => cnpj = value; }
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
            return ("\nInscrição Estadual: " + this.inscricaoEstadual +
                   "\nCNPJ: " + this.cnpj +
                   "\nRazao Social: " + this.RazaoSocial +
                   "\nEndereco: " + this.Endereco +
                   "\nFone: " + this.Telefone +
                   "\nEmail: " + this.Email);
        }
    }
}

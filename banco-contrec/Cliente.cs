using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banco
{

    class Cliente
    {
        protected string telefone;
        protected string endereco;
        protected string email;
        protected Conta conta;

        public string Telefone { get => telefone; set => telefone = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Email { get => email; set => email = value; }
        public Conta Conta { get => conta; set => conta = value; }

    
    }
}
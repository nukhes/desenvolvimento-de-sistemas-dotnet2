using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banco
{
    public partial class Form1 : Form
    {

            
            PFisica pedro = new PFisica(21457182421, "pedro", "12345278-9", "Jardim das Barras 168", "555195339403", "barras.lover@protonmail.com");
            Conta c = new Conta(1, 100.00);

            PJuridica naruto = new PJuridica(51256405000126, "naruto ltda", "aabbbbcccccc", "16 9999-999999", "japao, xique-xique, BRASIL", "pedroalves1a@sac.com");

            public Form1()
            {
                InitializeComponent();
            }


            private void BtnMostrarDados_Click(object sender, EventArgs e)
            {

                c.titular = pedro;

                MessageBox.Show("Nome: " + c.titular.Nome + "\n Saldo: " + c.retornarSaldo());
                MessageBox.Show(pedro.alertarDados());
            }


            private void BtnSacar_Click(object sender, EventArgs e)
            {
                c.sacar(10.0);
                MessageBox.Show("Saldo atual após saque: " + c.retornarSaldo());
            }

            private void BtnSacarCom_Click(object sender, EventArgs e)
            {

                if (c.diferente(10.0))
                {
                    MessageBox.Show("Saque realizado com sucesso");
                }
                else
                {
                    MessageBox.Show("Saldo insuficiente");
                }
            }

            private void BtnDepositar_Click(object sender, EventArgs e)
            {
                c.depositar(100.0);
                MessageBox.Show("Saldo atual após depósito: " + c.retornarSaldo());
            }

        private void BtnPJuridica_Click(object sender, EventArgs e)
        {
                MessageBox.Show(naruto.alertarDados());
        }
    }
}

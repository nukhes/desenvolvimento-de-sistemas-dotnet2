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
    public partial class Sacar : Form
    {
        public Conta conta;
        public Sacar(Conta conta)
        {
            InitializeComponent();
            this.conta = conta;
        }

        
        private void BtnSacar_Click(object sender, EventArgs e)
        {
            try
            {
                conta.sacar(222);
                MessageBox.Show("Saque efetuado com sucesso, saldo final: R$" + conta.Saldo);
            } catch (Exception)
            {
                MessageBox.Show("Saque não foi possível.");
            }
        }
    }
}

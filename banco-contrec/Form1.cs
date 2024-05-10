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

        public Conta contaAtual;

        public Form1()
        {
            InitializeComponent();
        }



        private void BtnMostrarDados_Click(object sender, EventArgs e)
        {

        }


        private void BtnSacar_Click(object sender, EventArgs e)
        {
            Sacar formulario = new Sacar(contaAtual);
            formulario.Show();
        }

        private void BtnSacarCom_Click(object sender, EventArgs e)
        {

        }

        private void BtnDepositar_Click(object sender, EventArgs e)
        {

        }


        private void BtnPFisica_Click(object sender, EventArgs e)
        {
            CadastroPFisica formulario = new CadastroPFisica();
            formulario.Show();
            contaAtual = formulario.RetornarConta();
        }

        private void BtnPJuridica_Click_1(object sender, EventArgs e)
        {
            CadastroPJurudica formulario = new CadastroPJurudica();
            formulario.Show();
            contaAtual = formulario.RetornarConta();
        }

        private void BtnMostrarDadosPJ_Click(object sender, EventArgs e)
        {

        }

        private void BtnSacarPJ_Click(object sender, EventArgs e)
        {

        }

        private void BtnSacarComPJ_Click(object sender, EventArgs e)
        {

        }

        private void BtnDepositarPJ_Click(object sender, EventArgs e)
        {

        }
    }
}

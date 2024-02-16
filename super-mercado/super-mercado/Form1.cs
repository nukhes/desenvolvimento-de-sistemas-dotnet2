using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace super_mercado
{
    public partial class superMercado : Form
    {
        public superMercado()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            string nome, observacoes;
            decimal preco;
            int quantidade, lote, codigoBarras;

            nome = txtNomeProduto.ToString();
            observacoes = txtObs.ToString();
            preco = Convert.ToDecimal(txtPreco.Text);
            quantidade = Convert.ToInt32(txtQuantidade.Text);
            lote = Convert.ToInt32(txtLote.Text);
            codigoBarras = Convert.ToInt32(txtCodigoDeBarras.Text);

            MessageBox.Show("Cadastrado com Sucesso!");
        }

        private void SuperMercado_Load(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}

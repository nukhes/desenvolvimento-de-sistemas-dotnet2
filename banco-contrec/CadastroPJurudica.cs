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
    public partial class CadastroPJurudica : Form
    {
        PJuridica pj = new PJuridica(0, "", "", "", "", "");
        public CadastroPJurudica()
        {
            InitializeComponent();
            btnDadosPJ.Enabled = false;
        }

        private void BtnCadastrarPJuridica_Click(object sender, EventArgs e)
        {
            long cnpj;
            string razao, estadual, endereco, telefone, email;
            void LimparCampos()
            {
                txtCnpj.Text = "";
                txtInscricaoEstadual.Text = "";
                txtRazaoSocial.Text = "";
                txtEmail.Text = "";
                txtEnd.Text = "";
                txtTel.Text = "";
            }
            void InserirValores()
            {
                cnpj = Convert.ToInt64(txtCnpj.Text);
                estadual = txtInscricaoEstadual.Text;
                razao = txtRazaoSocial.Text;
                endereco = txtEnd.Text;
                telefone = txtTel.Text;
                email = txtEmail.Text;
            }

            try
            {

                InserirValores();
                LimparCampos();

                pj.CadastrarJuridica(cnpj, razao, endereco, estadual, telefone, email);
                MessageBox.Show("Cadastrado com sucesso!");

                btnDadosPJ.Enabled = true;

            }
            catch (Exception)
            {
                MessageBox.Show("Erro");
            }
        }

        private void BtnDadosPJ_Click(object sender, EventArgs e)
        {
            MessageBox.Show(pj.alertarDados());
        }

        public Conta RetornarConta()
        {
            return pj.Conta;
        }

    }
}

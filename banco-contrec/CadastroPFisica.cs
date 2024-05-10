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
    public partial class CadastroPFisica : Form
    {
        PFisica pf = new PFisica(0, "", "", "", "", "");
        Random rnd = new Random();

        public CadastroPFisica()
        {
            InitializeComponent();
            btnDadosPF.Enabled = false;
        }

        

        private void BtnCadastrarPFisica_Click(object sender, EventArgs e)
        {
            long cpf;
            string nome, rg, endereco, telefone, email;
            void LimparCampos()
            {
                txtCpf.Text = "";
                txtRg.Text = "";
                txtNome.Text = "";
                txtEmail.Text = "";
                txtEnd.Text = "";
                txtTel.Text = "";
            }
            void InserirValores()
            {
                cpf = Convert.ToInt64(txtCpf.Text);
                rg = txtRg.Text;
                nome = txtNome.Text;
                endereco = txtEnd.Text;
                telefone = txtTel.Text;
                email = txtEmail.Text;
            }

            try
            {

                InserirValores();
                LimparCampos();

                pf.CadastrarFisica(cpf, nome, endereco, rg, telefone, email);
                MessageBox.Show("Cadastrado com sucesso!");

                btnDadosPF.Enabled = true;
            } catch (Exception)
            {
                MessageBox.Show("Erro");
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnDadosPF_Click(object sender, EventArgs e)
        {
            MessageBox.Show(pf.alertarDados());
        }

        public Conta RetornarConta()
        {
            return pf.Conta;
        }

    }
}

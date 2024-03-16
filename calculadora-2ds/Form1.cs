using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using NCalc;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora_2ds
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InserirCampo(string n)
        {
            //txtCampo.Text += n.ToString();

            switch (n)
            {
                case "0":
                    txtCampo.Text += "0";
                    break;
                case "1":
                    txtCampo.Text += "1";
                    break;
                case "2":
                    txtCampo.Text += "2";
                    break;
                case "3":
                    txtCampo.Text += "3";
                    break;
                case "4":
                    txtCampo.Text += "4";
                    break;
                case "5":
                    txtCampo.Text += "5";
                    break;
                case "6":
                    txtCampo.Text += "6";
                    break;
                case "7":
                    txtCampo.Text += "7";
                    break;
                case "8":
                    txtCampo.Text += "8";
                    break;
                case "9":
                    txtCampo.Text += "9";
                    break;
                case "+":
                    txtCampo.Text += "+";
                    break;
                case "-":
                    txtCampo.Text += "-";
                    break;
                case "*":
                    txtCampo.Text += "*";
                    break;
                case "/":
                    txtCampo.Text += "/";
                    break;
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtCampo.Text = "";
            lblResultado.Text = "Resultado";
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            InserirCampo("1");
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            InserirCampo("2");
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            InserirCampo("3");
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            InserirCampo("4");
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            InserirCampo("5");
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            InserirCampo("6");
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            InserirCampo("7");
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            InserirCampo("8");
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            InserirCampo("9");
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            InserirCampo("0");
        }

        private void BtnSoma_Click(object sender, EventArgs e)
        {
            InserirCampo("+");
        }

        private void BtnSubtracao_Click(object sender, EventArgs e)
        {
            InserirCampo("-");
        }

        private void BtnMultiplicacao_Click(object sender, EventArgs e)
        {
            InserirCampo("*");
        }

        private void BtnDivisao_Click(object sender, EventArgs e)
        {
            InserirCampo("/");
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                var expressao = new Expression(txtCampo.Text);
                lblResultado.Text = expressao.Evaluate().ToString();
                txtCampo.Text = "";
            } catch (Exception)
            {
                lblResultado.Text = "Insira um valor";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

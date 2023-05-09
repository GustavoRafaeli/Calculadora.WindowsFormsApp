using System.Globalization;

namespace Calculadora.WinApp
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0;
        decimal valor2 = 0;
        string operacao = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtCampo.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtCampo.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtCampo.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtCampo.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtCampo.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtCampo.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtCampo.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtCampo.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtCampo.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtCampo.Text += "0";
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            txtCampo.Text += ".";
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            if (txtCampo.Text != "")
            {
                valor1 = decimal.Parse(txtCampo.Text, CultureInfo.InvariantCulture);
                txtCampo.Text = "";
                operacao = "+";
                lblSinal.Text = "+";
            }
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            if (txtCampo.Text != "")
            {
                valor1 = decimal.Parse(txtCampo.Text, CultureInfo.InvariantCulture);
                txtCampo.Text = "";
                operacao = "-";
                lblSinal.Text = "-";
            }
        }
        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (txtCampo.Text != "")
            {
                valor1 = decimal.Parse(txtCampo.Text, CultureInfo.InvariantCulture);
                txtCampo.Text = "";
                operacao = "/";
                lblSinal.Text = "/";
            }
        }
        private void btnMult_Click(object sender, EventArgs e)
        {
            if (txtCampo.Text != "")
            {
                valor1 = decimal.Parse(txtCampo.Text, CultureInfo.InvariantCulture);
                txtCampo.Text = "";
                operacao = "x";
                lblSinal.Text = "x";
            }
        }
        private void btnIgual_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txtCampo.Text, CultureInfo.InvariantCulture);

            switch (operacao)
            {
                case "+": txtCampo.Text = Convert.ToString(valor1 + valor2); break;
                case "-": txtCampo.Text = Convert.ToString(valor1 - valor2); break;
                case "x": txtCampo.Text = Convert.ToString(valor1 * valor2); break;
                case "/": txtCampo.Text = Convert.ToString(valor1 / valor2); break;
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtCampo.Text = "";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtCampo.Text = "";
            valor1 = 0;
            valor2 = 0;
            lblSinal.Text = "";
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Simples
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }
        private string Resultado(double valor1, double valor2)
        {
            double soma, multiplica, divide, subtrai;
            valor1 = Convert.ToDouble(textBox1.Text);
            valor2 = Convert.ToDouble(textBox2.Text);
            soma = valor1 + valor2;
            multiplica = valor1 * valor2;
            divide = valor1 / valor2;
            subtrai = valor1 - valor2;

            if (comboBoxescolher.Text == "Somar")
            {
                return soma.ToString();
            }
            if (comboBoxescolher.Text == "Multiplicar")
            {
                return multiplica.ToString();
            }
            if (comboBoxescolher.Text == "Dividir")
            {
                try
                {
                    if (valor2 == 0)
                    {
                        throw new DivideByZeroException("Não é permitida a divisão por zero.");
                    }
                }
                catch (DivideByZeroException ex)
                {
                    MessageBox.Show(ex.Message, "Erro de cálculo");
                }

                return divide.ToString();
            }
                
            
            if (comboBoxescolher.Text == "Subtrair")
            {
                return subtrai.ToString();
            }
            else
                return "";

        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double valor1, valor2;

            if (!Double.TryParse(textBox1.Text, out valor1))
            {
                MessageBox.Show("O primeiro número não é válido. Insira um número válido.", "Erro de validação");
                return;
            }

            if (!Double.TryParse(textBox2.Text, out valor2))
            {
                MessageBox.Show("O segundo número não é válido. Insira um número válido.", "Erro de validação");
                return;
            }
            lblTotal.Text = Resultado(0, 0).ToString();
        }
    }
}

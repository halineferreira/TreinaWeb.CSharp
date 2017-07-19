using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstudoDelegates
{
    public partial class FormCalculadoraDelegates : Form
    {
        private delegate int ExecutarOperação(int num1, int num2);
        private ExecutarOperação minhaOperacao;

        public FormCalculadoraDelegates()
        {
            InitializeComponent();
        }

        private void FormCalculadoraDelegates_Load(object sender, EventArgs e)
        {

        }
        private int Calcular()
        {
            int num1 = Convert.ToInt32(txbNum1.Text);
            int num2 = Convert.ToInt32(txbNum2.Text);
            return minhaOperacao(num1, num2);
        }

        private int Somar(int num1, int num2)
        {
            return num1 + num2;
        }
        private int Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }
        private int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }
        private int Dividir(int num1, int num2)
        {
            return num1 / num2;
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            minhaOperacao = new ExecutarOperação(Somar);
            txbResultado.Text = Calcular().ToString();
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            minhaOperacao = new ExecutarOperação(Subtrair);
            txbResultado.Text = Calcular().ToString();
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            minhaOperacao = new ExecutarOperação(Multiplicar);
            txbResultado.Text = Calcular().ToString();
        }
        private void btnDivisao_Click(object sender, EventArgs e)
        {
            minhaOperacao = new ExecutarOperação(Dividir);
            txbResultado.Text = Calcular().ToString();
        }
    }
}

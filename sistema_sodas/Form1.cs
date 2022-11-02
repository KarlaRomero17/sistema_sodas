using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_sodas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double precio = 0.55;
            double total;
            double valor1;
            string agotado;
            valor1 = double.Parse(textBox1.Text);
            if (valor1 > precio)
            {
                total = valor1 - precio;
                textBox2.Text = total.ToString();
                agotado = "Venta realizada";
                textBox3.Text = agotado.ToString();
            }
            else {
                agotado = "Saldo insuficiente";
                textBox3.Text = agotado.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            double precio = 0.55;
            double total;
            double valor1;
            string agotado;
            valor1 = double.Parse(textBox1.Text);
            if (valor1 > precio)
            {
                total = valor1 - precio;
                textBox2.Text = total.ToString();
                agotado = "Venta realizada";
                textBox3.Text = agotado.ToString();
            }
            else
            {
                agotado = "Saldo insuficiente";
                textBox3.Text = agotado.ToString();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            double precio = 1.00;
            double total;
            double valor1;
            string agotado;
            valor1 = double.Parse(textBox1.Text);
            if (valor1 > precio)
            {
                total = valor1 - precio;
                textBox2.Text = total.ToString();
                agotado = "Venta realizada";
                textBox3.Text = agotado.ToString();
            }
            else
            {
                agotado = "Saldo insuficiente";
                textBox3.Text = agotado.ToString();
            }
        }
    }
}

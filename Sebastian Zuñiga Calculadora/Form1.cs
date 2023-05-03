using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sebastian_Zuñiga_Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double valor1, valor2, resultado;
        char operador;
        
        //numeros
        private void btn1_Click(object sender, EventArgs e)
        {
            Resultado.Text += btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Resultado.Text += btn2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Resultado.Text += button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Resultado.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Resultado.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Resultado.Text += button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Resultado.Text += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Resultado.Text += button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Resultado.Text += button9.Text;
        }
        //tecla de borrar de 1 en 1
        private void button1_Click(object sender, EventArgs e)
        {
            string labelText = Resultado.Text;

            if (labelText.Length > 0)
            {
                labelText = labelText.Substring(0, labelText.Length - 1);
            }

            Resultado.Text = labelText;
        }

        //tecla de borrar todo 

        private void button2_Click(object sender, EventArgs e)
        {
            Resultado.Text = " ";
            operacion.Text = "";
        }

      

        //suma
        private void button10_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(Resultado.Text);
            operador = '+';
            operacion.Text += Resultado.Text + "+" ;
            Resultado.Text = "";
      

        }
        //multiplicacion
        private void multiplicar_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(Resultado.Text);
            operador = '*';
            operacion.Text += Resultado.Text + "*";
            Resultado.Text = "";
        }
        //division
        private void division_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(Resultado.Text);
            operador = '/';
            operacion.Text += Resultado.Text + "/";
            Resultado.Text = "";
        }
        //mod
        private void mod_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(Resultado.Text);
            operador = '%';
            operacion.Text += Resultado.Text + "%";
            Resultado.Text = "";
        }
        // raiz cuadrada
        private void raiz_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(Resultado.Text);
            operacion.Text += Resultado.Text + "√";
            resultado = Math.Sqrt(valor1);
            Resultado.Text = resultado.ToString() ;
        }

        //resta
        private void resta_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(Resultado.Text);
            operador = '-';
            operacion.Text += Resultado.Text + "-";
            Resultado.Text = "";
        }

        //igual 
        private void igual_Click(object sender, EventArgs e)

        {
            valor2 = double.Parse(Resultado.Text);
            operacion.Text += Resultado.Text;
            switch (operador)
            {
                case '+':
                    resultado = valor1 + valor2;
                    break;

                case '-':
                    resultado = valor1 - valor2;
                    break;

                case '*':
                    resultado = valor1 * valor2;
                    break;

                case '/':
                    resultado = valor1 / valor2;
                    break;

                case '%':
                    resultado = valor1 % valor2;
                    break;
            }
            Resultado.Text = resultado.ToString();
        }
    }
}

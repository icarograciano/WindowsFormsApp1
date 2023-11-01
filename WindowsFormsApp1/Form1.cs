using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string resultado = ""; // Esta variável conterá o resultado

            if (checkBox1.Checked)
            {
                resultado += "a) Valores ímpares de 0 a 40:\n";
                for (int i = 0; i <= 40; i++)
                {
                    if (i % 2 != 0)
                    {
                        resultado += i + ", ";
                    }
                }
                resultado = resultado.TrimEnd(',', ' ') + "\n\n";
            }

            if (checkBox2.Checked)
            {
                int somaB = 0;
                for (int i = 1; i <= 100; i++)
                {
                    somaB += i;
                }
                resultado += "b) Soma dos 100 primeiros números inteiros: " + somaB + "\n\n";
            }

            if (checkBox3.Checked)
            {
                resultado += "c) Números divisíveis por 4 menores que 40:\n";
                for (int i = 1; i < 40; i++)
                {
                    if (i % 4 == 0)
                    {
                        resultado += i + ", ";
                    }
                }
                resultado = resultado.TrimEnd(',', ' ') + "\n\n";
            }

            if (checkBox4.Checked)
            {
                resultado += "d) Quadrados dos números de 15 a 200:\n";
                for (int i = 15; i <= 200; i++)
                {
                    resultado += (i * i) + ", ";
                    if (i % 10 == 4) // Adiciona uma quebra de linha a cada 10 números
                    {
                        resultado += "\n";
                    }
                }
                resultado = resultado.TrimEnd(',', ' ') + "\n\n";
            }

            if (checkBox5.Checked)
            {
                int somaE = 0;
                for (int i = 2; i <= 50; i += 2)
                {
                    somaE += i;
                }
                resultado += "e) Soma dos valores pares de 1 a 50: " + somaE + "\n\n";
            }

            // Atualize a label2 com o resultado
            label2.Text = resultado;
        }


    }
}

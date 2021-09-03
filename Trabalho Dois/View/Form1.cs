using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho_Dois.Control;

namespace Trabalho_Dois
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddBotao(2, button1, "a", "d", "");
            AddBotao(2, button2, "e", "f", "");
            AddBotao(2, button3, "c", "b", "");
            AddBotao(2, button4, "g", "i", "u");
            AddBotao(2, button5, "h", "j", "v");
            AddBotao(2, button6, "k", "l", "");
            AddBotao(2, button7, "m", "o", "q");
            AddBotao(2, button8, "n", "t", "p");
            AddBotao(2, button9, "r", "s", "z");
        }
        public static void AddBotao(int quant, Button btn, string letra1, string letra2, string letra3)
        {
            Random ran = new Random();
            int a;
            if (quant == 2)
            {
                a = ran.Next(1, 3);
                if (a == 1)
                {
                    btn.Text = letra1;
                }
                else
                {
                    btn.Text = letra2;
                }
            }
            else if(quant == 3)
            {
                a = ran.Next(1, 4);
                if (a == 1)
                {
                    btn.Text = letra1;
                }
                else if(a == 2)
                {
                    btn.Text = letra2;
                }
                else
                {
                    btn.Text = letra3;
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int certoOuErrado = Controller.Buscar(txtPalavra.Text, Convert.ToChar(button1.Text), Convert.ToChar(button2.Text), Convert.ToChar(button3.Text), Convert.ToChar(button4.Text), Convert.ToChar(button6.Text), Convert.ToChar(button7.Text), Convert.ToChar(button8.Text), Convert.ToChar(button9.Text));
            if (certoOuErrado == 1)
            {
                MessageBox.Show("Palavra válida!");
            }
            else if (certoOuErrado == -2)
            {
                MessageBox.Show("Letras repetidas!");
            }
            else
            {
                MessageBox.Show("Palavra inválida!");
            }
        }
    }
}

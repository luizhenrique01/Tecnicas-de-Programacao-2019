using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade4_AA_34
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Random x = new Random();

            int cont = 1;
            double num = 1, soma = 0;

            do
            {
                num = x.Next(1, 100);
                if (num > 0)
                {
                    soma += num;
                }
                ltx_imprimir.Items.Add(num);
                cont++;

            } while (cont <= 100);
            {
                ltx_imprimir.Items.Add("O valor da soma é: " + soma);
            }


        }
    }
}

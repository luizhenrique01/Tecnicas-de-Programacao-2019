using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade10_AA_34
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl_maior_Click(object sender, EventArgs e)
        {

        }

        private void lbl_menor_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random x = new Random();
            int num = 0, cont = 0, maior = 0, menor = 0;
            double media = 0;
            
            while(cont < 15)
            {
                num = x.Next();

                if(maior < num)
                {
                    maior = num;
                } else if(menor == 0) {
                    menor = num;
                } else if (menor > num)
                {
                    menor = num;
                }

                media += num;
                cont++;
            }

            lbl_maior.Text = maior.ToString("0.00");
            lbl_menor.Text = menor.ToString("0.00");
            lbl_media.Text = media.ToString("0.00");


        }
    }
}

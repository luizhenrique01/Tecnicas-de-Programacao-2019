using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace revisao_intermediaria_34
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            Random x = new Random();
            double num, cont = 0, soma = 0, media = 0, maior = double.MinValue, menor = double.MaxValue;
            double cont500 = 0, porc = 0, cont1500 = 0;


            for (cont = 0; cont < 200; cont++)
            {
                num = x.Next(3501);
                ltx_imprimir.Items.Add(num);
                soma += num;
                
                if (num > maior)
                {
                    maior = num;
                }

                if (num < menor)
                {
                    menor = num;
                }

                if (num < 500)
                {
                    cont500++;
                }
            }

            media = soma / cont;
            porc = cont500 / cont * 100;
            lbl_soma.Text = "Soma: " + soma;
            lbl_media.Text = "Média: " + media.ToString("0.00");
            lbl_maior.Text = "Maior: " + maior;
            lbl_menor.Text = "Menor: " + menor;
            lbl_porc.Text = "% numreros < 500" + porc.ToString("0.00") + "%";
            lbl_quantidade.Text = "Qtd. numeros > 1500 " + cont1500;




        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade3_AA_34
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_While_Click(object sender, EventArgs e)
        {
            int numero = 0, cont = 0, maior =int.MinValue, menor = int.MaxValue;
            Random x = new Random();


            while (cont <= 10)
            {
                numero = x.Next(0, 10);
                

                if (numero > maior)
                {
                    maior = numero;
                }

                if (numero < menor)
                {
                    menor = numero;
                }

                ltx_Imprimir.Items.Add(numero);
                cont++;


            }
            ltx_Imprimir.Items.Add("O valor maximo é: " + maior);

            ltx_Imprimir.Items.Add("O menor valor é: " + menor);
        }








        }
    }

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace While2_34
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_While_Click(object sender, EventArgs e)
        {
            int numero = 0, total = 1, pessoa = 0;
            Random idade = new Random();

            while (total < 15)
            {
                numero = idade.Next(0,100);
               if (numero == 18)
                {
                    pessoa++;
                }

                ltx_Imprimir.Items.Add(numero);
                
                total++;


            }
                ltx_Imprimir.Items.Add("De um total de " + total + " pessoas, " + pessoa + " tem 18 anos");
            








        }
    }
}

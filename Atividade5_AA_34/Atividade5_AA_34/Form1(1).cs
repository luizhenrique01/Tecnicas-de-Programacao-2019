using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade5_AA_34
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcule_Click(object sender, EventArgs e)
        {
            Random x = new Random();

            int cont = 1;
            double num = 1, multi = 1;

            do
            {
                num = x.Next(1, 10);
                if (num % 2 == 1)
                {
                    muti += num;
                    ltx_imprimir.Items.Add(num);
                    cont++;
                }
                else
                {
                    ltx_imprimir.Items.Add("--");
                    cont++;
                }


            } while (cont <= int.Parse(txt_cont.Text));
            {
                ltx_imprimir.Items.Add("O valor da multiplicação é: " + );
            }
        }
    }
}

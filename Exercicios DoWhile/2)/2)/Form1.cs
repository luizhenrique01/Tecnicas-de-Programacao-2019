using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_While_Click(object sender, EventArgs e)
        {
            int cont = 0;
            Random x = new Random();
            int num = 0, maior = 0;

            do
            {
                num = x.Next(1000, 10000);
                if (num > maior)
                {
                    maior = num;
                }
                ltx_Imprimir.Items.Add(num);
                cont++;
            } while (cont < 30);
            ltx_Imprimir.Items.Add("O maior número e: " + maior);

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_
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
            int num = 0, menor = int.MaxValue;

            do
            {
                num = x.Next(0, 50);
                if (num < menor)
                {
                    menor = num;
                }
                ltx_Imprimir.Items.Add(num);
                cont++;
            } while (cont < 5);
            ltx_Imprimir.Items.Add("O menor numero e: " + menor);







        }
    }
}

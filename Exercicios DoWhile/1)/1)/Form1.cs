using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_While_Click(object sender, EventArgs e)
        {
            int cont=1;
            Random x = new Random();
            int num=0, total=0,media =0;

            do
            {
                num = x.Next(0, 101);
                total = total + num;
                cont++;
                ltx_Imprimir.Items.Add(total);
            } while (cont < 20);
            media = total / cont;
            ltx_Imprimir.Items.Add("A media dos numeros e: " + media);







        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace while1_34
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_While_Click(object sender, EventArgs e)
        {
            
            int num = 1000, soma = 0;

            while (num <= 2000)
            {
                if(num % 11 == 5)
                {
                    ltx_Imprimir.Items.Add(num + " tem o resto de divisao 5");
                } 
                ltx_Imprimir.Items.Add(num);
                num++;
            }

            
        }
    }
}

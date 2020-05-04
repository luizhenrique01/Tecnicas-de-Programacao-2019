using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace While3_34
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_While_Click(object sender, EventArgs e)
        {
            int cont = 7 , numero = 0;

            while (cont <= 70)
            {
                ltx_Imprimir.Items.Add(cont);

                cont += 7;

            }







        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_2_AA_34
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_While_Click(object sender, EventArgs e)
        {
            int numero = 11;

            while(numero <= 101)
            {
                numero += 10;
                
                ltx_Imprimir.Items.Add(numero);

            }









        }
    }
}

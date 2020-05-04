using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade7_AA_34
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcule_Click(object sender, EventArgs e)
        {

            Random n = new Random();

            int cont = 1;
            double num = 1, multiplica = 1,x=1;
            while (-1 != x){
                x = n.Next(-1, 100);
                ltx_imprimir.Items.Add(x);
                cont++;
            }

            ltx_imprimir.Items.Add("O numero foi repetido: " + cont);


        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_AA_34
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int numero=0, cont = 2;


            while (cont <= 50)
            {
                numero = cont;

                if(numero % 2 == 0) {
                    ltx_Imprimir.Items.Add(numero);
                }
                cont++;
            }

            














        }
    }
}

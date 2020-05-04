using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade8_AA_34
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcule_Click(object sender, EventArgs e)
        {
            int numero1 = 0, numero2 = 1, numero3 = 1, cont = 1;

            for(int valid = int.Parse(txt_numero.Text); cont <= valid; cont++)
            {
                ltx_imprimir.Items.Add(cont + " O numero: " + numero3);
                numero3 = numero1 + numero2;
                numero1 = numero2;
                numero2 = numero3;


            }




        }
    }
}

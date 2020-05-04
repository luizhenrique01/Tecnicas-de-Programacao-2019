using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade9_AA_34
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcule_Click(object sender, EventArgs e)
        {
            double fatorizador = 1, n = double.Parse(txt_numero.Text);

            for (double cont =1; cont <= n; cont++)
            {
                fatorizador *= cont;
            }

            ltx_imprimir.Items.Add("O fatorial de " + n + "e: " + fatorizador);


        }
    }
}

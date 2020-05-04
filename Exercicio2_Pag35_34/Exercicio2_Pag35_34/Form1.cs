using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio2_Pag35_34
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double valortotal = 0,horas = 0;
            char classe;

            classe = char.Parse(cbx_classe.Text);
            horas = double.Parse(txt_horas.Text);

            switch (classe)
            {
                case 'A':
                valortotal = horas * 8;
                break;

                case 'B':
                    valortotal = horas * 12;
                    break;

                case 'C':
                    valortotal = horas * 17;
                    break;

            }

            lbl_valor.Text = ("Salario de: R$ " + valortotal);






        }
    }
}

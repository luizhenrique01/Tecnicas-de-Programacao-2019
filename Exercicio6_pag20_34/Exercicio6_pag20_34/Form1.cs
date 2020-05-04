using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio6_pag20_34
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_caucle_Click(object sender, EventArgs e)
        {
            double valorKwh, consumo, total;
            valorKwh = double.Parse(txt_kwh.Text);
            consumo = double.Parse(txt_quantia.Text);
            total = valorKwh * consumo * 1.035;

            MessageBox.Show("O valor a pagar é:" + total);




        }
    }
}

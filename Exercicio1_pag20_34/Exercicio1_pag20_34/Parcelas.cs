using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio1_pag20_34
{
    public partial class Parcelas : Form
    {
        public Parcelas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valor_parcelas, compra, entrada, parcelas;
            compra = double.Parse(txt_compra.Text);
            entrada = double.Parse(txt_entrada.Text);
            parcelas = double.Parse(txt_parcela.Text);

            valor_parcelas = (compra - entrada) / parcelas;

            MessageBox.Show("O valor de cada parcela é: " + valor_parcelas);





        }
    }
}

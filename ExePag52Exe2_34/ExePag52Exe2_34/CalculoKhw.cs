using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExePag52Exe2_34
{
    public partial class CalculoKhw : Form
    {
        public CalculoKhw()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_calcule_Click(object sender, EventArgs e)
        {
            double total, kwh, kwhmes, totalcomercial, totalindustrial;

            kwh = double.Parse(txt_kwh.Text);
            kwhmes = double.Parse(txt_kwhmes.Text);

            total = kwh * kwhmes;
            totalcomercial = total * 0.95;
            totalindustrial = total * 0.97;



            if (cbx_cosumido.Text == "Residencial")
            {
                MessageBox.Show("O valor Residencial a ser pago e: R$" + total);
            } else if (cbx_cosumido.Text == "Comercial")
            {
                MessageBox.Show("O valor Comercial a ser pago e: R$" + totalcomercial);
            } else if (cbx_cosumido.Text == "Industrial")
            {
                MessageBox.Show("O valor Industrial a ser pago e: R$" + totalindustrial);


            }





        }

        private void CalculoKhw_Load(object sender, EventArgs e)
        {

        }
    }
}

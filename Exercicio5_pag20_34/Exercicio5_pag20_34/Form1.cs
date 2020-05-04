using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio5_pag20_34
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {

            double imc, altura, peso;
            altura = double.Parse(txt_altura.Text);
            peso = double.Parse(txt_peso.Text);


            imc = peso / (altura * altura);

            MessageBox.Show("O IMC: " + imc);



        }
    }
}

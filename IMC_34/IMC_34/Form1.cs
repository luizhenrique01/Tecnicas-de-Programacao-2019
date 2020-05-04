using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC_34
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double altura, peso, total;
            altura = double.Parse(txt_altura.Text);
            peso = double.Parse(txt_peso.Text);
            total = peso / (altura * altura);

            /*Regras:
            IMC 0 ate 16 - Magreza
IMC 16 ate 18.5 - Abaixo do Peso
IMC 18.5 ate 25 - Peso ideal
IMC 25 ate 30 - Sobrepeso
IMC acima de 30 - Obesidade*/


            if (total < 16)
            {
                MessageBox.Show("Seu imc e de "+(total.ToString("0.00"))+ ", esse IMC e considerado Magreza");
            } else if(total >= 16 && total < 18.5) {
                MessageBox.Show("Seu imc e de " + (total.ToString("0.00"))+ ", esse IMC e considerado Abaixo do peso");
            } else if(total >= 18.5 && total < 25)
            {
                MessageBox.Show("Seu imc e de "+(total.ToString("0.00"))+", esse IMC e considerado Peso ideal");
            } else if(total >=25 && total < 30)
            {
                MessageBox.Show("Seu imc e de "+(total.ToString("0.00"))+", esse IMC e considerado Sobrepeso ");
            }
            else if (total > 30)
            {
                MessageBox.Show("Seu imc e de " + (total.ToString("0.00")) + ", esse IMC e considerado Obesidade ");
            }




        }
    }
}

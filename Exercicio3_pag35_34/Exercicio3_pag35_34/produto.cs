using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio3_pag35_34
{
    public partial class frm_produto : Form
    {
        public frm_produto()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double total=0, quantidade;
            string classes, erro;

            quantidade = double.Parse(txt_quantidade.Text);
            classes = cbx_codigo.Text;

            switch (classes)
            {
                case "AUTO":

                    total = quantidade * 325;
                break;

                case "MOTO":

                    total = quantidade * 102;
                    break;

                case "BIKE":

                    total = quantidade * 76;
                    break;

                case "KLWE":

                    total = quantidade * 176;
                    break;

                case "WPDD":

                    total = quantidade * 456;
                    break;

                default:

                     MessageBox.Show("O valor da classe e invalido");
                     
                    break;


            }

            lbl_valor.Text = ("O valor dos produtos são: R$" + total);

           
           






        }
    }
}

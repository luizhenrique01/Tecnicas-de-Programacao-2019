using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio4_pag35_34
{
    public partial class frm_horas : Form
    {
        public frm_horas()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            double total = 0, horas, horasextras,totalhoras = 0,inss=0,salarioliquido=0;

            string classes;

            horas = double.Parse(txt_horas.Text);
            horasextras = double.Parse(txt_horasextras.Text);
            classes = cbx_classe.Text;
           
        

            switch (classes)
            {
                case "1":
                    total = (horas * 8);
                    totalhoras = 8 * 1.5;
                    inss = total * 0.11;
                    salarioliquido = total + totalhoras - inss;
                break;

                case "2":
                    total = (horas * 10);
                    totalhoras = 10 * 1.5;
                    inss = total * 0.11;
                    salarioliquido = total + totalhoras - inss;
                    break;


                case "3":
                    total = (horas * 12);
                    totalhoras = 12 * 1.5;
                    inss = total * 0.11;
                    salarioliquido = total + totalhoras - inss;
                    break;

                case "4":
                    total = (horas * 15);
                    totalhoras = 15 * 1.5;
                    inss = total * 0.11;
                    salarioliquido = total + totalhoras - inss;
                    break;

                case "5":
                    total = (horas * 20);
                    totalhoras = 20 * 1.5;
                    inss = total * 0.11;
                    salarioliquido = total + totalhoras - inss;
                    break;
            }

            lbl_bruto.Text = ("O salario bruto é: R$" + total);
            lbl_horaextra.Text = ("O valor da hora extra foi de: R$" + totalhoras);
            lbl_inss.Text = ("O valor descontado pelo INSS foi de: R$" + inss);
            lbl_liquido.Text = ("O valor do salario liquido é: R$" + salarioliquido);


        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeWhile_34
{
    public partial class Calculo_num : Form
    {
        public Calculo_num()
        {
            InitializeComponent();
        }

        private void btn_calcule_Click(object sender, EventArgs e)
        {
            int n1, n2, par=0,impar=1;
            n1 = int.Parse(txt_n1.Text);
            n2 = int.Parse(txt_n2.Text);
           
            if (n1 < n2)
            {
                
                while(n1 <= n2)
                {

                    if (n1 % 2 == 0)
                    {
                        par = n1 + par;
                        ltx_lista.Items.Add(n1);

                    }


                    else
                    {

                        impar = n1 * impar;
                        ltx_lista.Items.Add(n1);

                    }
                    n1++;

                }

                ltx_lista.Items.Add("A soma dos numeros pares são: " + par);
                ltx_lista.Items.Add("A multiplicação dos numeros impar são: " + impar);


            } else
            {
                MessageBox.Show("O numero 2 tem que ser maior que o numero 1");
            }







            }

        private void Calculo_num_Load(object sender, EventArgs e)
        {

        }
    }
    }



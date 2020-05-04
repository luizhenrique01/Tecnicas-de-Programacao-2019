using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabuada_completa
{
    public partial class Tabuada : Form
    {
        public Tabuada()
        {
            InitializeComponent();
        }

        private void btn_While_Click(object sender, EventArgs e)
        {
            int cont1 = 1;

            ltx_Imprimir.Items.Add("Tabuada do 1");

            while (cont1 <= 10)
            {
                ltx_Imprimir.Items.Add(cont1);

                cont1 += 1;

            }
                       
            int cont2 = 2;

            ltx_Imprimir.Items.Add("Tabuada do 2");

            while (cont2 <= 20)
            {
                ltx_Imprimir.Items.Add(cont2);

                cont2 += 2;

            }
            
            int cont3 = 3;

            ltx_Imprimir.Items.Add("Tabuada do 3");

            while (cont3 <= 30)
            {
                ltx_Imprimir.Items.Add(cont3);

                cont3 += 3;

            }
                                          
            int cont4 = 4;

            ltx_Imprimir.Items.Add("Tabuada do 4");

            while (cont4 <= 40)
            {
                ltx_Imprimir.Items.Add(cont4);

                cont4 += 4;

            }
                                 
            int cont5 = 5;

            ltx_Imprimir.Items.Add("Tabuada do 5");

            while (cont5 <= 50)
            {
                ltx_Imprimir.Items.Add(cont5);

                cont5 += 6;

            }
                                 
            int cont6 = 6;

            ltx_Imprimir.Items.Add("Tabuada do 6");

            while (cont6 <= 60)
            {
                ltx_Imprimir.Items.Add(cont6);

                cont6 += 6;

            }
                                                  
            int cont7 = 7;

            ltx_Imprimir.Items.Add("Tabuada do 7");

            while (cont7 <= 70)
            {
                ltx_Imprimir.Items.Add(cont7);

                cont7 += 7;

            }

            int cont8 = 8;

            ltx_Imprimir.Items.Add("Tabuada do 8");

            while (cont8 <= 80)
            {
                ltx_Imprimir.Items.Add(cont8);

                cont8 += 8;

            }

            int cont9 = 9;

            ltx_Imprimir.Items.Add("Tabuada do 9");

            while (cont9 <= 90)
            {
                ltx_Imprimir.Items.Add(cont9);

                cont9 += 9;

            }

            int cont10 = 10;

            ltx_Imprimir.Items.Add("Tabuada do 10");

            while (cont10 <= 100)
            {
                ltx_Imprimir.Items.Add(cont10);
               
                cont10 += 10;

            }









        }

        private void ltx_Imprimir_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

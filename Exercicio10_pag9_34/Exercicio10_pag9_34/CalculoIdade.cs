using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio10_pag9_34
{
    public partial class CalculoIdade : Form
    {
        public CalculoIdade()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ano_nasc, ano_atual, anos, meses, dias, semanas;

            ano_nasc = int.Parse(txt_nascimento.Text);
            ano_atual = int.Parse(txt_ano.Text);
            anos = (ano_atual - ano_nasc);
            meses = (anos * 12);
            dias = (anos * 365);
            semanas = anos * 52;
            MessageBox.Show("Sua idade em anos é: " + anos);
            MessageBox.Show("Sua idade em meses é: " + meses);
            MessageBox.Show("Sua idade em semanas é: " + semanas);
            MessageBox.Show("Sua idade em dias é: " + dias);
           




        }

        private void txt_nascimento_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

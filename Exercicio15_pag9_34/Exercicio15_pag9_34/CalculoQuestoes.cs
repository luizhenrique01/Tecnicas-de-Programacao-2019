using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio15_pag9_34
{
    public partial class CalculoQuestoes : Form
    {
        public CalculoQuestoes()
        {
            InitializeComponent();
        }

        private void btn_calcule_Click(object sender, EventArgs e)
        {
            double total_questoes, acertou, errou, porc_acertos, porc_erros;
            total_questoes = double.Parse(txt_questoes.Text);
            acertou = double.Parse(txt_acertos.Text);
            errou = (total_questoes - acertou);
            porc_acertos = (acertou / total_questoes * 100);
            porc_erros = (errou / total_questoes * 100);

            MessageBox.Show("O número de questões que errou: " + errou);
            MessageBox.Show("A porcentagem de acertos: " + porc_acertos + ("%"));
            MessageBox.Show("A porcentagem de erros: " + porc_erros + ("%"));


        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio12_pagina21_34
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome;
            double salario_fixo, pecas, comissao, sal_bruto, inss, plano_saude, sal_liquido;
            nome = txt_nome.Text;
            salario_fixo = double.Parse(txt_salario.Text);
            pecas = double.Parse(txt_numeropecas.Text);

            comissao = pecas * 1.50;
            sal_bruto = salario_fixo + comissao;
            inss = sal_bruto * 0.11;
            plano_saude = sal_bruto * 0.02;
            sal_liquido = sal_bruto - inss - plano_saude;
            MessageBox.Show("Valor da comissão:R$ " + comissao);
            MessageBox.Show("Valor do salário bruto:R$ " + sal_bruto);
            MessageBox.Show("Valor da contribuição do Inss:R$ " + inss);
            MessageBox.Show("Valor do plano de saúde:R$ " + plano_saude);
            MessageBox.Show("Valor do salário liquido:R$ " + sal_liquido);










        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_numeropecas_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

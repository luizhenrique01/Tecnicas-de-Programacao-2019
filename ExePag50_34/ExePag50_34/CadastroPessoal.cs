using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExePag50_34
{
    public partial class CadastroPessoal : Form
    {
        public CadastroPessoal()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            string mensagem = "";

            if(txt_cpf.Text == "")
            {
                mensagem += "Digite o valor do CPF\n";
            } 
            if(txt_nome.Text == "")
            {
                mensagem += "Digite o nome completo\n";
            }
            if(txt_telefonecelular.Text == "")
                {
                    mensagem += "Digite o numero de celular\n";
                }
            if(txt_email.Text == "")
            {
                mensagem += "Digite o E-mail\n";
            }

            lbl_cobrigatorio.ForeColor = Color.Red;
            lbl_cobrigatorio.Text = mensagem;

            if(txt_cpf.Text.Length != 11)
            {
                MessageBox.Show("CPF invalido! \nDeve conter 11 caracteres", "Erro!");
                txt_cpf.Focus();
            } else if(txt_nome.Text.Length < 5)
            {
                MessageBox.Show("Nome invalido! \nDeve conter no minimo 5 caracteres!", "Erro!");
                txt_nome.Focus();
            } else if(txt_uf.Text.Length != 2)
            {
                MessageBox.Show("UF invalida! \nDeve conter no minimo 2 caracteres!", "Erro!");
                txt_uf.Focus();
            } else if ((!txt_email.Text.Contains("@") || !txt_email.Text.Contains(".")) || txt_email.Text.Length == 0)
            {
                MessageBox.Show("E-Mail invalido!", "Erro!");
                txt_email.Focus();
            }

 




        }
    }
}

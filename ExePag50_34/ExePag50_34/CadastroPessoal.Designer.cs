namespace ExePag50_34
{
    partial class CadastroPessoal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_cpf = new System.Windows.Forms.MaskedTextBox();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.lbl_cobrigatorio = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lbl_NomeCompleto = new System.Windows.Forms.Label();
            this.lbl_cidade = new System.Windows.Forms.Label();
            this.lbl_bairro = new System.Windows.Forms.Label();
            this.txt_uf = new System.Windows.Forms.MaskedTextBox();
            this.txt_cep = new System.Windows.Forms.MaskedTextBox();
            this.txt_telefoneresidencial = new System.Windows.Forms.MaskedTextBox();
            this.lbl_uf = new System.Windows.Forms.Label();
            this.lbl_cep = new System.Windows.Forms.Label();
            this.lbl_telefoneresidencial = new System.Windows.Forms.Label();
            this.lbl_telefonecelular = new System.Windows.Forms.Label();
            this.txt_telefonecelular = new System.Windows.Forms.MaskedTextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_cpf
            // 
            this.txt_cpf.Location = new System.Drawing.Point(13, 35);
            this.txt_cpf.Mask = "999.999.999-00";
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(100, 20);
            this.txt_cpf.TabIndex = 0;
            this.txt_cpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Location = new System.Drawing.Point(10, 9);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(34, 13);
            this.lbl_cpf.TabIndex = 1;
            this.lbl_cpf.Text = "* CPF";
            // 
            // lbl_cobrigatorio
            // 
            this.lbl_cobrigatorio.AutoSize = true;
            this.lbl_cobrigatorio.Location = new System.Drawing.Point(291, 9);
            this.lbl_cobrigatorio.Name = "lbl_cobrigatorio";
            this.lbl_cobrigatorio.Size = new System.Drawing.Size(186, 26);
            this.lbl_cobrigatorio.TabIndex = 2;
            this.lbl_cobrigatorio.Text = "* Campos de preenchimento origatorio\r\n\r\n";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(13, 101);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(542, 20);
            this.txt_nome.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 162);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(262, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(294, 162);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(261, 20);
            this.textBox3.TabIndex = 5;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lbl_NomeCompleto
            // 
            this.lbl_NomeCompleto.AutoSize = true;
            this.lbl_NomeCompleto.Location = new System.Drawing.Point(10, 71);
            this.lbl_NomeCompleto.Name = "lbl_NomeCompleto";
            this.lbl_NomeCompleto.Size = new System.Drawing.Size(88, 13);
            this.lbl_NomeCompleto.TabIndex = 6;
            this.lbl_NomeCompleto.Text = "* Nome completo";
            // 
            // lbl_cidade
            // 
            this.lbl_cidade.AutoSize = true;
            this.lbl_cidade.Location = new System.Drawing.Point(294, 136);
            this.lbl_cidade.Name = "lbl_cidade";
            this.lbl_cidade.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_cidade.Size = new System.Drawing.Size(40, 13);
            this.lbl_cidade.TabIndex = 7;
            this.lbl_cidade.Text = "Cidade";
            // 
            // lbl_bairro
            // 
            this.lbl_bairro.AutoSize = true;
            this.lbl_bairro.Location = new System.Drawing.Point(10, 136);
            this.lbl_bairro.Name = "lbl_bairro";
            this.lbl_bairro.Size = new System.Drawing.Size(34, 13);
            this.lbl_bairro.TabIndex = 8;
            this.lbl_bairro.Text = "Bairro";
            // 
            // txt_uf
            // 
            this.txt_uf.Location = new System.Drawing.Point(22, 233);
            this.txt_uf.Mask = "AA";
            this.txt_uf.Name = "txt_uf";
            this.txt_uf.Size = new System.Drawing.Size(18, 20);
            this.txt_uf.TabIndex = 9;
            this.txt_uf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txt_cep
            // 
            this.txt_cep.Location = new System.Drawing.Point(62, 233);
            this.txt_cep.Mask = "99999-999";
            this.txt_cep.Name = "txt_cep";
            this.txt_cep.Size = new System.Drawing.Size(100, 20);
            this.txt_cep.TabIndex = 10;
            this.txt_cep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txt_telefoneresidencial
            // 
            this.txt_telefoneresidencial.Location = new System.Drawing.Point(175, 233);
            this.txt_telefoneresidencial.Mask = "(99)9999-9999";
            this.txt_telefoneresidencial.Name = "txt_telefoneresidencial";
            this.txt_telefoneresidencial.Size = new System.Drawing.Size(100, 20);
            this.txt_telefoneresidencial.TabIndex = 11;
            this.txt_telefoneresidencial.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lbl_uf
            // 
            this.lbl_uf.AutoSize = true;
            this.lbl_uf.Location = new System.Drawing.Point(19, 198);
            this.lbl_uf.Name = "lbl_uf";
            this.lbl_uf.Size = new System.Drawing.Size(21, 13);
            this.lbl_uf.TabIndex = 13;
            this.lbl_uf.Text = "UF";
            // 
            // lbl_cep
            // 
            this.lbl_cep.AutoSize = true;
            this.lbl_cep.Location = new System.Drawing.Point(59, 198);
            this.lbl_cep.Name = "lbl_cep";
            this.lbl_cep.Size = new System.Drawing.Size(28, 13);
            this.lbl_cep.TabIndex = 14;
            this.lbl_cep.Text = "CEP";
            // 
            // lbl_telefoneresidencial
            // 
            this.lbl_telefoneresidencial.AutoSize = true;
            this.lbl_telefoneresidencial.Location = new System.Drawing.Point(168, 198);
            this.lbl_telefoneresidencial.Name = "lbl_telefoneresidencial";
            this.lbl_telefoneresidencial.Size = new System.Drawing.Size(107, 13);
            this.lbl_telefoneresidencial.TabIndex = 15;
            this.lbl_telefoneresidencial.Text = "Telefone Residencial";
            // 
            // lbl_telefonecelular
            // 
            this.lbl_telefonecelular.AutoSize = true;
            this.lbl_telefonecelular.Location = new System.Drawing.Point(291, 198);
            this.lbl_telefonecelular.Name = "lbl_telefonecelular";
            this.lbl_telefonecelular.Size = new System.Drawing.Size(90, 13);
            this.lbl_telefonecelular.TabIndex = 16;
            this.lbl_telefonecelular.Text = "* Telefone celular";
            // 
            // txt_telefonecelular
            // 
            this.txt_telefonecelular.Location = new System.Drawing.Point(294, 233);
            this.txt_telefonecelular.Mask = "(99)9999-9999";
            this.txt_telefonecelular.Name = "txt_telefonecelular";
            this.txt_telefonecelular.Size = new System.Drawing.Size(100, 20);
            this.txt_telefonecelular.TabIndex = 17;
            this.txt_telefonecelular.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(13, 293);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(542, 20);
            this.txt_email.TabIndex = 18;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(10, 265);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(43, 13);
            this.lbl_email.TabIndex = 19;
            this.lbl_email.Text = "* E-Mail";
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Location = new System.Drawing.Point(81, 319);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(170, 63);
            this.btn_confirmar.TabIndex = 20;
            this.btn_confirmar.Text = "CONFIRMAR";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(257, 319);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(170, 63);
            this.btn_cancelar.TabIndex = 21;
            this.btn_cancelar.Text = "CANCELAR";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // CadastroPessoal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(567, 393);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_telefonecelular);
            this.Controls.Add(this.lbl_telefonecelular);
            this.Controls.Add(this.lbl_telefoneresidencial);
            this.Controls.Add(this.lbl_cep);
            this.Controls.Add(this.lbl_uf);
            this.Controls.Add(this.txt_telefoneresidencial);
            this.Controls.Add(this.txt_cep);
            this.Controls.Add(this.txt_uf);
            this.Controls.Add(this.lbl_bairro);
            this.Controls.Add(this.lbl_cidade);
            this.Controls.Add(this.lbl_NomeCompleto);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_cobrigatorio);
            this.Controls.Add(this.lbl_cpf);
            this.Controls.Add(this.txt_cpf);
            this.Name = "CadastroPessoal";
            this.Text = "Cadastro pessoal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txt_cpf;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.Label lbl_cobrigatorio;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lbl_NomeCompleto;
        private System.Windows.Forms.Label lbl_cidade;
        private System.Windows.Forms.Label lbl_bairro;
        private System.Windows.Forms.MaskedTextBox txt_uf;
        private System.Windows.Forms.MaskedTextBox txt_cep;
        private System.Windows.Forms.MaskedTextBox txt_telefoneresidencial;
        private System.Windows.Forms.Label lbl_uf;
        private System.Windows.Forms.Label lbl_cep;
        private System.Windows.Forms.Label lbl_telefoneresidencial;
        private System.Windows.Forms.Label lbl_telefonecelular;
        private System.Windows.Forms.MaskedTextBox txt_telefonecelular;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Button btn_cancelar;
    }
}


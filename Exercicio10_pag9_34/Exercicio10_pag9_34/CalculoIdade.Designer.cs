namespace Exercicio10_pag9_34
{
    partial class CalculoIdade
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
            this.btn_1 = new System.Windows.Forms.Button();
            this.lbl_ano = new System.Windows.Forms.Label();
            this.lbl_nascimento = new System.Windows.Forms.Label();
            this.txt_nascimento = new System.Windows.Forms.TextBox();
            this.txt_ano = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(122, 135);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(75, 19);
            this.btn_1.TabIndex = 0;
            this.btn_1.Text = "Calcule";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_ano
            // 
            this.lbl_ano.AutoSize = true;
            this.lbl_ano.Location = new System.Drawing.Point(61, 68);
            this.lbl_ano.Name = "lbl_ano";
            this.lbl_ano.Size = new System.Drawing.Size(62, 13);
            this.lbl_ano.TabIndex = 1;
            this.lbl_ano.Text = "O ano atual";
            this.lbl_ano.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_nascimento
            // 
            this.lbl_nascimento.AutoSize = true;
            this.lbl_nascimento.Location = new System.Drawing.Point(61, 35);
            this.lbl_nascimento.Name = "lbl_nascimento";
            this.lbl_nascimento.Size = new System.Drawing.Size(136, 13);
            this.lbl_nascimento.TabIndex = 3;
            this.lbl_nascimento.Text = "Digite o ano de nascimento";
            this.lbl_nascimento.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_nascimento
            // 
            this.txt_nascimento.Location = new System.Drawing.Point(230, 28);
            this.txt_nascimento.Name = "txt_nascimento";
            this.txt_nascimento.Size = new System.Drawing.Size(100, 20);
            this.txt_nascimento.TabIndex = 4;
            this.txt_nascimento.TextChanged += new System.EventHandler(this.txt_nascimento_TextChanged);
            // 
            // txt_ano
            // 
            this.txt_ano.Location = new System.Drawing.Point(230, 68);
            this.txt_ano.Name = "txt_ano";
            this.txt_ano.Size = new System.Drawing.Size(100, 20);
            this.txt_ano.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 188);
            this.Controls.Add(this.txt_ano);
            this.Controls.Add(this.txt_nascimento);
            this.Controls.Add(this.lbl_nascimento);
            this.Controls.Add(this.lbl_ano);
            this.Controls.Add(this.btn_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Label lbl_ano;
        private System.Windows.Forms.Label lbl_nascimento;
        private System.Windows.Forms.TextBox txt_nascimento;
        private System.Windows.Forms.TextBox txt_ano;
    }
}


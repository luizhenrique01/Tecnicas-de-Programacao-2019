namespace Exercicio12_pagina21_34
{
    partial class Form1
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
            this.btn_calcular = new System.Windows.Forms.Button();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_salario = new System.Windows.Forms.TextBox();
            this.lbl_label = new System.Windows.Forms.Label();
            this.lbl_salario = new System.Windows.Forms.Label();
            this.lbl_numeropecas = new System.Windows.Forms.Label();
            this.txt_numeropecas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(137, 187);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(69, 23);
            this.btn_calcular.TabIndex = 0;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(284, 42);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(100, 20);
            this.txt_nome.TabIndex = 1;
            // 
            // txt_salario
            // 
            this.txt_salario.Location = new System.Drawing.Point(284, 87);
            this.txt_salario.Name = "txt_salario";
            this.txt_salario.Size = new System.Drawing.Size(100, 20);
            this.txt_salario.TabIndex = 2;
            // 
            // lbl_label
            // 
            this.lbl_label.AutoSize = true;
            this.lbl_label.Location = new System.Drawing.Point(110, 42);
            this.lbl_label.Name = "lbl_label";
            this.lbl_label.Size = new System.Drawing.Size(35, 13);
            this.lbl_label.TabIndex = 3;
            this.lbl_label.Text = "Nome";
            // 
            // lbl_salario
            // 
            this.lbl_salario.AutoSize = true;
            this.lbl_salario.Location = new System.Drawing.Point(106, 87);
            this.lbl_salario.Name = "lbl_salario";
            this.lbl_salario.Size = new System.Drawing.Size(58, 13);
            this.lbl_salario.TabIndex = 4;
            this.lbl_salario.Text = "Salario fixo";
            // 
            // lbl_numeropecas
            // 
            this.lbl_numeropecas.AutoSize = true;
            this.lbl_numeropecas.Location = new System.Drawing.Point(26, 145);
            this.lbl_numeropecas.Name = "lbl_numeropecas";
            this.lbl_numeropecas.Size = new System.Drawing.Size(138, 13);
            this.lbl_numeropecas.TabIndex = 5;
            this.lbl_numeropecas.Text = "Número de Peças vendidas";
            this.lbl_numeropecas.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_numeropecas
            // 
            this.txt_numeropecas.Location = new System.Drawing.Point(284, 138);
            this.txt_numeropecas.Name = "txt_numeropecas";
            this.txt_numeropecas.Size = new System.Drawing.Size(100, 20);
            this.txt_numeropecas.TabIndex = 6;
            this.txt_numeropecas.TextChanged += new System.EventHandler(this.txt_numeropecas_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 409);
            this.Controls.Add(this.txt_numeropecas);
            this.Controls.Add(this.lbl_numeropecas);
            this.Controls.Add(this.lbl_salario);
            this.Controls.Add(this.lbl_label);
            this.Controls.Add(this.txt_salario);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.btn_calcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_salario;
        private System.Windows.Forms.Label lbl_label;
        private System.Windows.Forms.Label lbl_salario;
        private System.Windows.Forms.Label lbl_numeropecas;
        private System.Windows.Forms.TextBox txt_numeropecas;
    }
}


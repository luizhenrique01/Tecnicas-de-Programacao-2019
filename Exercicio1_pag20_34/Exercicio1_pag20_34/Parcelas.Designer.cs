namespace Exercicio1_pag20_34
{
    partial class Parcelas
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
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_compra = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_compra = new System.Windows.Forms.TextBox();
            this.txt_entrada = new System.Windows.Forms.TextBox();
            this.txt_parcela = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(137, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calcule";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_compra
            // 
            this.lbl_compra.AutoSize = true;
            this.lbl_compra.Location = new System.Drawing.Point(20, 38);
            this.lbl_compra.Name = "lbl_compra";
            this.lbl_compra.Size = new System.Drawing.Size(148, 13);
            this.lbl_compra.TabIndex = 1;
            this.lbl_compra.Text = "Digite o valor total da compra:";
            this.lbl_compra.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Digite o valor da entrada: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Digite a quantidade de parcelas:  ";
            // 
            // txt_compra
            // 
            this.txt_compra.Location = new System.Drawing.Point(217, 35);
            this.txt_compra.Name = "txt_compra";
            this.txt_compra.Size = new System.Drawing.Size(100, 20);
            this.txt_compra.TabIndex = 4;
            // 
            // txt_entrada
            // 
            this.txt_entrada.Location = new System.Drawing.Point(217, 85);
            this.txt_entrada.Name = "txt_entrada";
            this.txt_entrada.Size = new System.Drawing.Size(100, 20);
            this.txt_entrada.TabIndex = 5;
            // 
            // txt_parcela
            // 
            this.txt_parcela.Location = new System.Drawing.Point(217, 129);
            this.txt_parcela.Name = "txt_parcela";
            this.txt_parcela.Size = new System.Drawing.Size(100, 20);
            this.txt_parcela.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 237);
            this.Controls.Add(this.txt_parcela);
            this.Controls.Add(this.txt_entrada);
            this.Controls.Add(this.txt_compra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_compra);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_compra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_compra;
        private System.Windows.Forms.TextBox txt_entrada;
        private System.Windows.Forms.TextBox txt_parcela;
    }
}


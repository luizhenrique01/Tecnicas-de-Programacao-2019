namespace Exercicio6_pag20_34
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.txt_kwh = new System.Windows.Forms.TextBox();
            this.txt_quantia = new System.Windows.Forms.TextBox();
            this.btn_caucle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite o valor do Kwh:  ";
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.Location = new System.Drawing.Point(77, 139);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(147, 13);
            this.lbl_2.TabIndex = 2;
            this.lbl_2.Text = "Digite a quantida consumida: ";
            // 
            // txt_kwh
            // 
            this.txt_kwh.Location = new System.Drawing.Point(207, 82);
            this.txt_kwh.Name = "txt_kwh";
            this.txt_kwh.Size = new System.Drawing.Size(100, 20);
            this.txt_kwh.TabIndex = 3;
            // 
            // txt_quantia
            // 
            this.txt_quantia.Location = new System.Drawing.Point(230, 132);
            this.txt_quantia.Name = "txt_quantia";
            this.txt_quantia.Size = new System.Drawing.Size(90, 20);
            this.txt_quantia.TabIndex = 4;
            this.txt_quantia.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btn_caucle
            // 
            this.btn_caucle.Location = new System.Drawing.Point(162, 214);
            this.btn_caucle.Name = "btn_caucle";
            this.btn_caucle.Size = new System.Drawing.Size(75, 23);
            this.btn_caucle.TabIndex = 5;
            this.btn_caucle.Text = "Calcule";
            this.btn_caucle.UseVisualStyleBackColor = true;
            this.btn_caucle.Click += new System.EventHandler(this.btn_caucle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 275);
            this.Controls.Add(this.btn_caucle);
            this.Controls.Add(this.txt_quantia);
            this.Controls.Add(this.txt_kwh);
            this.Controls.Add(this.lbl_2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_2;
        private System.Windows.Forms.TextBox txt_kwh;
        private System.Windows.Forms.TextBox txt_quantia;
        private System.Windows.Forms.Button btn_caucle;
    }
}


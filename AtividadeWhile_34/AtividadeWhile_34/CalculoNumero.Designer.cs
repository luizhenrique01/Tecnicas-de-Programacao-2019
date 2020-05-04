namespace AtividadeWhile_34
{
    partial class Calculo_num
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
            this.btn_calcule = new System.Windows.Forms.Button();
            this.ltx_lista = new System.Windows.Forms.ListBox();
            this.txt_n2 = new System.Windows.Forms.TextBox();
            this.txt_n1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_calcule
            // 
            this.btn_calcule.Location = new System.Drawing.Point(9, 341);
            this.btn_calcule.Name = "btn_calcule";
            this.btn_calcule.Size = new System.Drawing.Size(248, 45);
            this.btn_calcule.TabIndex = 0;
            this.btn_calcule.Text = "Gere";
            this.btn_calcule.UseVisualStyleBackColor = true;
            this.btn_calcule.Click += new System.EventHandler(this.btn_calcule_Click);
            // 
            // ltx_lista
            // 
            this.ltx_lista.FormattingEnabled = true;
            this.ltx_lista.Location = new System.Drawing.Point(9, 71);
            this.ltx_lista.Name = "ltx_lista";
            this.ltx_lista.Size = new System.Drawing.Size(248, 264);
            this.ltx_lista.TabIndex = 1;
            // 
            // txt_n2
            // 
            this.txt_n2.Location = new System.Drawing.Point(136, 38);
            this.txt_n2.Name = "txt_n2";
            this.txt_n2.Size = new System.Drawing.Size(121, 20);
            this.txt_n2.TabIndex = 2;
            // 
            // txt_n1
            // 
            this.txt_n1.Location = new System.Drawing.Point(9, 38);
            this.txt_n1.Name = "txt_n1";
            this.txt_n1.Size = new System.Drawing.Size(121, 20);
            this.txt_n1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Numero 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Numero 2";
            // 
            // Calculo_num
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 398);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_n1);
            this.Controls.Add(this.txt_n2);
            this.Controls.Add(this.ltx_lista);
            this.Controls.Add(this.btn_calcule);
            this.Name = "Calculo_num";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculo Numeros";
            this.Load += new System.EventHandler(this.Calculo_num_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_calcule;
        private System.Windows.Forms.ListBox ltx_lista;
        private System.Windows.Forms.TextBox txt_n2;
        private System.Windows.Forms.TextBox txt_n1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


namespace Exercicio15_pag9_34
{
    partial class CalculoQuestoes
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
            this.lbl_questoes = new System.Windows.Forms.Label();
            this.lbl_acertos = new System.Windows.Forms.Label();
            this.btn_calcule = new System.Windows.Forms.Button();
            this.txt_questoes = new System.Windows.Forms.TextBox();
            this.txt_acertos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_questoes
            // 
            this.lbl_questoes.AutoSize = true;
            this.lbl_questoes.Location = new System.Drawing.Point(35, 28);
            this.lbl_questoes.Name = "lbl_questoes";
            this.lbl_questoes.Size = new System.Drawing.Size(133, 13);
            this.lbl_questoes.TabIndex = 0;
            this.lbl_questoes.Text = "Digite o total de questões: ";
            // 
            // lbl_acertos
            // 
            this.lbl_acertos.AutoSize = true;
            this.lbl_acertos.Location = new System.Drawing.Point(35, 83);
            this.lbl_acertos.Name = "lbl_acertos";
            this.lbl_acertos.Size = new System.Drawing.Size(125, 13);
            this.lbl_acertos.TabIndex = 1;
            this.lbl_acertos.Text = "Digite o total de acertos: ";
            // 
            // btn_calcule
            // 
            this.btn_calcule.Location = new System.Drawing.Point(78, 134);
            this.btn_calcule.Name = "btn_calcule";
            this.btn_calcule.Size = new System.Drawing.Size(75, 23);
            this.btn_calcule.TabIndex = 2;
            this.btn_calcule.Text = "Calcule";
            this.btn_calcule.UseVisualStyleBackColor = true;
            this.btn_calcule.Click += new System.EventHandler(this.btn_calcule_Click);
            // 
            // txt_questoes
            // 
            this.txt_questoes.Location = new System.Drawing.Point(169, 25);
            this.txt_questoes.Name = "txt_questoes";
            this.txt_questoes.Size = new System.Drawing.Size(120, 20);
            this.txt_questoes.TabIndex = 3;
            // 
            // txt_acertos
            // 
            this.txt_acertos.Location = new System.Drawing.Point(169, 76);
            this.txt_acertos.Name = "txt_acertos";
            this.txt_acertos.Size = new System.Drawing.Size(120, 20);
            this.txt_acertos.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 214);
            this.Controls.Add(this.txt_acertos);
            this.Controls.Add(this.txt_questoes);
            this.Controls.Add(this.btn_calcule);
            this.Controls.Add(this.lbl_acertos);
            this.Controls.Add(this.lbl_questoes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_questoes;
        private System.Windows.Forms.Label lbl_acertos;
        private System.Windows.Forms.Button btn_calcule;
        private System.Windows.Forms.TextBox txt_questoes;
        private System.Windows.Forms.TextBox txt_acertos;
    }
}


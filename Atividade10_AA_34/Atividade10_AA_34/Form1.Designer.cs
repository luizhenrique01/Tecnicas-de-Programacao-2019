namespace Atividade10_AA_34
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
            this.lbl_maior = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.Label();
            this.lbl_menor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_media = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Maior Numero";
            // 
            // lbl_maior
            // 
            this.lbl_maior.AutoSize = true;
            this.lbl_maior.Location = new System.Drawing.Point(42, 44);
            this.lbl_maior.Name = "lbl_maior";
            this.lbl_maior.Size = new System.Drawing.Size(0, 13);
            this.lbl_maior.TabIndex = 1;
            this.lbl_maior.Click += new System.EventHandler(this.lbl_maior_Click);
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(26, 84);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(75, 13);
            this.a.TabIndex = 3;
            this.a.Text = "Menor numero";
            // 
            // lbl_menor
            // 
            this.lbl_menor.AutoSize = true;
            this.lbl_menor.Location = new System.Drawing.Point(42, 119);
            this.lbl_menor.Name = "lbl_menor";
            this.lbl_menor.Size = new System.Drawing.Size(0, 13);
            this.lbl_menor.TabIndex = 2;
            this.lbl_menor.Click += new System.EventHandler(this.lbl_menor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Media";
            // 
            // lbl_media
            // 
            this.lbl_media.AutoSize = true;
            this.lbl_media.Location = new System.Drawing.Point(42, 197);
            this.lbl_media.Name = "lbl_media";
            this.lbl_media.Size = new System.Drawing.Size(0, 13);
            this.lbl_media.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 47);
            this.button1.TabIndex = 6;
            this.button1.Text = "Gere";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 296);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_media);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.a);
            this.Controls.Add(this.lbl_menor);
            this.Controls.Add(this.lbl_maior);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_maior;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Label lbl_menor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_media;
        private System.Windows.Forms.Button button1;
    }
}


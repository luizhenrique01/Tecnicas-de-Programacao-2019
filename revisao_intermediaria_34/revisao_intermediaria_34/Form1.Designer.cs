namespace revisao_intermediaria_34
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
            this.ltx_imprimir = new System.Windows.Forms.ListBox();
            this.btn_c = new System.Windows.Forms.Button();
            this.lbl_soma = new System.Windows.Forms.Label();
            this.lbl_media = new System.Windows.Forms.Label();
            this.lbl_maior = new System.Windows.Forms.Label();
            this.lbl_menor = new System.Windows.Forms.Label();
            this.lbl_porc = new System.Windows.Forms.Label();
            this.lbl_quantidade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ltx_imprimir
            // 
            this.ltx_imprimir.FormattingEnabled = true;
            this.ltx_imprimir.Location = new System.Drawing.Point(12, 12);
            this.ltx_imprimir.Name = "ltx_imprimir";
            this.ltx_imprimir.Size = new System.Drawing.Size(238, 303);
            this.ltx_imprimir.TabIndex = 0;
            // 
            // btn_c
            // 
            this.btn_c.Location = new System.Drawing.Point(12, 330);
            this.btn_c.Name = "btn_c";
            this.btn_c.Size = new System.Drawing.Size(238, 39);
            this.btn_c.TabIndex = 1;
            this.btn_c.Text = "Calcular";
            this.btn_c.UseVisualStyleBackColor = true;
            this.btn_c.Click += new System.EventHandler(this.btn_c_Click);
            // 
            // lbl_soma
            // 
            this.lbl_soma.AutoSize = true;
            this.lbl_soma.Location = new System.Drawing.Point(256, 12);
            this.lbl_soma.Name = "lbl_soma";
            this.lbl_soma.Size = new System.Drawing.Size(37, 13);
            this.lbl_soma.TabIndex = 2;
            this.lbl_soma.Text = "Soma:";
            // 
            // lbl_media
            // 
            this.lbl_media.AutoSize = true;
            this.lbl_media.Location = new System.Drawing.Point(256, 48);
            this.lbl_media.Name = "lbl_media";
            this.lbl_media.Size = new System.Drawing.Size(39, 13);
            this.lbl_media.TabIndex = 3;
            this.lbl_media.Text = "Media:";
            this.lbl_media.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_maior
            // 
            this.lbl_maior.AutoSize = true;
            this.lbl_maior.Location = new System.Drawing.Point(256, 84);
            this.lbl_maior.Name = "lbl_maior";
            this.lbl_maior.Size = new System.Drawing.Size(36, 13);
            this.lbl_maior.TabIndex = 4;
            this.lbl_maior.Text = "Maior:";
            // 
            // lbl_menor
            // 
            this.lbl_menor.AutoSize = true;
            this.lbl_menor.Location = new System.Drawing.Point(256, 120);
            this.lbl_menor.Name = "lbl_menor";
            this.lbl_menor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_menor.Size = new System.Drawing.Size(40, 13);
            this.lbl_menor.TabIndex = 5;
            this.lbl_menor.Text = "Menor:";
            // 
            // lbl_porc
            // 
            this.lbl_porc.AutoSize = true;
            this.lbl_porc.Location = new System.Drawing.Point(256, 156);
            this.lbl_porc.Name = "lbl_porc";
            this.lbl_porc.Size = new System.Drawing.Size(73, 13);
            this.lbl_porc.TabIndex = 6;
            this.lbl_porc.Text = "Porcentagem:";
            // 
            // lbl_quantidade
            // 
            this.lbl_quantidade.AutoSize = true;
            this.lbl_quantidade.Location = new System.Drawing.Point(256, 192);
            this.lbl_quantidade.Name = "lbl_quantidade";
            this.lbl_quantidade.Size = new System.Drawing.Size(65, 13);
            this.lbl_quantidade.TabIndex = 7;
            this.lbl_quantidade.Text = "Quantidade:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_quantidade);
            this.Controls.Add(this.lbl_porc);
            this.Controls.Add(this.lbl_menor);
            this.Controls.Add(this.lbl_maior);
            this.Controls.Add(this.lbl_media);
            this.Controls.Add(this.lbl_soma);
            this.Controls.Add(this.btn_c);
            this.Controls.Add(this.ltx_imprimir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ltx_imprimir;
        private System.Windows.Forms.Button btn_c;
        private System.Windows.Forms.Label lbl_soma;
        private System.Windows.Forms.Label lbl_media;
        private System.Windows.Forms.Label lbl_maior;
        private System.Windows.Forms.Label lbl_menor;
        private System.Windows.Forms.Label lbl_porc;
        private System.Windows.Forms.Label lbl_quantidade;
    }
}


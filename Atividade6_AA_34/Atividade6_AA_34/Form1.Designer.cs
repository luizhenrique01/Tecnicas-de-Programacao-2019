namespace Atividade6_AA_34
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
            this.btn_calcule = new System.Windows.Forms.Button();
            this.ltx_imprimir = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_calcule
            // 
            this.btn_calcule.Location = new System.Drawing.Point(12, 295);
            this.btn_calcule.Name = "btn_calcule";
            this.btn_calcule.Size = new System.Drawing.Size(252, 35);
            this.btn_calcule.TabIndex = 10;
            this.btn_calcule.Text = "Calcule";
            this.btn_calcule.UseVisualStyleBackColor = true;
            this.btn_calcule.Click += new System.EventHandler(this.btn_calcule_Click);
            // 
            // ltx_imprimir
            // 
            this.ltx_imprimir.FormattingEnabled = true;
            this.ltx_imprimir.Location = new System.Drawing.Point(12, 12);
            this.ltx_imprimir.Name = "ltx_imprimir";
            this.ltx_imprimir.Size = new System.Drawing.Size(252, 277);
            this.ltx_imprimir.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 340);
            this.Controls.Add(this.btn_calcule);
            this.Controls.Add(this.ltx_imprimir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_calcule;
        private System.Windows.Forms.ListBox ltx_imprimir;
    }
}


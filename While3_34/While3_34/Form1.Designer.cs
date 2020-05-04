namespace While3_34
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
            this.btn_While = new System.Windows.Forms.Button();
            this.ltx_Imprimir = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_While
            // 
            this.btn_While.Location = new System.Drawing.Point(35, 319);
            this.btn_While.Name = "btn_While";
            this.btn_While.Size = new System.Drawing.Size(263, 61);
            this.btn_While.TabIndex = 5;
            this.btn_While.Text = "While - Repetir";
            this.btn_While.UseVisualStyleBackColor = true;
            this.btn_While.Click += new System.EventHandler(this.btn_While_Click);
            // 
            // ltx_Imprimir
            // 
            this.ltx_Imprimir.FormattingEnabled = true;
            this.ltx_Imprimir.Location = new System.Drawing.Point(35, 12);
            this.ltx_Imprimir.Name = "ltx_Imprimir";
            this.ltx_Imprimir.Size = new System.Drawing.Size(263, 290);
            this.ltx_Imprimir.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 409);
            this.Controls.Add(this.btn_While);
            this.Controls.Add(this.ltx_Imprimir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_While;
        private System.Windows.Forms.ListBox ltx_Imprimir;
    }
}


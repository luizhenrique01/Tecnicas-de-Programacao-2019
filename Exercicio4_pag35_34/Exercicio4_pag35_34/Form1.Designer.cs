namespace Exercicio4_pag35_34
{
    partial class frm_horas
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
            this.Calcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_horas = new System.Windows.Forms.TextBox();
            this.cbx_classe = new System.Windows.Forms.ComboBox();
            this.txt_horasextras = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_bruto = new System.Windows.Forms.Label();
            this.lbl_inss = new System.Windows.Forms.Label();
            this.lbl_horaextra = new System.Windows.Forms.Label();
            this.lbl_liquido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(79, 142);
            this.Calcular.Name = "Calcular";
            this.Calcular.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Calcular.Size = new System.Drawing.Size(69, 28);
            this.Calcular.TabIndex = 0;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Classe";
            // 
            // txt_horas
            // 
            this.txt_horas.Location = new System.Drawing.Point(131, 59);
            this.txt_horas.Name = "txt_horas";
            this.txt_horas.Size = new System.Drawing.Size(121, 20);
            this.txt_horas.TabIndex = 2;
            // 
            // cbx_classe
            // 
            this.cbx_classe.FormattingEnabled = true;
            this.cbx_classe.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbx_classe.Location = new System.Drawing.Point(131, 12);
            this.cbx_classe.Name = "cbx_classe";
            this.cbx_classe.Size = new System.Drawing.Size(121, 21);
            this.cbx_classe.TabIndex = 3;
            // 
            // txt_horasextras
            // 
            this.txt_horasextras.Location = new System.Drawing.Point(131, 102);
            this.txt_horasextras.Name = "txt_horasextras";
            this.txt_horasextras.Size = new System.Drawing.Size(121, 20);
            this.txt_horasextras.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Horas extras";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Horas trabalhadas";
            // 
            // lbl_bruto
            // 
            this.lbl_bruto.AutoSize = true;
            this.lbl_bruto.Location = new System.Drawing.Point(11, 190);
            this.lbl_bruto.Name = "lbl_bruto";
            this.lbl_bruto.Size = new System.Drawing.Size(69, 13);
            this.lbl_bruto.TabIndex = 7;
            this.lbl_bruto.Text = "Salario bruto:";
            // 
            // lbl_inss
            // 
            this.lbl_inss.AutoSize = true;
            this.lbl_inss.Location = new System.Drawing.Point(11, 240);
            this.lbl_inss.Name = "lbl_inss";
            this.lbl_inss.Size = new System.Drawing.Size(84, 13);
            this.lbl_inss.TabIndex = 8;
            this.lbl_inss.Text = "Desconto INSS:";
            // 
            // lbl_horaextra
            // 
            this.lbl_horaextra.AutoSize = true;
            this.lbl_horaextra.Location = new System.Drawing.Point(12, 215);
            this.lbl_horaextra.Name = "lbl_horaextra";
            this.lbl_horaextra.Size = new System.Drawing.Size(69, 13);
            this.lbl_horaextra.TabIndex = 9;
            this.lbl_horaextra.Text = "Horas extras:";
            // 
            // lbl_liquido
            // 
            this.lbl_liquido.AutoSize = true;
            this.lbl_liquido.Location = new System.Drawing.Point(11, 265);
            this.lbl_liquido.Name = "lbl_liquido";
            this.lbl_liquido.Size = new System.Drawing.Size(72, 13);
            this.lbl_liquido.TabIndex = 10;
            this.lbl_liquido.Text = "Salario liquido";
            // 
            // frm_horas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 284);
            this.Controls.Add(this.lbl_liquido);
            this.Controls.Add(this.lbl_horaextra);
            this.Controls.Add(this.lbl_inss);
            this.Controls.Add(this.lbl_bruto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_horasextras);
            this.Controls.Add(this.cbx_classe);
            this.Controls.Add(this.txt_horas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Calcular);
            this.Name = "frm_horas";
            this.Text = "Horas Calculo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_horas;
        private System.Windows.Forms.ComboBox cbx_classe;
        private System.Windows.Forms.TextBox txt_horasextras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_bruto;
        private System.Windows.Forms.Label lbl_inss;
        private System.Windows.Forms.Label lbl_horaextra;
        private System.Windows.Forms.Label lbl_liquido;
    }
}


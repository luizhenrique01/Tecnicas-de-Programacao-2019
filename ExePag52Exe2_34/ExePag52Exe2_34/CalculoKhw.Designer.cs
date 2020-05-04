namespace ExePag52Exe2_34
{
    partial class CalculoKhw
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
            this.lbl_kwh = new System.Windows.Forms.Label();
            this.txt_identificacao = new System.Windows.Forms.TextBox();
            this.txt_kwh = new System.Windows.Forms.TextBox();
            this.lbl_consumidor = new System.Windows.Forms.Label();
            this.lbl_kwhmes = new System.Windows.Forms.Label();
            this.lbl_consumidorc = new System.Windows.Forms.Label();
            this.txt_kwhmes = new System.Windows.Forms.TextBox();
            this.cbx_cosumido = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_calcule
            // 
            this.btn_calcule.Location = new System.Drawing.Point(104, 193);
            this.btn_calcule.Name = "btn_calcule";
            this.btn_calcule.Size = new System.Drawing.Size(122, 23);
            this.btn_calcule.TabIndex = 0;
            this.btn_calcule.Text = "Calcule";
            this.btn_calcule.UseVisualStyleBackColor = true;
            this.btn_calcule.Click += new System.EventHandler(this.btn_calcule_Click);
            // 
            // lbl_kwh
            // 
            this.lbl_kwh.AutoSize = true;
            this.lbl_kwh.Location = new System.Drawing.Point(7, 19);
            this.lbl_kwh.Name = "lbl_kwh";
            this.lbl_kwh.Size = new System.Drawing.Size(133, 13);
            this.lbl_kwh.TabIndex = 1;
            this.lbl_kwh.Text = "Valor de 1KWh consumido";
            this.lbl_kwh.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_identificacao
            // 
            this.txt_identificacao.Location = new System.Drawing.Point(275, 55);
            this.txt_identificacao.Name = "txt_identificacao";
            this.txt_identificacao.Size = new System.Drawing.Size(70, 20);
            this.txt_identificacao.TabIndex = 2;
            this.txt_identificacao.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_kwh
            // 
            this.txt_kwh.Location = new System.Drawing.Point(275, 12);
            this.txt_kwh.Name = "txt_kwh";
            this.txt_kwh.Size = new System.Drawing.Size(70, 20);
            this.txt_kwh.TabIndex = 3;
            this.txt_kwh.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lbl_consumidor
            // 
            this.lbl_consumidor.AutoSize = true;
            this.lbl_consumidor.Location = new System.Drawing.Point(7, 62);
            this.lbl_consumidor.Name = "lbl_consumidor";
            this.lbl_consumidor.Size = new System.Drawing.Size(194, 13);
            this.lbl_consumidor.TabIndex = 4;
            this.lbl_consumidor.Text = "Numero de identificação do consumidor";
            this.lbl_consumidor.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_kwhmes
            // 
            this.lbl_kwhmes.AutoSize = true;
            this.lbl_kwhmes.Location = new System.Drawing.Point(7, 102);
            this.lbl_kwhmes.Name = "lbl_kwhmes";
            this.lbl_kwhmes.Size = new System.Drawing.Size(233, 13);
            this.lbl_kwhmes.TabIndex = 5;
            this.lbl_kwhmes.Text = "Quantidade de KWh consumidos durante 1 mês";
            this.lbl_kwhmes.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_consumidorc
            // 
            this.lbl_consumidorc.AutoSize = true;
            this.lbl_consumidorc.Location = new System.Drawing.Point(7, 151);
            this.lbl_consumidorc.Name = "lbl_consumidorc";
            this.lbl_consumidorc.Size = new System.Drawing.Size(147, 13);
            this.lbl_consumidorc.TabIndex = 6;
            this.lbl_consumidorc.Text = "Código do tipo de consumidor";
            this.lbl_consumidorc.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_kwhmes
            // 
            this.txt_kwhmes.Location = new System.Drawing.Point(275, 95);
            this.txt_kwhmes.Name = "txt_kwhmes";
            this.txt_kwhmes.Size = new System.Drawing.Size(70, 20);
            this.txt_kwhmes.TabIndex = 7;
            this.txt_kwhmes.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // cbx_cosumido
            // 
            this.cbx_cosumido.FormattingEnabled = true;
            this.cbx_cosumido.Items.AddRange(new object[] {
            "Residencial",
            "Comercial",
            "Industrial"});
            this.cbx_cosumido.Location = new System.Drawing.Point(275, 143);
            this.cbx_cosumido.Name = "cbx_cosumido";
            this.cbx_cosumido.Size = new System.Drawing.Size(70, 21);
            this.cbx_cosumido.TabIndex = 8;
            this.cbx_cosumido.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // CalculoKhw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 228);
            this.Controls.Add(this.cbx_cosumido);
            this.Controls.Add(this.txt_kwhmes);
            this.Controls.Add(this.lbl_consumidorc);
            this.Controls.Add(this.lbl_kwhmes);
            this.Controls.Add(this.lbl_consumidor);
            this.Controls.Add(this.txt_kwh);
            this.Controls.Add(this.txt_identificacao);
            this.Controls.Add(this.lbl_kwh);
            this.Controls.Add(this.btn_calcule);
            this.Name = "CalculoKhw";
            this.Text = "Calculo Kwh";
            this.Load += new System.EventHandler(this.CalculoKhw_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_calcule;
        private System.Windows.Forms.Label lbl_kwh;
        private System.Windows.Forms.TextBox txt_identificacao;
        private System.Windows.Forms.TextBox txt_kwh;
        private System.Windows.Forms.Label lbl_consumidor;
        private System.Windows.Forms.Label lbl_kwhmes;
        private System.Windows.Forms.Label lbl_consumidorc;
        private System.Windows.Forms.TextBox txt_kwhmes;
        private System.Windows.Forms.ComboBox cbx_cosumido;
    }
}


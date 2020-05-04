namespace Layout_34
{
    partial class Frm_Aluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Aluno));
            this.lbl_matricula = new System.Windows.Forms.Label();
            this.lbl_sexo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_nota = new System.Windows.Forms.Label();
            this.dtp_data = new System.Windows.Forms.DateTimePicker();
            this.cbx_sexo = new System.Windows.Forms.ComboBox();
            this.txt_matricula = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_nota = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_exlcuir = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_matricula
            // 
            this.lbl_matricula.AutoSize = true;
            this.lbl_matricula.Location = new System.Drawing.Point(12, 9);
            this.lbl_matricula.Name = "lbl_matricula";
            this.lbl_matricula.Size = new System.Drawing.Size(50, 13);
            this.lbl_matricula.TabIndex = 0;
            this.lbl_matricula.Text = "Matricula";
            // 
            // lbl_sexo
            // 
            this.lbl_sexo.AutoSize = true;
            this.lbl_sexo.Location = new System.Drawing.Point(243, 65);
            this.lbl_sexo.Name = "lbl_sexo";
            this.lbl_sexo.Size = new System.Drawing.Size(31, 13);
            this.lbl_sexo.TabIndex = 1;
            this.lbl_sexo.Text = "Sexo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data de nascimento";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(116, 9);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(35, 13);
            this.lbl_nome.TabIndex = 2;
            this.lbl_nome.Text = "Nome";
            // 
            // lbl_nota
            // 
            this.lbl_nota.AutoSize = true;
            this.lbl_nota.Location = new System.Drawing.Point(322, 65);
            this.lbl_nota.Name = "lbl_nota";
            this.lbl_nota.Size = new System.Drawing.Size(30, 13);
            this.lbl_nota.TabIndex = 5;
            this.lbl_nota.Text = "Nota";
            // 
            // dtp_data
            // 
            this.dtp_data.Location = new System.Drawing.Point(4, 91);
            this.dtp_data.Name = "dtp_data";
            this.dtp_data.Size = new System.Drawing.Size(227, 20);
            this.dtp_data.TabIndex = 6;
            // 
            // cbx_sexo
            // 
            this.cbx_sexo.FormattingEnabled = true;
            this.cbx_sexo.Items.AddRange(new object[] {
            "M",
            "F",
            "O"});
            this.cbx_sexo.Location = new System.Drawing.Point(246, 90);
            this.cbx_sexo.Name = "cbx_sexo";
            this.cbx_sexo.Size = new System.Drawing.Size(28, 21);
            this.cbx_sexo.TabIndex = 7;
            // 
            // txt_matricula
            // 
            this.txt_matricula.Location = new System.Drawing.Point(4, 28);
            this.txt_matricula.Name = "txt_matricula";
            this.txt_matricula.Size = new System.Drawing.Size(90, 20);
            this.txt_matricula.TabIndex = 8;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(119, 28);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(277, 20);
            this.txt_nome.TabIndex = 9;
            // 
            // txt_nota
            // 
            this.txt_nota.Location = new System.Drawing.Point(299, 91);
            this.txt_nota.Name = "txt_nota";
            this.txt_nota.Size = new System.Drawing.Size(100, 20);
            this.txt_nota.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(395, 140);
            this.dataGridView1.TabIndex = 11;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Image")));
            this.btn_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_buscar.Location = new System.Drawing.Point(143, 263);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(122, 34);
            this.btn_buscar.TabIndex = 13;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // btn_novo
            // 
            this.btn_novo.Image = ((System.Drawing.Image)(resources.GetObject("btn_novo.Image")));
            this.btn_novo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_novo.Location = new System.Drawing.Point(15, 263);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(122, 34);
            this.btn_novo.TabIndex = 14;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Image = ((System.Drawing.Image)(resources.GetObject("btn_alterar.Image")));
            this.btn_alterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_alterar.Location = new System.Drawing.Point(277, 263);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(122, 34);
            this.btn_alterar.TabIndex = 15;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            // 
            // btn_exlcuir
            // 
            this.btn_exlcuir.Image = ((System.Drawing.Image)(resources.GetObject("btn_exlcuir.Image")));
            this.btn_exlcuir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exlcuir.Location = new System.Drawing.Point(75, 303);
            this.btn_exlcuir.Name = "btn_exlcuir";
            this.btn_exlcuir.Size = new System.Drawing.Size(122, 34);
            this.btn_exlcuir.TabIndex = 16;
            this.btn_exlcuir.Text = "Excluir";
            this.btn_exlcuir.UseVisualStyleBackColor = true;
            // 
            // btn_voltar
            // 
            this.btn_voltar.Image = ((System.Drawing.Image)(resources.GetObject("btn_voltar.Image")));
            this.btn_voltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_voltar.Location = new System.Drawing.Point(203, 303);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(122, 34);
            this.btn_voltar.TabIndex = 17;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // Frm_Aluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 343);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_exlcuir);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_nota);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.txt_matricula);
            this.Controls.Add(this.cbx_sexo);
            this.Controls.Add(this.dtp_data);
            this.Controls.Add(this.lbl_nota);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.lbl_sexo);
            this.Controls.Add(this.lbl_matricula);
            this.Name = "Frm_Aluno";
            this.Text = "Cadastro de alunos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_matricula;
        private System.Windows.Forms.Label lbl_sexo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_nota;
        private System.Windows.Forms.DateTimePicker dtp_data;
        private System.Windows.Forms.ComboBox cbx_sexo;
        private System.Windows.Forms.TextBox txt_matricula;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_nota;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_exlcuir;
        private System.Windows.Forms.Button btn_voltar;
    }
}


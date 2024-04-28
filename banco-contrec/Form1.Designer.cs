namespace banco
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
            this.btnMostrarDados = new System.Windows.Forms.Button();
            this.btnSacar = new System.Windows.Forms.Button();
            this.btnSacarCom = new System.Windows.Forms.Button();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.BtnPJuridica = new System.Windows.Forms.Button();
            this.PessoaF = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMostrarDados
            // 
            this.btnMostrarDados.Location = new System.Drawing.Point(67, 101);
            this.btnMostrarDados.Name = "btnMostrarDados";
            this.btnMostrarDados.Size = new System.Drawing.Size(215, 44);
            this.btnMostrarDados.TabIndex = 0;
            this.btnMostrarDados.Text = "Mostrar dados bancários";
            this.btnMostrarDados.UseVisualStyleBackColor = true;
            this.btnMostrarDados.Click += new System.EventHandler(this.BtnMostrarDados_Click);
            // 
            // btnSacar
            // 
            this.btnSacar.Location = new System.Drawing.Point(67, 151);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(215, 44);
            this.btnSacar.TabIndex = 1;
            this.btnSacar.Text = "Sacar com retorno";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.BtnSacar_Click);
            // 
            // btnSacarCom
            // 
            this.btnSacarCom.Location = new System.Drawing.Point(67, 201);
            this.btnSacarCom.Name = "btnSacarCom";
            this.btnSacarCom.Size = new System.Drawing.Size(215, 44);
            this.btnSacarCom.TabIndex = 2;
            this.btnSacarCom.Text = "Sacar sem retorno de valor";
            this.btnSacarCom.UseVisualStyleBackColor = true;
            this.btnSacarCom.Click += new System.EventHandler(this.BtnSacarCom_Click);
            // 
            // btnDepositar
            // 
            this.btnDepositar.Location = new System.Drawing.Point(67, 251);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(215, 44);
            this.btnDepositar.TabIndex = 3;
            this.btnDepositar.Text = "Depositar saldo";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.BtnDepositar_Click);
            // 
            // BtnPJuridica
            // 
            this.BtnPJuridica.Location = new System.Drawing.Point(423, 101);
            this.BtnPJuridica.Name = "BtnPJuridica";
            this.BtnPJuridica.Size = new System.Drawing.Size(195, 44);
            this.BtnPJuridica.TabIndex = 4;
            this.BtnPJuridica.Text = "Mostrar dados";
            this.BtnPJuridica.UseVisualStyleBackColor = true;
            this.BtnPJuridica.Click += new System.EventHandler(this.BtnPJuridica_Click);
            // 
            // PessoaF
            // 
            this.PessoaF.AutoSize = true;
            this.PessoaF.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.PessoaF.Location = new System.Drawing.Point(62, 58);
            this.PessoaF.Name = "PessoaF";
            this.PessoaF.Size = new System.Drawing.Size(172, 29);
            this.PessoaF.TabIndex = 5;
            this.PessoaF.Text = "Pessoa Fisica";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.Location = new System.Drawing.Point(418, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pessoa Juridica";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 396);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PessoaF);
            this.Controls.Add(this.BtnPJuridica);
            this.Controls.Add(this.btnDepositar);
            this.Controls.Add(this.btnSacarCom);
            this.Controls.Add(this.btnSacar);
            this.Controls.Add(this.btnMostrarDados);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarDados;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.Button btnSacarCom;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.Button BtnPJuridica;
        private System.Windows.Forms.Label PessoaF;
        private System.Windows.Forms.Label label1;
    }
}


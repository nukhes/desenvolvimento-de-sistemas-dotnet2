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
            this.PessoaF = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPFisica = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPJuridica = new System.Windows.Forms.Button();
            this.btnDepositarPJ = new System.Windows.Forms.Button();
            this.btnSacarComPJ = new System.Windows.Forms.Button();
            this.btnSacarPJ = new System.Windows.Forms.Button();
            this.btnMostrarDadosPJ = new System.Windows.Forms.Button();
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
            this.label1.Location = new System.Drawing.Point(409, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pessoa Juridica";
            // 
            // btnPFisica
            // 
            this.btnPFisica.Location = new System.Drawing.Point(67, 371);
            this.btnPFisica.Name = "btnPFisica";
            this.btnPFisica.Size = new System.Drawing.Size(215, 44);
            this.btnPFisica.TabIndex = 7;
            this.btnPFisica.Text = "Cadastrar PF";
            this.btnPFisica.UseVisualStyleBackColor = true;
            this.btnPFisica.Click += new System.EventHandler(this.BtnPFisica_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(64, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(565, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "_________________________________________________________________________________" +
    "____________";
            // 
            // btnPJuridica
            // 
            this.btnPJuridica.Location = new System.Drawing.Point(414, 371);
            this.btnPJuridica.Name = "btnPJuridica";
            this.btnPJuridica.Size = new System.Drawing.Size(215, 44);
            this.btnPJuridica.TabIndex = 0;
            this.btnPJuridica.Text = "Cadastrar PJ";
            this.btnPJuridica.Click += new System.EventHandler(this.BtnPJuridica_Click_1);
            // 
            // btnDepositarPJ
            // 
            this.btnDepositarPJ.Location = new System.Drawing.Point(414, 251);
            this.btnDepositarPJ.Name = "btnDepositarPJ";
            this.btnDepositarPJ.Size = new System.Drawing.Size(215, 44);
            this.btnDepositarPJ.TabIndex = 12;
            this.btnDepositarPJ.Text = "Depositar saldo";
            this.btnDepositarPJ.UseVisualStyleBackColor = true;
            this.btnDepositarPJ.Click += new System.EventHandler(this.BtnDepositarPJ_Click);
            // 
            // btnSacarComPJ
            // 
            this.btnSacarComPJ.Location = new System.Drawing.Point(414, 201);
            this.btnSacarComPJ.Name = "btnSacarComPJ";
            this.btnSacarComPJ.Size = new System.Drawing.Size(215, 44);
            this.btnSacarComPJ.TabIndex = 11;
            this.btnSacarComPJ.Text = "Sacar sem retorno de valor";
            this.btnSacarComPJ.UseVisualStyleBackColor = true;
            this.btnSacarComPJ.Click += new System.EventHandler(this.BtnSacarComPJ_Click);
            // 
            // btnSacarPJ
            // 
            this.btnSacarPJ.Location = new System.Drawing.Point(414, 151);
            this.btnSacarPJ.Name = "btnSacarPJ";
            this.btnSacarPJ.Size = new System.Drawing.Size(215, 44);
            this.btnSacarPJ.TabIndex = 10;
            this.btnSacarPJ.Text = "Sacar com retorno";
            this.btnSacarPJ.UseVisualStyleBackColor = true;
            this.btnSacarPJ.Click += new System.EventHandler(this.BtnSacarPJ_Click);
            // 
            // btnMostrarDadosPJ
            // 
            this.btnMostrarDadosPJ.Location = new System.Drawing.Point(414, 101);
            this.btnMostrarDadosPJ.Name = "btnMostrarDadosPJ";
            this.btnMostrarDadosPJ.Size = new System.Drawing.Size(215, 44);
            this.btnMostrarDadosPJ.TabIndex = 9;
            this.btnMostrarDadosPJ.Text = "Mostrar dados bancários";
            this.btnMostrarDadosPJ.UseVisualStyleBackColor = true;
            this.btnMostrarDadosPJ.Click += new System.EventHandler(this.BtnMostrarDadosPJ_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 551);
            this.Controls.Add(this.btnDepositarPJ);
            this.Controls.Add(this.btnSacarComPJ);
            this.Controls.Add(this.btnSacarPJ);
            this.Controls.Add(this.btnMostrarDadosPJ);
            this.Controls.Add(this.btnPJuridica);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPFisica);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PessoaF);
            this.Controls.Add(this.btnDepositar);
            this.Controls.Add(this.btnSacarCom);
            this.Controls.Add(this.btnSacar);
            this.Controls.Add(this.btnMostrarDados);
            this.Name = "Form1";
            this.Text = "Banco";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarDados;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.Button btnSacarCom;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.Label PessoaF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPFisica;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPJuridica;
        private System.Windows.Forms.Button btnDepositarPJ;
        private System.Windows.Forms.Button btnSacarComPJ;
        private System.Windows.Forms.Button btnSacarPJ;
        private System.Windows.Forms.Button btnMostrarDadosPJ;
    }
}


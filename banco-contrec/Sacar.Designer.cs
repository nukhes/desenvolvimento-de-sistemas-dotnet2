namespace banco
{
    partial class Sacar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtValorDoSaque = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSacar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtValorDoSaque
            // 
            this.txtValorDoSaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtValorDoSaque.Location = new System.Drawing.Point(64, 70);
            this.txtValorDoSaque.Name = "txtValorDoSaque";
            this.txtValorDoSaque.Size = new System.Drawing.Size(395, 26);
            this.txtValorDoSaque.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(60, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valor do saque";
            // 
            // btnSacar
            // 
            this.btnSacar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnSacar.Location = new System.Drawing.Point(337, 196);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(122, 37);
            this.btnSacar.TabIndex = 2;
            this.btnSacar.Text = "Sacar";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.BtnSacar_Click);
            // 
            // Sacar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 273);
            this.Controls.Add(this.btnSacar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValorDoSaque);
            this.Name = "Sacar";
            this.Text = "Sacar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValorDoSaque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSacar;
    }
}
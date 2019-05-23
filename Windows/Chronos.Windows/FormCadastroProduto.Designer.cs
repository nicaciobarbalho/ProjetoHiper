namespace Chronos.Windows
{
    partial class FormCadastroProduto
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F);
            this.lblNome.Location = new System.Drawing.Point(19, 29);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(39, 15);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F);
            this.lblPreco.Location = new System.Drawing.Point(19, 61);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(37, 15);
            this.lblPreco.TabIndex = 3;
            this.lblPreco.Text = "Preço";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F);
            this.txtNome.Location = new System.Drawing.Point(83, 24);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(302, 24);
            this.txtNome.TabIndex = 7;
            // 
            // txtPreco
            // 
            this.txtPreco.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F);
            this.txtPreco.Location = new System.Drawing.Point(83, 58);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(106, 24);
            this.txtPreco.TabIndex = 10;
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F);
            this.btnFechar.Location = new System.Drawing.Point(418, 97);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(101, 25);
            this.btnFechar.TabIndex = 14;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F);
            this.btnConfirmar.Location = new System.Drawing.Point(19, 97);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(101, 25);
            this.btnConfirmar.TabIndex = 15;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // FormCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 137);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormCadastroProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar novo produto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnConfirmar;
    }
}
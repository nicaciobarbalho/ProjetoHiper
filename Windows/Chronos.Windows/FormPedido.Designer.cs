namespace Chronos.Windows
{
    partial class FormPedido
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gbItem = new System.Windows.Forms.GroupBox();
            this.lbProduto = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lbQuantidade = new System.Windows.Forms.Label();
            this.gbItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F);
            this.lblNome.Location = new System.Drawing.Point(14, 30);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(44, 15);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Cliente";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(72, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(434, 23);
            this.comboBox1.TabIndex = 2;
            // 
            // gbItem
            // 
            this.gbItem.Controls.Add(this.lbQuantidade);
            this.gbItem.Controls.Add(this.comboBox2);
            this.gbItem.Controls.Add(this.lbProduto);
            this.gbItem.Location = new System.Drawing.Point(17, 68);
            this.gbItem.Name = "gbItem";
            this.gbItem.Size = new System.Drawing.Size(500, 239);
            this.gbItem.TabIndex = 3;
            this.gbItem.TabStop = false;
            this.gbItem.Text = "Produto";
            // 
            // lbProduto
            // 
            this.lbProduto.AutoSize = true;
            this.lbProduto.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F);
            this.lbProduto.Location = new System.Drawing.Point(6, 31);
            this.lbProduto.Name = "lbProduto";
            this.lbProduto.Size = new System.Drawing.Size(50, 15);
            this.lbProduto.TabIndex = 2;
            this.lbProduto.Text = "Produto";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(64, 23);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(425, 23);
            this.comboBox2.TabIndex = 3;
            // 
            // lbQuantidade
            // 
            this.lbQuantidade.AutoSize = true;
            this.lbQuantidade.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F);
            this.lbQuantidade.Location = new System.Drawing.Point(6, 68);
            this.lbQuantidade.Name = "lbQuantidade";
            this.lbQuantidade.Size = new System.Drawing.Size(69, 15);
            this.lbQuantidade.TabIndex = 4;
            this.lbQuantidade.Text = "Quantidade";
            // 
            // FormPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 346);
            this.Controls.Add(this.gbItem);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblNome);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormPedido";
            this.Text = "Cadastrar novo pedido";
            this.gbItem.ResumeLayout(false);
            this.gbItem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox gbItem;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lbProduto;
        private System.Windows.Forms.Label lbQuantidade;
    }
}
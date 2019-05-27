namespace Chronos.Windows
{
    partial class FormPrincipal
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
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.incluirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sincronizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidoListarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidoIncluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F);
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.pedidoToolStripMenuItem,
            this.sincronizarToolStripMenuItem});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(730, 24);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuPrincipal";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarToolStripMenuItem,
            this.incluirToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listarToolStripMenuItem.Text = "Listar";
            this.listarToolStripMenuItem.Click += new System.EventHandler(this.listarToolStripMenuItem_Click);
            // 
            // incluirToolStripMenuItem
            // 
            this.incluirToolStripMenuItem.Name = "incluirToolStripMenuItem";
            this.incluirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.incluirToolStripMenuItem.Text = "Incluir";
            this.incluirToolStripMenuItem.Click += new System.EventHandler(this.incluirToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarToolStripMenuItem1,
            this.incluirToolStripMenuItem1});
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // listarToolStripMenuItem1
            // 
            this.listarToolStripMenuItem1.Name = "listarToolStripMenuItem1";
            this.listarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.listarToolStripMenuItem1.Text = "Listar";
            this.listarToolStripMenuItem1.Click += new System.EventHandler(this.listarToolStripMenuItem1_Click);
            // 
            // incluirToolStripMenuItem1
            // 
            this.incluirToolStripMenuItem1.Name = "incluirToolStripMenuItem1";
            this.incluirToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.incluirToolStripMenuItem1.Text = "Incluir";
            this.incluirToolStripMenuItem1.Click += new System.EventHandler(this.incluirToolStripMenuItem1_Click);
            // 
            // sincronizarToolStripMenuItem
            // 
            this.sincronizarToolStripMenuItem.Name = "sincronizarToolStripMenuItem";
            this.sincronizarToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.sincronizarToolStripMenuItem.Text = "Sincronizar";
            this.sincronizarToolStripMenuItem.Click += new System.EventHandler(this.sincronizarToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Chronos.Windows.Properties.Resources.kairc3b3s_e_cronos;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(730, 389);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pedidoToolStripMenuItem
            // 
            this.pedidoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pedidoListarToolStripMenuItem,
            this.pedidoIncluirToolStripMenuItem});
            this.pedidoToolStripMenuItem.Name = "pedidoToolStripMenuItem";
            this.pedidoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.pedidoToolStripMenuItem.Text = "Pedido";
            // 
            // pedidoListarToolStripMenuItem
            // 
            this.pedidoListarToolStripMenuItem.Name = "pedidoListarToolStripMenuItem";
            this.pedidoListarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pedidoListarToolStripMenuItem.Text = "Listar";
            // 
            // pedidoIncluirToolStripMenuItem
            // 
            this.pedidoIncluirToolStripMenuItem.Name = "pedidoIncluirToolStripMenuItem";
            this.pedidoIncluirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pedidoIncluirToolStripMenuItem.Text = "Incluir";
            this.pedidoIncluirToolStripMenuItem.Click += new System.EventHandler(this.pedidoIncluirToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 413);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuPrincipal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chronos";
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incluirToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem incluirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sincronizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidoListarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidoIncluirToolStripMenuItem;
    }
}


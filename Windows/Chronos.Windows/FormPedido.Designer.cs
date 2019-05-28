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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblNome = new System.Windows.Forms.Label();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.gbItem = new System.Windows.Forms.GroupBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.txtValorLiquido = new Chronos.Windows.Componentes.TextBoxNumerico(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txtValorBruto = new Chronos.Windows.Componentes.TextBoxNumerico(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtValorDesconto = new Chronos.Windows.Componentes.TextBoxNumerico(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lbValorUnitario = new System.Windows.Forms.Label();
            this.txtValorUnitario = new Chronos.Windows.Componentes.TextBoxNumerico(this.components);
            this.txtQuantidade = new Chronos.Windows.Componentes.TextBoxNumerico(this.components);
            this.lbQuantidade = new System.Windows.Forms.Label();
            this.cboProduto = new System.Windows.Forms.ComboBox();
            this.lbProduto = new System.Windows.Forms.Label();
            this.grvProdutos = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorDesconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorBruto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorLiquido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbProdutos = new System.Windows.Forms.GroupBox();
            this.gbTotais = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotaisValorLiquido = new Chronos.Windows.Componentes.TextBoxNumerico(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotaisValorBruto = new Chronos.Windows.Componentes.TextBoxNumerico(this.components);
            this.txtTotaisValorDesconto = new Chronos.Windows.Componentes.TextBoxNumerico(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.gbItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvProdutos)).BeginInit();
            this.gbProdutos.SuspendLayout();
            this.gbTotais.SuspendLayout();
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
            // cboCliente
            // 
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(72, 23);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(493, 23);
            this.cboCliente.TabIndex = 2;
            this.cboCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboCliente_KeyDown);
            // 
            // gbItem
            // 
            this.gbItem.Controls.Add(this.btnAdicionar);
            this.gbItem.Controls.Add(this.txtValorLiquido);
            this.gbItem.Controls.Add(this.label3);
            this.gbItem.Controls.Add(this.txtValorBruto);
            this.gbItem.Controls.Add(this.label2);
            this.gbItem.Controls.Add(this.txtValorDesconto);
            this.gbItem.Controls.Add(this.label1);
            this.gbItem.Controls.Add(this.lbValorUnitario);
            this.gbItem.Controls.Add(this.txtValorUnitario);
            this.gbItem.Controls.Add(this.txtQuantidade);
            this.gbItem.Controls.Add(this.lbQuantidade);
            this.gbItem.Controls.Add(this.cboProduto);
            this.gbItem.Controls.Add(this.lbProduto);
            this.gbItem.Location = new System.Drawing.Point(6, 68);
            this.gbItem.Name = "gbItem";
            this.gbItem.Size = new System.Drawing.Size(719, 149);
            this.gbItem.TabIndex = 3;
            this.gbItem.TabStop = false;
            this.gbItem.Text = "Produto";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Enabled = false;
            this.btnAdicionar.Location = new System.Drawing.Point(484, 113);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 14;
            this.btnAdicionar.Text = "&Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // txtValorLiquido
            // 
            this.txtValorLiquido.DecimalNumber = 2;
            this.txtValorLiquido.Enabled = false;
            this.txtValorLiquido.Groupsep = '.';
            this.txtValorLiquido.Location = new System.Drawing.Point(253, 111);
            this.txtValorLiquido.MaxCheck = false;
            this.txtValorLiquido.MaxValue = 10D;
            this.txtValorLiquido.MinCheck = true;
            this.txtValorLiquido.MinValue = 0D;
            this.txtValorLiquido.Name = "txtValorLiquido";
            this.txtValorLiquido.NumberFormat = NumberFormat.DecimalValue;
            this.txtValorLiquido.Size = new System.Drawing.Size(117, 24);
            this.txtValorLiquido.TabIndex = 13;
            this.txtValorLiquido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorLiquido.Usegroupseparator = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F);
            this.label3.Location = new System.Drawing.Point(187, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "V. Líquido";
            // 
            // txtValorBruto
            // 
            this.txtValorBruto.DecimalNumber = 2;
            this.txtValorBruto.Enabled = false;
            this.txtValorBruto.Groupsep = '.';
            this.txtValorBruto.Location = new System.Drawing.Point(64, 112);
            this.txtValorBruto.MaxCheck = false;
            this.txtValorBruto.MaxValue = 10D;
            this.txtValorBruto.MinCheck = true;
            this.txtValorBruto.MinValue = 0D;
            this.txtValorBruto.Name = "txtValorBruto";
            this.txtValorBruto.NumberFormat = NumberFormat.DecimalValue;
            this.txtValorBruto.Size = new System.Drawing.Size(117, 24);
            this.txtValorBruto.TabIndex = 11;
            this.txtValorBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorBruto.Usegroupseparator = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F);
            this.label2.Location = new System.Drawing.Point(7, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "V. Bruto";
            // 
            // txtValorDesconto
            // 
            this.txtValorDesconto.DecimalNumber = 2;
            this.txtValorDesconto.Groupsep = '.';
            this.txtValorDesconto.Location = new System.Drawing.Point(253, 81);
            this.txtValorDesconto.MaxCheck = false;
            this.txtValorDesconto.MaxValue = 10D;
            this.txtValorDesconto.MinCheck = true;
            this.txtValorDesconto.MinValue = 0D;
            this.txtValorDesconto.Name = "txtValorDesconto";
            this.txtValorDesconto.NumberFormat = NumberFormat.DecimalValue;
            this.txtValorDesconto.Size = new System.Drawing.Size(117, 24);
            this.txtValorDesconto.TabIndex = 9;
            this.txtValorDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorDesconto.Usegroupseparator = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F);
            this.label1.Location = new System.Drawing.Point(187, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "V. Desc";
            // 
            // lbValorUnitario
            // 
            this.lbValorUnitario.AutoSize = true;
            this.lbValorUnitario.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F);
            this.lbValorUnitario.Location = new System.Drawing.Point(6, 61);
            this.lbValorUnitario.Name = "lbValorUnitario";
            this.lbValorUnitario.Size = new System.Drawing.Size(42, 15);
            this.lbValorUnitario.TabIndex = 7;
            this.lbValorUnitario.Text = "V. Unit";
            // 
            // txtValorUnitario
            // 
            this.txtValorUnitario.DecimalNumber = 2;
            this.txtValorUnitario.Enabled = false;
            this.txtValorUnitario.Groupsep = '.';
            this.txtValorUnitario.Location = new System.Drawing.Point(64, 52);
            this.txtValorUnitario.MaxCheck = false;
            this.txtValorUnitario.MaxValue = 10D;
            this.txtValorUnitario.MinCheck = true;
            this.txtValorUnitario.MinValue = 0D;
            this.txtValorUnitario.Name = "txtValorUnitario";
            this.txtValorUnitario.NumberFormat = NumberFormat.DecimalValue;
            this.txtValorUnitario.Size = new System.Drawing.Size(117, 24);
            this.txtValorUnitario.TabIndex = 6;
            this.txtValorUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorUnitario.Usegroupseparator = true;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.DecimalNumber = 2;
            this.txtQuantidade.Groupsep = '.';
            this.txtQuantidade.Location = new System.Drawing.Point(64, 82);
            this.txtQuantidade.MaxCheck = false;
            this.txtQuantidade.MaxValue = 10D;
            this.txtQuantidade.MinCheck = true;
            this.txtQuantidade.MinValue = 0D;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.NumberFormat = NumberFormat.DecimalValue;
            this.txtQuantidade.Size = new System.Drawing.Size(117, 24);
            this.txtQuantidade.TabIndex = 5;
            this.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQuantidade.Usegroupseparator = true;
            // 
            // lbQuantidade
            // 
            this.lbQuantidade.AutoSize = true;
            this.lbQuantidade.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F);
            this.lbQuantidade.Location = new System.Drawing.Point(6, 91);
            this.lbQuantidade.Name = "lbQuantidade";
            this.lbQuantidade.Size = new System.Drawing.Size(27, 15);
            this.lbQuantidade.TabIndex = 4;
            this.lbQuantidade.Text = "Qtd";
            // 
            // cboProduto
            // 
            this.cboProduto.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cboProduto.FormattingEnabled = true;
            this.cboProduto.Location = new System.Drawing.Point(64, 23);
            this.cboProduto.Name = "cboProduto";
            this.cboProduto.Size = new System.Drawing.Size(495, 23);
            this.cboProduto.TabIndex = 3;
            this.cboProduto.SelectedValueChanged += new System.EventHandler(this.cboProduto_SelectedValueChanged);
            this.cboProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboProduto_KeyDown);
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
            // grvProdutos
            // 
            this.grvProdutos.AllowUserToAddRows = false;
            this.grvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.ValorUnitario,
            this.Quantidade,
            this.ValorDesconto,
            this.ValorBruto,
            this.ValorLiquido});
            this.grvProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvProdutos.Location = new System.Drawing.Point(3, 20);
            this.grvProdutos.Name = "grvProdutos";
            this.grvProdutos.ReadOnly = true;
            this.grvProdutos.Size = new System.Drawing.Size(713, 122);
            this.grvProdutos.TabIndex = 4;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Produto";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Nome.DefaultCellStyle = dataGridViewCellStyle1;
            this.Nome.HeaderText = "Produto";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 200;
            // 
            // ValorUnitario
            // 
            this.ValorUnitario.DataPropertyName = "ValorUnitario";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            this.ValorUnitario.DefaultCellStyle = dataGridViewCellStyle2;
            this.ValorUnitario.HeaderText = "V. Unit";
            this.ValorUnitario.Name = "ValorUnitario";
            this.ValorUnitario.ReadOnly = true;
            // 
            // Quantidade
            // 
            this.Quantidade.DataPropertyName = "Quantidade";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            this.Quantidade.DefaultCellStyle = dataGridViewCellStyle3;
            this.Quantidade.HeaderText = "Qtd";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            // 
            // ValorDesconto
            // 
            this.ValorDesconto.DataPropertyName = "ValorDesconto";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            this.ValorDesconto.DefaultCellStyle = dataGridViewCellStyle4;
            this.ValorDesconto.HeaderText = "V. Desc";
            this.ValorDesconto.Name = "ValorDesconto";
            this.ValorDesconto.ReadOnly = true;
            this.ValorDesconto.Width = 70;
            // 
            // ValorBruto
            // 
            this.ValorBruto.DataPropertyName = "ValorBruto";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            this.ValorBruto.DefaultCellStyle = dataGridViewCellStyle5;
            this.ValorBruto.HeaderText = "V. Bruto";
            this.ValorBruto.Name = "ValorBruto";
            this.ValorBruto.ReadOnly = true;
            // 
            // ValorLiquido
            // 
            this.ValorLiquido.DataPropertyName = "ValorLiquido";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            this.ValorLiquido.DefaultCellStyle = dataGridViewCellStyle6;
            this.ValorLiquido.HeaderText = "V. Líquido";
            this.ValorLiquido.Name = "ValorLiquido";
            this.ValorLiquido.ReadOnly = true;
            // 
            // gbProdutos
            // 
            this.gbProdutos.Controls.Add(this.grvProdutos);
            this.gbProdutos.Location = new System.Drawing.Point(6, 223);
            this.gbProdutos.Name = "gbProdutos";
            this.gbProdutos.Size = new System.Drawing.Size(719, 145);
            this.gbProdutos.TabIndex = 5;
            this.gbProdutos.TabStop = false;
            this.gbProdutos.Text = "Produtos";
            // 
            // gbTotais
            // 
            this.gbTotais.Controls.Add(this.label6);
            this.gbTotais.Controls.Add(this.txtTotaisValorLiquido);
            this.gbTotais.Controls.Add(this.label4);
            this.gbTotais.Controls.Add(this.txtTotaisValorBruto);
            this.gbTotais.Controls.Add(this.txtTotaisValorDesconto);
            this.gbTotais.Controls.Add(this.label5);
            this.gbTotais.Location = new System.Drawing.Point(6, 371);
            this.gbTotais.Name = "gbTotais";
            this.gbTotais.Size = new System.Drawing.Size(713, 44);
            this.gbTotais.TabIndex = 6;
            this.gbTotais.TabStop = false;
            this.gbTotais.Text = "Totais";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F);
            this.label6.Location = new System.Drawing.Point(7, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "V. Bruto";
            // 
            // txtTotaisValorLiquido
            // 
            this.txtTotaisValorLiquido.DecimalNumber = 2;
            this.txtTotaisValorLiquido.Enabled = false;
            this.txtTotaisValorLiquido.Groupsep = '.';
            this.txtTotaisValorLiquido.Location = new System.Drawing.Point(442, 11);
            this.txtTotaisValorLiquido.MaxCheck = false;
            this.txtTotaisValorLiquido.MaxValue = 10D;
            this.txtTotaisValorLiquido.MinCheck = true;
            this.txtTotaisValorLiquido.MinValue = 0D;
            this.txtTotaisValorLiquido.Name = "txtTotaisValorLiquido";
            this.txtTotaisValorLiquido.NumberFormat = NumberFormat.DecimalValue;
            this.txtTotaisValorLiquido.Size = new System.Drawing.Size(117, 24);
            this.txtTotaisValorLiquido.TabIndex = 18;
            this.txtTotaisValorLiquido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotaisValorLiquido.Usegroupseparator = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F);
            this.label4.Location = new System.Drawing.Point(376, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "V. Líquido";
            // 
            // txtTotaisValorBruto
            // 
            this.txtTotaisValorBruto.DecimalNumber = 2;
            this.txtTotaisValorBruto.Enabled = false;
            this.txtTotaisValorBruto.Groupsep = '.';
            this.txtTotaisValorBruto.Location = new System.Drawing.Point(64, 11);
            this.txtTotaisValorBruto.MaxCheck = false;
            this.txtTotaisValorBruto.MaxValue = 10D;
            this.txtTotaisValorBruto.MinCheck = true;
            this.txtTotaisValorBruto.MinValue = 0D;
            this.txtTotaisValorBruto.Name = "txtTotaisValorBruto";
            this.txtTotaisValorBruto.NumberFormat = NumberFormat.DecimalValue;
            this.txtTotaisValorBruto.Size = new System.Drawing.Size(117, 24);
            this.txtTotaisValorBruto.TabIndex = 16;
            this.txtTotaisValorBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotaisValorBruto.Usegroupseparator = true;
            // 
            // txtTotaisValorDesconto
            // 
            this.txtTotaisValorDesconto.DecimalNumber = 2;
            this.txtTotaisValorDesconto.Enabled = false;
            this.txtTotaisValorDesconto.Groupsep = '.';
            this.txtTotaisValorDesconto.Location = new System.Drawing.Point(253, 11);
            this.txtTotaisValorDesconto.MaxCheck = false;
            this.txtTotaisValorDesconto.MaxValue = 10D;
            this.txtTotaisValorDesconto.MinCheck = true;
            this.txtTotaisValorDesconto.MinValue = 0D;
            this.txtTotaisValorDesconto.Name = "txtTotaisValorDesconto";
            this.txtTotaisValorDesconto.NumberFormat = NumberFormat.DecimalValue;
            this.txtTotaisValorDesconto.Size = new System.Drawing.Size(117, 24);
            this.txtTotaisValorDesconto.TabIndex = 15;
            this.txtTotaisValorDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotaisValorDesconto.Usegroupseparator = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F);
            this.label5.Location = new System.Drawing.Point(187, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "V. Desc";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Enabled = false;
            this.btnConfirmar.Location = new System.Drawing.Point(540, 421);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 15;
            this.btnConfirmar.Text = "&Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(644, 421);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 16;
            this.btnFechar.Text = "&Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // FormPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 453);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.gbTotais);
            this.Controls.Add(this.gbProdutos);
            this.Controls.Add(this.gbItem);
            this.Controls.Add(this.cboCliente);
            this.Controls.Add(this.lblNome);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar novo pedido";
            this.gbItem.ResumeLayout(false);
            this.gbItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvProdutos)).EndInit();
            this.gbProdutos.ResumeLayout(false);
            this.gbTotais.ResumeLayout(false);
            this.gbTotais.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.GroupBox gbItem;
        private System.Windows.Forms.ComboBox cboProduto;
        private System.Windows.Forms.Label lbProduto;
        private System.Windows.Forms.Label lbQuantidade;
        private Componentes.TextBoxNumerico txtQuantidade;
        private System.Windows.Forms.Label lbValorUnitario;
        private Componentes.TextBoxNumerico txtValorUnitario;
        private System.Windows.Forms.Button btnAdicionar;
        private Componentes.TextBoxNumerico txtValorLiquido;
        private System.Windows.Forms.Label label3;
        private Componentes.TextBoxNumerico txtValorBruto;
        private System.Windows.Forms.Label label2;
        private Componentes.TextBoxNumerico txtValorDesconto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grvProdutos;
        private System.Windows.Forms.GroupBox gbProdutos;
        private System.Windows.Forms.GroupBox gbTotais;
        private System.Windows.Forms.Label label6;
        private Componentes.TextBoxNumerico txtTotaisValorLiquido;
        private System.Windows.Forms.Label label4;
        private Componentes.TextBoxNumerico txtTotaisValorBruto;
        private Componentes.TextBoxNumerico txtTotaisValorDesconto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorDesconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorBruto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorLiquido;
    }
}
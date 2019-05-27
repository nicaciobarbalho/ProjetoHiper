using Chronos.Windows.Library.BO;
using Chronos.Windows.Library.CO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chronos.Windows
{
    public partial class FormPedido : Form
    {
        int id = 0;
        public FormPedido()
        {
            InitializeComponent();
        }

        public FormPedido(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && cboCliente.Text.Length > 2 && !String.IsNullOrEmpty(cboCliente.Text))
            {
                var cliente = new ClienteCO().ClientePorNome(cboCliente.Text);
                cboCliente.DataSource = cliente;

                cboCliente.DisplayMember = "Nome";

                cboCliente.ValueMember = "Id";
            }           
            else if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete)
            {
                this.LimparCliente();
            }                      
        }

        private void LimparCliente()
        {
            cboCliente.ValueMember = null;
            cboCliente.DisplayMember = null;
            cboCliente.DataSource = null;
            cboCliente.Text = null;
            cboCliente.Items.Add("");
        }
        private void LimparProduto()
        {
            cboProduto.ValueMember = null;
            cboProduto.DisplayMember = null;
            cboProduto.DataSource = null;
            cboProduto.Text = null;
            cboProduto.Items.Add("");
            btnAdicionar.Enabled = false;
            txtValorUnitario.Text = "";
            txtQuantidade.Text = "";
            txtValorBruto.Text = "";
            txtValorDesconto.Text = "";
            txtValorLiquido.Text = "";
        }

        private void cboProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && cboProduto.Text.Length > 2 && !String.IsNullOrEmpty(cboProduto.Text))
            {
                var produto = new ProdutoCO().ProdutoPorNome(cboProduto.Text);
                cboProduto.DataSource = produto;
                cboProduto.DisplayMember = "Nome";
                cboProduto.ValueMember = "Id";
                btnAdicionar.Enabled = produto.Count > 0;
            }
            else if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete)
            {                
                this.LimparProduto();
            }
        }        

        private void cboProduto_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboProduto.SelectedItem != null && cboProduto.SelectedItem is ProdutoBO)
            {
                var produto = (ProdutoBO)cboProduto.SelectedItem;
                txtValorUnitario.Text = produto.Preco.ToString();
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (cboCliente.SelectedValue != null && cboCliente.SelectedItem is ClienteBO &&
               cboProduto.SelectedItem != null && cboProduto.SelectedItem is ProdutoBO &&
               (!string.IsNullOrWhiteSpace(txtQuantidade.Text) && decimal.Parse(txtQuantidade.Text) > 0)
              )
            {
                var cliente = (ClienteBO)cboCliente.SelectedItem;
                var produto = (ProdutoBO)cboProduto.SelectedItem;

                var pedido = new PedidoBO();
                pedido.Id = this.id;
                pedido.ClienteId = cliente.Id;

                var pedidoItem = new PedidoItemBO();
                pedidoItem.Id = 0;
                pedidoItem.PedidoId = this.id;
                pedidoItem.ProdutoId = produto.Id;
                pedidoItem.Quantidade = decimal.Parse(txtQuantidade.Text);
                pedidoItem.ValorUnitario = produto.Preco;
                pedidoItem.ValorBruto = (pedidoItem.ValorUnitario * pedidoItem.Quantidade);
                pedidoItem.ValorDesconto = !string.IsNullOrWhiteSpace(txtValorDesconto.Text) ? decimal.Parse(txtValorDesconto.Text) : 0;
                pedidoItem.ValorLiquido = (pedidoItem.ValorBruto - pedidoItem.ValorDesconto);

                var itens = new PedidoItemCO().Adicionar(pedido, pedidoItem);

                this.id = pedido.Id;
                this.CarregarItens(itens);
                this.CarregarTotais(pedido);                
                this.LimparProduto();
                cboProduto.Focus();
            }
        }

        private void CarregarItens(List<PedidoItemBO> itens)
        {                       
            var results = (from i in itens.AsParallel()
                                   join p in new ProdutoCO().Produtos().AsParallel()
                                      on i.ProdutoId equals p.Id
                                   select new
                                   {
                                       Produto = p.Nome,
                                       i.Quantidade,
                                       i.ValorBruto,
                                       i.ValorDesconto,
                                       i.ValorLiquido,
                                       i.ValorUnitario
                                   });

            var x = results.ToList();
            this.grvProdutos.DataSource = x;            
        }

        private void CarregarTotais(PedidoBO pedido)
        {
            txtTotaisValorBruto.Text = pedido.ValorBruto.ToString();
            txtTotaisValorDesconto.Text = pedido.ValorDesconto.ToString();
            txtTotaisValorLiquido.Text = pedido.ValorLiquido.ToString();

            this.HabilitaControles();
        }

        private void HabilitaControles()
        {
            cboCliente.Enabled = !(this.id > 0);
            btnConfirmar.Enabled = (this.id > 0) && new PedidoCO().PedidoPorId(this.id).PedidoSituacaoId != 2 && grvProdutos.Rows.Count > 0;
        }

        private void LimparTotais()
        {
            txtTotaisValorBruto.Text = "";
            txtTotaisValorDesconto.Text = "";
            txtTotaisValorLiquido.Text = "";
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            this.id = 0;           
        }
    }
}

using Chronos.Web.Ddd.Domain.Base.Entities;

namespace Chronos.Web.Ddd.Domain.Pedidos
{
    internal class PedidoItem : Entity
    {
        protected PedidoItem() { }

        internal PedidoItem(int id, int pedidoId, int produtoId, decimal quantidade, decimal valorUnitario, decimal valorBruto, decimal valorLiquido, decimal valorDesconto)
        {
            base.SetId(id);
            this.SetPedidoId(pedidoId);
            this.SetProdutoId(pedidoId);
            this.SetQuantidade(quantidade);
            this.SetValorUnitario(valorUnitario);
            this.SetValorBruto(valorBruto);
            this.SetValorLiquido(valorLiquido);
            this.SetValorDesconto(valorDesconto);
        }

        public int PedidoId { get; private set; }
        public int ProdutoId { get; private set; }
        public decimal Quantidade { get; private set; }
        public decimal ValorUnitario { get; private set; }
        public decimal ValorBruto { get; private set; }
        public decimal ValorLiquido { get; private set; }
        public decimal ValorDesconto { get; private set; }

        public void SetPedidoId(int pedidoId)
        {
            this.PedidoId = pedidoId;
        }
        public void SetProdutoId(int pedidoId)
        {
            this.PedidoId = pedidoId;
        }

        public void SetQuantidade(decimal quantidade)
        {
            this.Quantidade = quantidade;
        }

        public void SetValorUnitario(decimal valorUnitario)
        {
            this.ValorUnitario = valorUnitario;
        }
        public void SetValorBruto(decimal valorBruto)
        {
            this.ValorBruto = valorBruto;
        }

        public void SetValorLiquido(decimal valorLiquido)
        {
            this.ValorLiquido = valorLiquido;
        }
        public void SetValorDesconto(decimal valorDesconto)
        {
            this.ValorDesconto = valorDesconto;
        }
    }
}

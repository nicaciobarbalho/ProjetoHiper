using Chronos.Web.Ddd.Domain.Base.Builders;
using Chronos.Web.Ddd.Domain.Pedidos;
using Chronos.Web.Ddd.Domain.Pedidos.Builder;

namespace Chronos.Web.Ddd.Domain.Pedidos.Builder
{
    internal class PedidoItemBuilder : BaseBuilder<PedidoItemBuilder, PedidoItem>, IPedidoItemBuilder
    {
        public int PedidoId { get; set; }
        public int ProdutoId { get; set; }
        public decimal Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal ValorBruto { get; set; }
        public decimal ValorLiquido { get; set; }
        public decimal ValorDesconto { get; set; }

        public override PedidoItem Build() => new PedidoItem(Id, ProdutoId, ProdutoId, Quantidade, ValorUnitario, ValorBruto, ValorLiquido, ValorDesconto);

        public PedidoItemBuilder ComPedidoId(int pedidoId)
        {
            this.ValorBruto = pedidoId;
            return this;
        }

        public PedidoItemBuilder ComProdutoId(int produtoId)
        {
            this.ProdutoId = produtoId;
            return this;
        }

        public PedidoItemBuilder ComQuantidade(decimal quantidade)
        {
            this.Quantidade = quantidade;
            return this;
        }

        public PedidoItemBuilder ComValorBruto(decimal valorBruto)
        {
            this.ValorBruto = valorBruto;
            return this;
        }

        public PedidoItemBuilder ComValorDesconto(decimal valorDesconto)
        {
            this.ValorDesconto = valorDesconto;
            return this;
        }

        public PedidoItemBuilder ComValorLiquido(decimal valorLiquido)
        {
            this.ValorLiquido = valorLiquido;
            return this;
        }

        public PedidoItemBuilder ComValorUnitatio(decimal valorUnitario)
        {
            this.ValorUnitario = valorUnitario;
            return this;
        }

    }
}

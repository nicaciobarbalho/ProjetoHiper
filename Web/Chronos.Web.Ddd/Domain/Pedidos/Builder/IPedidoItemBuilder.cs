using Chronos.Web.Ddd.Domain.Base.Builders;
using Chronos.Web.Ddd.Domain.Pedidos.Builder;

namespace Chronos.Web.Ddd.Domain.Pedidos.Builder
{
    internal interface IPedidoItemBuilder : IBaseBuilder<PedidoItemBuilder, PedidoItem>
    {
        PedidoItemBuilder ComPedidoId(int pedidoId);
        PedidoItemBuilder ComProdutoId(int produtoId);
        PedidoItemBuilder ComQuantidade(decimal quantidade);
        PedidoItemBuilder ComValorUnitatio(decimal valorUnitario);
        PedidoItemBuilder ComValorBruto(decimal valorBruto);
        PedidoItemBuilder ComValorLiquido(decimal valorLiquido);
        PedidoItemBuilder ComValorDesconto(decimal valorDesconto);
    }
}

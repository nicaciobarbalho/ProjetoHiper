using Chronos.Web.Ddd.Domain.Base.Builders;

namespace Chronos.Web.Ddd.Domain.Pedidos.Builder
{

    internal interface IPedidoBuilder : IBaseBuilder<PedidoBuilder, Pedido>
    {        
        PedidoBuilder ComClienteId(int clienteId);

        PedidoBuilder ComValorBruto(decimal valorBruto);

        PedidoBuilder ComValorLiquido(decimal valorLiquido);

        PedidoBuilder ComValorDesconto(decimal valorDesconto);
       
    }
}

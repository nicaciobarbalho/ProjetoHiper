using Chronos.Web.Ddd.Domain.Base.Builders;

namespace Chronos.Web.Ddd.Domain.Pedidos.Builder
{  
    internal class PedidoBuilder : BaseBuilder<PedidoBuilder, Pedido>, IPedidoBuilder
    {
        public int ClienteId { get; set; }
        public decimal ValorBruto { get; set; }
        public decimal ValorLiquido { get; set; }
        public decimal ValorDesconto { get; set; }

        public override Pedido Build() => new Pedido(Id, ClienteId, ValorBruto, ValorLiquido, ValorDesconto);

        public PedidoBuilder ComClienteId(int clienteId)
        {
            this.ClienteId = clienteId;
            return this;
        }

        public PedidoBuilder ComValorBruto(decimal valorBruto)
        {
            this.ValorBruto = valorBruto;
            return this;
        }

        public PedidoBuilder ComValorLiquido(decimal valorLiquido)
        {
            this.ValorLiquido = valorLiquido;
            return this;
        }
        public PedidoBuilder ComValorDesconto(decimal valorDesconto)
        {
            this.ValorDesconto = valorDesconto;
            return this;
        }
    }
}

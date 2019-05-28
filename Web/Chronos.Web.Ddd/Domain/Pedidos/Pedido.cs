using Chronos.Web.Ddd.Domain.Base.Entities;

namespace Chronos.Web.Ddd.Domain.Pedidos
{
    internal class Pedido : Entity
    {
        protected Pedido() { }

        internal Pedido(int id, int clienteId, decimal valorBruto, decimal valorLiquido, decimal valorDesconto)
        {
            base.SetId(id);
            this.SetClienteId(clienteId);
            this.SetValorBruto(valorBruto);
            this.SetValorLiquido(valorLiquido);
            this.SetValorDesconto(valorDesconto);            
        }

        public int ClienteId { get; private set; }
        public decimal ValorBruto { get; private set; }
        public decimal ValorLiquido { get; private set; }
        public decimal ValorDesconto { get; private set; }

        public void SetClienteId(int clienteId)
        {
            this.ClienteId = clienteId;
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
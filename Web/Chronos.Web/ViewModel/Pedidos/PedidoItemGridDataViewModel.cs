using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chronos.Web.ViewModel.Pedidos
{
    public class PedidoItemGridDataViewModel
    {
        public int Id { get; set; }
        public int PedidoId { get; set; }
        public int ProdutoId { get; set; }
        public decimal Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal ValorBruto { get; set; }
        public decimal ValorLiquido { get; set; }
        public decimal ValorDesconto { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace Chronos.Web.ViewModel.Pedidos
{
    public class PedidosGridDataViewModel
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public decimal ValorBruto { get; set; }
        public decimal ValorLiquido { get; set; }
        public decimal ValorDesconto { get; set; }
        
        public List<PedidoItemGridDataViewModel> Itens { get; set; }
    }
}
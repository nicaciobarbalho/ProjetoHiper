using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chronos.Windows.Library.BO
{
    public class PedidoItemBO 
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
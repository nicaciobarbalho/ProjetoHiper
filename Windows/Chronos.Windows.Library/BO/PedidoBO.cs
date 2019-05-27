using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chronos.Windows.Library.BO
{
    public class PedidoBO
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public decimal ValorBruto { get; set; }
        public decimal ValorLiquido { get; set; }
        public decimal ValorDesconto { get; set; }
        public int PedidoSituacaoId { get; set; }

        
    }
}
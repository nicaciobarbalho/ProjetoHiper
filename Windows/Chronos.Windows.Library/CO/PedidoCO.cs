using Chronos.Windows.Library.BO;
using Chronos.Windows.Library.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chronos.Windows.Library.CO
{
    public class PedidoCO
    {
        public int Adicionar(PedidoBO pedido)
        {            
          return new PedidoDAO().Adicionar(pedido);            
        }

        public PedidoBO PedidoPorId(int id)
        {
            var pedido = new PedidoBO();

            foreach (DataRow dr in new PedidoDAO().PedidoPorId(id).Rows)
            {
                pedido.Id = int.Parse(dr["id"].ToString());
                pedido.ClienteId = int.Parse(dr["cliente_id"].ToString());
                pedido.ValorBruto = decimal.Parse(dr["valor_bruto"].ToString());
                pedido.ValorLiquido = decimal.Parse(dr["valor_liquido"].ToString());
                pedido.ValorDesconto = decimal.Parse(dr["valor_desconto"].ToString());
                pedido.PedidoSituacaoId = int.Parse(dr["pedido_situacao_id"].ToString());                
            }

            return pedido;
        }
    }
}

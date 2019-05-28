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
   public class PedidoSituacaoCO
    {
        public List<PedidoSituacaoBO> Listar()
        {
            var result = new List<PedidoSituacaoBO>();

            foreach (DataRow dr in new PedidoSituacaoDAO().Listar().Rows)
            {
                var situacao = new PedidoSituacaoBO();
                situacao.Id = int.Parse(dr["id"].ToString());
                situacao.Descricao = dr["descricao"].ToString();
               
                result.Add(situacao);
            }

            return result;
        }
    }
}

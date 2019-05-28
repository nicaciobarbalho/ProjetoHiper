using Chronos.Dtos;
using Chronos.Windows.Library.BO;
using Chronos.Windows.Library.DAO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Chronos.Windows.Library.CO
{
    public class PedidoItemCO
    {
        public List<PedidoItemBO> Adicionar(PedidoBO pedido, PedidoItemBO pedidoItem)
        {
            pedido.PedidoSituacaoId = 1;

            if (pedido.Id == 0)
                pedido.Id = new PedidoCO().Adicionar(pedido);

            pedidoItem.PedidoId = pedido.Id;

            var itens = this.PedidoItemPorPedidoId(pedido.Id);
            this.AdicionaItem(pedidoItem);
            itens.Add(pedidoItem);

            pedido.ValorBruto = itens.Sum(f => f.ValorBruto);
            pedido.ValorDesconto = itens.Sum(f => f.ValorDesconto);
            pedido.ValorLiquido = itens.Sum(f => f.ValorLiquido);

            new PedidoDAO().AtualizarTotais(pedido);
            return itens;
        }

        private void AdicionaItem(PedidoItemBO pedidoItem)
        {
            pedidoItem.Id = new PedidoItemDAO().Adicionar(pedidoItem);
        }

        public DataTable PedidoItem(int pedidoId)
        {
            return new PedidoItemDAO().PedidoItemPorPedidoId(pedidoId);
        }

        public List<PedidoItemBO> PedidoItemPorPedidoId(int id)
        {
            var result = new List<PedidoItemBO>();

            foreach (DataRow dr in this.PedidoItem(id).Rows)
            {
                var item = new PedidoItemBO();
                item.Id = int.Parse(dr["id"].ToString());
                item.PedidoId = int.Parse(dr["pedido_id"].ToString());
                item.ProdutoId = int.Parse(dr["produto_id"].ToString());
                item.Quantidade = decimal.Parse(dr["quantidade"].ToString());
                item.ValorUnitario = decimal.Parse(dr["valor_unitario"].ToString());
                item.ValorBruto = decimal.Parse(dr["valor_bruto"].ToString());
                item.ValorLiquido = decimal.Parse(dr["valor_liquido"].ToString());
                item.ValorDesconto = decimal.Parse(dr["valor_desconto"].ToString());

                result.Add(item);
            }

            return result;
        }

        private List<PedidoItemDto> GetPedidoItemSincronizacao(int pedidoId)
        {
            var result = new List<PedidoItemDto>();

            foreach (DataRow dr in new PedidoItemDAO().PedidoItemPendentesSincronizacao(pedidoId).Rows)
            {
                var item = new PedidoItemDto();
                item.Id = int.Parse(dr["id"].ToString());
                item.PedidoId = int.Parse(dr["pedido_id"].ToString());
                item.ProdutoId = int.Parse(dr["produto_id"].ToString());
                item.Quantidade = decimal.Parse(dr["quantidade"].ToString());
                item.ValorUnitario = decimal.Parse(dr["valor_unitario"].ToString());
                item.ValorBruto = decimal.Parse(dr["valor_bruto"].ToString());
                item.ValorLiquido = decimal.Parse(dr["valor_liquido"].ToString());
                item.ValorDesconto = decimal.Parse(dr["valor_desconto"].ToString());

                result.Add(item);
            }

            return result;
        }

        public bool SincronizarPedidoItem(int pedidoId, out string msgErro)
        {
            msgErro = "";

            var itens = this.GetPedidoItemSincronizacao(pedidoId);

            if (itens.Count == 0) return false;

            foreach (var pedidoDto in itens)
            {
                try
                {
                    var client = new HttpClient();
                    client.DefaultRequestHeaders.Accept.Clear();
                    var response = client.PostAsJsonAsync(new Uri($"{ConfigurationManager.AppSettings["EnderecoApi"].ToString()}PedidoItem"), pedidoDto);                    
                }
                catch (Exception e)
                {
                    msgErro = e.Message;
                    return false;
                }
            }

            return true;
        }
    }
}

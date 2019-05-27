using Chronos.Windows.Library.BO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chronos.Windows.Library.DAO
{
    public class PedidoItemDAO
    {
        public DataTable PedidoItemPorPedidoId(int id)
        {
            var query = new StringBuilder();
            query.Append("SELECT id, pedido_id, produto_id, quantidade, valor_unitario, valor_bruto, valor_liquido, valor_desconto FROM pedido_item WHERE pedido_id=@id ");

            using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Chronos.Windows.Connection"].ToString()))
            {
                conn.Open();

                var cmd = new SqlCommand(query.ToString(), conn);
                cmd.Parameters.AddWithValue("id", id);

                var dtResult = new DataTable();
                dtResult.Load(cmd.ExecuteReader());
                return dtResult;
            }
        }

        public int Adicionar(PedidoItemBO item)
        {
            var query = new StringBuilder();
            query.Append("INSERT INTO pedido_item (pedido_id, produto_id, quantidade, valor_unitario, valor_bruto, valor_liquido, valor_desconto) ");
            query.Append("VALUES (@pedido_id, @produto_id, @quantidade, @valor_unitario, @valor_bruto, @valor_liquido, @valor_desconto); SELECT SCOPE_IDENTITY();");

            using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Chronos.Windows.Connection"].ToString()))
            {
                conn.Open();

                var cmd = new SqlCommand(query.ToString(), conn);

                cmd.Parameters.AddWithValue("@pedido_id", item.PedidoId);
                cmd.Parameters.AddWithValue("@produto_id", item.ProdutoId);
                cmd.Parameters.AddWithValue("@quantidade", item.Quantidade);
                cmd.Parameters.AddWithValue("@valor_unitario", item.ValorUnitario);
                cmd.Parameters.AddWithValue("@valor_bruto", item.ValorBruto);
                cmd.Parameters.AddWithValue("@valor_liquido", item.ValorLiquido);
                cmd.Parameters.AddWithValue("@valor_desconto", item.ValorDesconto);

                int id = Convert.ToInt32(cmd.ExecuteScalar());
               // cmd.ExecuteNonQuery();

                return id;
            }
        }
    }
}

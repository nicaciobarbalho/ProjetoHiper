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
    public class PedidoDAO
    {
        public int Adicionar(PedidoBO pedido)
        {
            var query = new StringBuilder();
            query.Append("INSERT INTO pedido (cliente_id, valor_bruto, valor_liquido, valor_desconto, pedido_situacao_id) ");
            query.Append("VALUES (@cliente_id, @valor_bruto, @valor_liquido, @valor_desconto, @pedido_situacao_id); SELECT SCOPE_IDENTITY();");

            using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Chronos.Windows.Connection"].ToString()))
            {
                conn.Open();

                var cmd = new SqlCommand(query.ToString(), conn);

                cmd.Parameters.AddWithValue("@cliente_id", pedido.ClienteId);
                cmd.Parameters.AddWithValue("@valor_bruto", pedido.ValorBruto);
                cmd.Parameters.AddWithValue("@valor_liquido", pedido.ValorLiquido);
                cmd.Parameters.AddWithValue("@valor_desconto", pedido.ValorDesconto);
                cmd.Parameters.AddWithValue("@pedido_situacao_id", pedido.PedidoSituacaoId);

                int id = Convert.ToInt32(cmd.ExecuteScalar());
                //cmd.ExecuteNonQuery();
                return id;
            }
        }

        public void AtualizarTotais(PedidoBO pedido)
        {
            var query = new StringBuilder();
            query.Append(@"UPDATE pedido SET valor_bruto = @valor_bruto,
                                             valor_liquido = @valor_liquido, 
                                             valor_desconto = @valor_desconto
                          WHERE id = @id ");

            using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Chronos.Windows.Connection"].ToString()))
            {
                conn.Open();

                var cmd = new SqlCommand(query.ToString(), conn);

                cmd.Parameters.AddWithValue("@valor_bruto", pedido.ValorBruto);
                cmd.Parameters.AddWithValue("@valor_liquido", pedido.ValorDesconto);
                cmd.Parameters.AddWithValue("@valor_desconto", pedido.ValorLiquido);
                cmd.Parameters.AddWithValue("@id", pedido.Id);

                cmd.ExecuteNonQuery();
            }
        }

        public void AtualizarSituacao(int id, int situacao = 1)
        {
            var query = new StringBuilder();
            query.Append(@"UPDATE pedido SET pedido_situacao_id = @situacao
                          WHERE id = @id ");

            using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Chronos.Windows.Connection"].ToString()))
            {
                conn.Open();

                var cmd = new SqlCommand(query.ToString(), conn);

                cmd.Parameters.AddWithValue("@situacao", situacao);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }
        }

        public DataTable PedidoPorId(int id)
        {
            var query = new StringBuilder();
            query.Append("SELECT id, cliente_id, valor_bruto, valor_liquido, valor_desconto, pedido_situacao_id FROM pedido WHERE id=@id ");

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
    }
}

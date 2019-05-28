using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Chronos.Windows.Library.DAO
{
    public class PedidoSituacaoDAO
    {
        public DataTable Listar()
        {
            var query = new StringBuilder();
            query.Append("SELECT id, descricao FROM pedido_situacao ");

            using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Chronos.Windows.Connection"].ToString()))
            {
                conn.Open();

                var cmd = new SqlCommand(query.ToString(), conn);

                var dtResult = new DataTable();
                dtResult.Load(cmd.ExecuteReader());
                return dtResult;
            }
        }
    }
}

using Chronos.Windows.Library.BO;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Chronos.Windows.Library.DAO
{
    public class ProdutoDAO
    {
        public int Adicionar(ProdutoBO produto)
        {
            var query = new StringBuilder();
            query.Append("INSERT INTO produto (nome, preco, sincronizar) ");
            query.Append("VALUES (@nome, @preco, @sincronizar) ");

            using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Chronos.Windows.Connection"].ToString()))
            {
                conn.Open();

                var cmd = new SqlCommand(query.ToString(), conn);

                cmd.Parameters.AddWithValue("nome", produto.Nome);
                cmd.Parameters.AddWithValue("preco", produto.Preco);
                cmd.Parameters.AddWithValue("sincronizar", produto.Sincronizar);

                return cmd.ExecuteNonQuery();
            }
        }

        public DataTable Listar()
        {
            var query = new StringBuilder();
            query.Append("SELECT id, nome, preco FROM produto ");

            using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Chronos.Windows.Connection"].ToString()))
            {
                conn.Open();

                var cmd = new SqlCommand(query.ToString(), conn);

                var dtResult = new DataTable();
                dtResult.Load(cmd.ExecuteReader());
                return dtResult;
            }
        }

        public DataTable ListarPendentesSincronizacao()
        {
            var query = new StringBuilder();
            query.Append("SELECT id, nome, preco FROM produto where sincronizar=1 ");

            using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Chronos.Windows.Connection"].ToString()))
            {
                conn.Open();

                var cmd = new SqlCommand(query.ToString(), conn);

                var dtResult = new DataTable();
                dtResult.Load(cmd.ExecuteReader());
                return dtResult;
            }
        }

        public void AtualizarProdutoSincronizado(int idProduto)
        {
            var query = new StringBuilder();
            query.Append("UPDATE produto SET sincronizar=0 WHERE id=@id ");

            using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Chronos.Windows.Connection"].ToString()))
            {
                conn.Open();

                var cmd = new SqlCommand(query.ToString(), conn);

                cmd.Parameters.AddWithValue("id", idProduto);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
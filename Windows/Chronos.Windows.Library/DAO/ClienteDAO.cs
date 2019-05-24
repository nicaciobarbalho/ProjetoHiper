using Chronos.Windows.Library.BO;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Chronos.Windows.Library.DAO
{
    public class ClienteDAO
    {
        string connString;
        public ClienteDAO()
        {
            this.connString = ConfigurationManager.ConnectionStrings["Chronos.Windows.Connection"].ToString();
        }
        public int Adicionar(ClienteBO cliente)
        {
            var query = new StringBuilder();
            query.Append("INSERT INTO cliente (nome, cpf, endereco, numero_endereco, bairro, cidade, uf, sincronizar) ");
            query.Append("VALUES (@nome, @cpf, @endereco, @numeroEndereco, @bairro, @cidade, @uf, @sincronizar) ");

            using (var conn = new SqlConnection(connString))
            {
                conn.Open();

                var cmd = new SqlCommand(query.ToString(), conn);

                cmd.Parameters.AddWithValue("nome", cliente.Nome);
                cmd.Parameters.AddWithValue("cpf", cliente.Cpf);
                cmd.Parameters.AddWithValue("endereco", cliente.Endereco);
                cmd.Parameters.AddWithValue("numeroEndereco", cliente.NumeroEndereco);
                cmd.Parameters.AddWithValue("bairro", cliente.Bairro);
                cmd.Parameters.AddWithValue("cidade", cliente.Cidade);
                cmd.Parameters.AddWithValue("uf", cliente.Uf);
                cmd.Parameters.AddWithValue("sincronizar", cliente.Sincronizar);

                return cmd.ExecuteNonQuery();
            }
        }

        public DataTable Listar()
        {
            var query = new StringBuilder();
            query.Append("SELECT id, nome, cpf, endereco, numero_endereco, bairro, cidade, uf FROM cliente ");

            using (var conn = new SqlConnection(connString))
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
            query.Append("SELECT id, nome, cpf, endereco, numero_endereco, bairro, cidade, uf FROM cliente WHERE sincronizar=1 ");

            using (var conn = new SqlConnection(connString))
            {
                conn.Open();

                var cmd = new SqlCommand(query.ToString(), conn);

                var dtResult = new DataTable();
                dtResult.Load(cmd.ExecuteReader());
                return dtResult;
            }
        }

        public void AtualizarClienteSincronizado(int idCliente)
        {
            var query = new StringBuilder();
            query.Append("UPDATE cliente SET sincronizar=0 WHERE id=@id ");

            using (var conn = new SqlConnection(connString))
            {
                conn.Open();

                var cmd = new SqlCommand(query.ToString(), conn);

                cmd.Parameters.AddWithValue("id", idCliente);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
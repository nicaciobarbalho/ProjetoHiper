using Chronos.Dtos;
using Chronos.Windows.Library.BO;
using Chronos.Windows.Library.DAO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Net.Http;

namespace Chronos.Windows.Library.CO
{
    public class ProdutoCO
    {
        public bool Adicionar(ProdutoBO produto, out string msgErro)
        {
            msgErro = "";

            try
            {

                if (string.IsNullOrEmpty(produto.Nome))
                {
                    msgErro = "Nome vazio.";
                    return false;
                }

                if (produto.Preco <= 0)
                {
                    msgErro = "Preço inválido.";
                    return false;
                }

                return new ProdutoDAO().Adicionar(produto) > 0;
            }
            catch (Exception ex)
            {
                msgErro = $"Erro: {ex.Message}";
            }

            return false;
        }

        public DataTable Listar()
        {
            return new ProdutoDAO().Listar();
        }

        private List<ProdutoDto> GetProdutosSincronizacao()
        {
            var result = new List<ProdutoDto>();

            var dtProdutosPendenteSincronizacao = new ProdutoDAO().ListarPendentesSincronizacao();

            foreach (DataRow dr in dtProdutosPendenteSincronizacao.Rows)
            {
                var produtoDto = new ProdutoDto();
                produtoDto.Id = int.Parse(dr["id"].ToString());
                produtoDto.Nome = dr["nome"].ToString();
                produtoDto.Preco = decimal.Parse(dr["preco"].ToString());
                result.Add(produtoDto);
            }

            return result;
        }

        private List<ProdutoBO> CarregarProduto(DataTable produtos)
        {
            var result = new List<ProdutoBO>();

            foreach (DataRow dr in produtos.Rows)
            {
                var produto = new ProdutoBO();
                produto.Id = int.Parse(dr["id"].ToString());
                produto.Nome = dr["nome"].ToString();
       
         produto.Preco = decimal.Parse(dr["preco"].ToString());
                result.Add(produto);
            }

            return result;
        }

        public List<ProdutoBO> ProdutoPorNome(string nome)
        {
            return this.CarregarProduto(new ProdutoDAO().ProdutoPorNome(nome));
        }

        public List<ProdutoBO> Produtos()
        {
            return this.CarregarProduto(new ProdutoDAO().Listar());
        }

        public List<ProdutoBO> ProdutoPorId(int id)
        {
            return this.CarregarProduto(new ProdutoDAO().ProdutoPorId(id));
        }

        public bool SincronizarProdutos(out string msgErro)
        {
            msgErro = "";

            foreach (var produtoDto in GetProdutosSincronizacao())
            {
                try
                {
                    var client = new HttpClient();
                    client.DefaultRequestHeaders.Accept.Clear();
                    var response = client.PostAsJsonAsync(new Uri($"{ConfigurationManager.AppSettings["EnderecoApi"].ToString()}Produto"), produtoDto);
                    
                    new ProdutoDAO().AtualizarProdutoSincronizado(produtoDto.Id);
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
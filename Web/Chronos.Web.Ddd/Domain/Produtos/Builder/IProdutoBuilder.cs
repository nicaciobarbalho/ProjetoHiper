using Chronos.Web.Ddd.Domain.Base.Builders;

namespace Chronos.Web.Ddd.Domain.Produtos.Builder
{
    internal interface IProdutoBuilder : IBaseBuilder<ProdutoBuilder, Produto>
    {
        ProdutoBuilder ComNome(string nome);

        ProdutoBuilder ComPreco(decimal preco);
    }
}
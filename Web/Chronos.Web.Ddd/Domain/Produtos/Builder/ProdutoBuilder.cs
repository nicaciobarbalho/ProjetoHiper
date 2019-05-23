using Chronos.Web.Ddd.Domain.Base.Builders;

namespace Chronos.Web.Ddd.Domain.Produtos.Builder
{
    internal class ProdutoBuilder : BaseBuilder<ProdutoBuilder, Produto>, IProdutoBuilder
    {
        protected string Nome { get; set; }

        protected decimal Preco { get; set; }

        public override Produto Build() => new Produto(Id, Nome, Preco);

        public ProdutoBuilder ComNome(string nome)
        {
            Nome = nome;
            return this;
        }

        public ProdutoBuilder ComPreco(decimal preco)
        {
            Preco = preco;
            return this;
        }
    }
}
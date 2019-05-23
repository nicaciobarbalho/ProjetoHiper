using Chronos.Web.Ddd.Domain.Base.Entities;

namespace Chronos.Web.Ddd.Domain.Produtos
{
    internal class Produto : Entity
    {
        internal Produto(int id, string nome, decimal preco)
        {
            SetId(id);
            SetNome(nome);
            SetPreco(preco);
        }

        protected Produto()
        {
        }

        public string Nome { get; private set; }

        public decimal Preco { get; private set; }

        public void SetNome(string nome)
        {
            Nome = nome;
        }

        public void SetPreco(decimal preco)
        {
            Preco = preco;
        }
    }
}
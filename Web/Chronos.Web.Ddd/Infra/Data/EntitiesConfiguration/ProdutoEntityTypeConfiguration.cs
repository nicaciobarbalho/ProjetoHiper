using Chronos.Web.Ddd.Domain.Produtos;
using System.Data.Entity.ModelConfiguration;

namespace Chronos.Web.Ddd.Infra.Data.EntitiesConfiguration
{
    internal class ProdutoEntityTypeConfiguration : EntityTypeConfiguration<Produto>
    {
        public ProdutoEntityTypeConfiguration()
        {
            HasKey(x => x.Id);
            ToTable(nameof(Produto));

            Property(x => x.Nome).IsRequired();
            Property(x => x.Preco).IsRequired();
        }
    }
}
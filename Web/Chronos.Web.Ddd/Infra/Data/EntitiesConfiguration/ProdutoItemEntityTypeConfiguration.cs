using Chronos.Web.Ddd.Domain.Pedidos;
using System.Data.Entity.ModelConfiguration;

namespace Chronos.Web.Ddd.Infra.Data.EntitiesConfiguration
{
    internal class PedidoItemEntityTypeConfiguration : EntityTypeConfiguration<PedidoItem>
    {
        public PedidoItemEntityTypeConfiguration()
        {
            HasKey(x => x.Id);
            ToTable(nameof(PedidoItem));

            Property(x => x.PedidoId).IsRequired();
            Property(x => x.ProdutoId).IsRequired();
            Property(x => x.Quantidade).IsRequired();
            Property(x => x.ValorUnitario).IsRequired();
            Property(x => x.ValorBruto).IsRequired();
            Property(x => x.ValorDesconto).IsRequired();
            Property(x => x.ValorLiquido).IsRequired();
        }
    }
}

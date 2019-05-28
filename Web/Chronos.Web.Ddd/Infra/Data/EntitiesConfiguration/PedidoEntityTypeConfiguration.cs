using Chronos.Web.Ddd.Domain.Pedidos;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chronos.Web.Ddd.Infra.Data.EntitiesConfiguration
{
    internal class PedidoEntityTypeConfiguration : EntityTypeConfiguration<Pedido>
    {
        public PedidoEntityTypeConfiguration()
        {
            HasKey(x => x.Id);
            ToTable(nameof(Pedido));

            Property(x => x.ClienteId).IsRequired();
            Property(x => x.ValorBruto).IsRequired();
            Property(x => x.ValorDesconto).IsRequired();
            Property(x => x.ValorLiquido).IsRequired();
        }
    }
}

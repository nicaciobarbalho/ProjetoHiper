using Chronos.Web.Ddd.Domain.Clientes;
using System.Data.Entity.ModelConfiguration;

namespace Chronos.Web.Ddd.Infra.Data.EntitiesConfiguration
{
    internal class ClienteEntityTypeConfiguration : EntityTypeConfiguration<Cliente>
    {
        public ClienteEntityTypeConfiguration()
        {
            HasKey(x => x.Id);
            ToTable(nameof(Cliente));

            Property(x => x.Nome).IsRequired();
            Property(x => x.Cpf).IsRequired();
            Property(x => x.Endereco).IsRequired();
            Property(x => x.NumeroDoEndereco).IsRequired();
            Property(x => x.Bairro).IsRequired();
            Property(x => x.Cidade).IsRequired();
            Property(x => x.Uf).IsRequired();

            HasIndex(x => x.Cpf).IsUnique();
        }
    }
}
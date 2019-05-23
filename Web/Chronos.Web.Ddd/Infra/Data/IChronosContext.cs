using Chronos.Web.Ddd.Domain.Clientes;
using Chronos.Web.Ddd.Domain.Produtos;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Chronos.Web.Ddd.Infra.Data
{
    internal interface IChronosContext
    {
        IDbSet<Cliente> Clientes { get; set; }
        IDbSet<Produto> Produtos { get; set; }

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        int SaveChanges();
    }
}
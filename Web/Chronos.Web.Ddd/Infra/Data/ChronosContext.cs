using Chronos.Web.Ddd.Domain.Clientes;
using Chronos.Web.Ddd.Domain.Produtos;
using System.Data.Entity;
using System.Reflection;

namespace Chronos.Web.Ddd.Infra.Data
{
    internal class ChronosContext : DbContext, IChronosContext
    {
        public ChronosContext()
            : base("Chronos.Web.Connection")
        {
        }

        public IDbSet<Cliente> Clientes { get; set; }
        public IDbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}
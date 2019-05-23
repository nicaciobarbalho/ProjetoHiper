namespace Chronos.Web.Ddd.Domain.Base.Builders
{
    internal abstract class BaseBuilder<TBuilder, TDominio> : IBaseBuilder<TBuilder, TDominio>
        where TBuilder : BaseBuilder<TBuilder, TDominio>
        where TDominio : class
    {
        protected int Id { get; set; }

        public abstract TDominio Build();

        public TBuilder ComId(int id)
        {
            Id = id;
            return (TBuilder)this;
        }
    }
}
namespace Chronos.Web.Ddd.Domain.Base.Builders
{
    internal interface IBaseBuilder<out TBuilder, out TDominio>
        where TBuilder : IBaseBuilder<TBuilder, TDominio>
        where TDominio : class
    {
        TDominio Build();

        TBuilder ComId(int id);
    }
}
namespace Chronos.Web.Ddd.Domain.Base.Entities
{
    public interface IEntity
    {
        int Id { get; }

        void SetId(int id);
    }
}
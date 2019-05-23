using Chronos.Web.Ddd.Domain.Base.Errors;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chronos.Web.Ddd.Domain.Base.Entities
{
    public class Entity : DomainError, IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; private set; }

        public void SetId(int id)
        {
            if (id <= 0)
            {
                AddError("Não foi informado um ID válido.");
                return;
            }

            Id = id;
        }
    }
}
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Chronos.Web.Ddd.Domain.Base.Errors
{
    public abstract class DomainError : IDomainError
    {
        protected DomainError()
        {
            Errors = Errors ?? new List<string>();
        }

        [NotMapped]
        public ICollection<string> Errors { get; }

        [NotMapped]
        public bool IsValid => !Errors.Any();

        public void AddError(string error)
        {
            if (!string.IsNullOrWhiteSpace(error) && !Errors.Contains(error)) Errors.Add(error);
        }
    }
}
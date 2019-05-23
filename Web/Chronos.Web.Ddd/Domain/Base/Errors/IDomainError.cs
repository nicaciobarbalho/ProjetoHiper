using System.Collections.Generic;

namespace Chronos.Web.Ddd.Domain.Base.Errors
{
    public interface IDomainError
    {
        ICollection<string> Errors { get; }
        bool IsValid { get; }

        void AddError(string error);
    }
}
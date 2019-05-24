using System.Collections.Generic;
using System.Linq;

namespace Chronos.Dtos
{
    public abstract class BaseDto
    {
        protected BaseDto()
        {
            Errors = Errors ?? new List<string>();
        }
        public int Id { get; set; }

        public ICollection<string> Errors { get; set; }
        public bool IsValid => !Errors.Any();

        public void AddError(string error)
        {
            if (Errors != null && !string.IsNullOrWhiteSpace(error) && !Errors.Contains(error)) Errors.Add(error);
        }

        public void AddErrors(IEnumerable<string> errors) => errors.ToList().ForEach(AddError);
    }
}
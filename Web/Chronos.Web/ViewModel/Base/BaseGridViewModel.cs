using System.Collections.Generic;

namespace Chronos.Web.ViewModel.Base
{
    public abstract class BaseGridViewModel<TGridData>
        where TGridData : class, new()
    {
        protected BaseGridViewModel()
        {
            Dados = Dados ?? new List<TGridData>();
        }

        public ICollection<TGridData> Dados { get; set; }
        public int QuantidadeDeLinhas => Dados?.Count ?? 0;
    }
}
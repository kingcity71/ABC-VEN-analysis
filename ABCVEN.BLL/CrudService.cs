using ABCVEN.Data;
using ABCVEN.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace ABCVEN.BLL
{
    public class CrudService : ICrudService
    {
        private readonly ABCVENContext context;

        public CrudService(ABCVENContext context)
        {
            this.context = context;
        }
        public IEnumerable<string> GetAllAccountingTypes() 
        => context.AccountingTypes.Select(x => x.Name).AsEnumerable();

        public IEnumerable<string> GetAllFinSources()
        => context.FinanceSources.Select(x => x.Name).AsEnumerable();

        public IEnumerable<string> GetAllProducers()
        => context.Producers.Select(x => x.Name).AsEnumerable();

        public IEnumerable<string> GetAllStores()
        => context.Stores.Select(x => x.Name).AsEnumerable();
    }
}

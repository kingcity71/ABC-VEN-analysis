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
        => context.Medicines.Select(x => x.AccountingType)
            .Distinct()
            .AsEnumerable();

        public IEnumerable<string> GetAllFinSources()
        => context.Purchases.Select(x => x.FinanceSource)
            .Distinct()
            .AsEnumerable();

        public IEnumerable<string> GetAllProducers()
        => context.Purchases.Select(x => x.Producer)
            .Distinct()
            .AsEnumerable();

        public IEnumerable<string> GetAllStores()
        => context.Purchases.Select(x => x.Store)
            .Distinct()
            .AsEnumerable();
    }
}

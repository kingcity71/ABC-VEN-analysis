using System.Collections.Generic;

namespace ABCVEN.Interfaces
{
    public interface ICrudService
    {
        IEnumerable<string> GetAllProducers();
        IEnumerable<string> GetAllFinSources();
        IEnumerable<string> GetAllAccountingTypes();
        IEnumerable<string> GetAllStores();
        void SetSales(string[,] data);
        void SetPurchases(string[,] data);
    }
}

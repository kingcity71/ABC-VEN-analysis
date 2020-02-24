using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCVEN.Interfaces
{
    public interface ICrudService
    {
        IEnumerable<string> GetAllProducers();
        IEnumerable<string> GetAllFinSources();
        IEnumerable<string> GetAllAccountingTypes();
        IEnumerable<string> GetAllStores();
    }
}

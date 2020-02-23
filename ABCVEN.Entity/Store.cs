using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCVEN.Entities
{
    public class Store
    {
        public Guid Id { get; set; }
        public Guid MedicineId { get; set; }
        public int Count { get; set; }
    }
}

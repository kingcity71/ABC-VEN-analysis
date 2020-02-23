using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCVEN.Entities
{
    public class Purchase
    {
        public Guid Id { get; set; }
        public string FinanceSource { get; set; }
        public string ExternalStoreName { get; set; }
        public DateTime Date { get; set; }
        public int Count { get; set; }
        public double Sum { get; set; }
        public Guid MedicineId { get; set; }
        public Guid ProducerId { get; set; }
        public Guid SupplierId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCVEN.Entities
{
    public class Sale
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public int Count { get; set; }
        public double Dosage { get; set; }
        public Guid MedicineId { get; set; }
        public Guid PatientId { get; set; }
    }
}

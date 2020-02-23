using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCVEN.Entity
{
    public class Medicine
    {
        public Guid Id { get; set; }
        public string TradeName { get; set; }
        public string InternationalNonproprietaryName { get; set; }
        public DateTime ShelfLifeDate { get; set; }
        public string UnitMeasure { get; set; }
        public double Dosage { get; set; }
        public string ActiveSubstances { get; set; }
        public string Appointment { get; set; }
        public string AccountingType { get; set; }
        public string VEN { get; set; }
    }
}

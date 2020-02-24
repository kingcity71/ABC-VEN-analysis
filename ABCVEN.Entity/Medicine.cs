using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ABCVEN.Entity
{
    public class Medicine
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        public string TradeName { get; set; }
        public string InternationalNonproprietaryName { get; set; }
        public DateTime ShelfLifeDate { get; set; }
        public string UnitMeasure { get; set; }
        public double Dosage { get; set; }
        public string ActiveSubstances { get; set; }
        public string Appointment { get; set; }
        public Guid AccountingTypeId { get; set; }
        public string VEN { get; set; }
    }
}

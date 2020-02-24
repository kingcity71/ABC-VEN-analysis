using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ABCVEN.Entity
{
    public class Sale
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public int Count { get; set; }
        public double Dosage { get; set; }
        public Guid MedicineId { get; set; }
        public Guid PatientId { get; set; }
    }
}

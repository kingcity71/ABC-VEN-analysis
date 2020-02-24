using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ABCVEN.Entity
{
    public class Purchase
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int MedicineId { get; set; }
        public int Count { get; set; }
        public double Sum { get; set; }
        public string Producer { get; set; }
        public string Supplier { get; set; }
        public string FinanceSource { get; set; }
        public string Store { get; set; }
    }
}

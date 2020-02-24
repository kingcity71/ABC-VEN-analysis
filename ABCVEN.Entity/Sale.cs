using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ABCVEN.Entity
{
    public class Sale
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Count { get; set; }
        public int Sum { get; set; }
        public int MedicineId { get; set; }
    }
}

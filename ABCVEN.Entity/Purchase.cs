using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ABCVEN.Entity
{
    public class Purchase
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        public Guid FinanceSourceId { get; set; }
        public Guid StoreId { get; set; }
        public string ExternalStoreName { get; set; }
        public DateTime Date { get; set; }
        public int Count { get; set; }
        public double Sum { get; set; }
        public Guid MedicineId { get; set; }
        public Guid ProducerId { get; set; }
        public Guid SupplierId { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ABCVEN.Entity
{
    public class Medicine
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string TradeName { get; set; }
        public string InternationalNonproprietaryName { get; set; }
        public string AccountingType { get; set; }
        public string VEN { get; set; }
    }
}

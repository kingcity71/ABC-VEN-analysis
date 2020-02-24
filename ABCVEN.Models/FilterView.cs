using System;

namespace ABCVEN.Models
{
    public class FilterView
    {
        public string Store { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public string FinSource { get; set; }
        public string AccType { get; set; }
        public string Producer { get; set; }
    }
}

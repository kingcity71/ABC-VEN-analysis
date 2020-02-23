using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCVEN.Entities
{
    public class Patient
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string City { get; set; }
    }
}

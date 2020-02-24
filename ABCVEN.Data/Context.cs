using ABCVEN.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ABCVEN.Data
{
    public class ABCVENContext:DbContext
    {
        public ABCVENContext() { }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
    }
}

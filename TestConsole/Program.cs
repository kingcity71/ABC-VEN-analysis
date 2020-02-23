using ABCVEN.Data;
using ABCVEN.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var context = new ABCVENContext())
            {
                var patient = new Patient()
                {
                    Id = Guid.NewGuid(),
                    FullName="Alex Alexovich Alexov",
                    City="Kazan"
                };

                context.Patients.Add(patient);
                context.SaveChanges();
            }
        }
    }
}

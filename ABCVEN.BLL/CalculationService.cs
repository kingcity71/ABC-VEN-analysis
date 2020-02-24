using ABCVEN.Data;
using ABCVEN.Interfaces;
using ABCVEN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCVEN.BLL
{
    public class CalculationService : ICalculationService
    {
        private readonly ABCVENContext context;

        public CalculationService(ABCVENContext context)
        {
            this.context = context;
        }
        
    }
}

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
        public IEnumerable<SalesViewModel> GetSalesViewModels()
        {
            var result = new List<SalesViewModel>();
            var sales = context.Sales.ToList();
            foreach(var medicine in context.Medicines)
            {
                var medicineSales = sales.Where(x => x.MedicineId == medicine.Id).ToList();
                var count = medicineSales.Sum(x => x.Count);
                var sum = medicineSales.Sum(x => x.Sum);
                result.Add(new SalesViewModel()
                {
                    MedicineName = medicine.TradeName,
                    SalesCount = count,
                    SalesSum = sum
                });
            }
            return result;
        }
        public string test() => null;
    }
}

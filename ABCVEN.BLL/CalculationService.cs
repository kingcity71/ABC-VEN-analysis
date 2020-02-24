using ABCVEN.Data;
using ABCVEN.Entity;
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
        public (ABCGroupModel, ABCGroupModel, ABCGroupModel) GetABC()
        {
            double GetPercentageOfTotal(List<ABCUnitModel> models, List<SalesViewModel> sales)
                => models.Count() != 0 ? (double)(sales.Count()) / models.Count : 0;
            
            var medicineSales = GetSalesViewModels()
                .OrderByDescending(x=>x.SalesSum).ToList();

            var salesSum = medicineSales.Sum(x => x.SalesSum);
            var abcModels = new List<ABCUnitModel>();

            var increaseSumPercentage = 0.0;
            foreach (var medicine in medicineSales)
            {
                var percentage = (double)medicine.SalesSum / salesSum;
                increaseSumPercentage += percentage;
                abcModels.Add(new ABCUnitModel()
                {
                    MedicineName = medicine.MedicineName,
                    SumPercentage = percentage,
                    IncreaseSumPercentage = increaseSumPercentage,
                    VEN = medicine.VEN
                });
            }

            var A = new ABCGroupModel() {ABCModels = abcModels.Where(x => x.IncreaseSumPercentage <= 0.8).ToList()};
            A.PercentageOfTotalCount = GetPercentageOfTotal(A.ABCModels, medicineSales);

            var B = new ABCGroupModel() { ABCModels = abcModels.Where(x => x.IncreaseSumPercentage>0.8 && x.IncreaseSumPercentage <= 0.95).ToList() };
            B.PercentageOfTotalCount = GetPercentageOfTotal(B.ABCModels, medicineSales);
            
            var C = new ABCGroupModel() { ABCModels = abcModels.Where(x => x.IncreaseSumPercentage > 0.95).ToList() };
            C.PercentageOfTotalCount = GetPercentageOfTotal(C.ABCModels, medicineSales);

            return (A, B, C);
        }
        private IEnumerable<SalesViewModel> GetSalesViewModels()
        {
            var sales = context.Sales.ToList();
            var medicines = context.Medicines.ToList();
            var result = new List<SalesViewModel>();
            foreach (var medicine in medicines)
            {
                var medicineSales = sales.Where(x => x.MedicineId == medicine.Id).ToList();
                var count = medicineSales.Sum(x => x.Count);
                var sum = medicineSales.Sum(x => x.Sum);
                result.Add(new SalesViewModel()
                {
                    MedicineName = medicine.TradeName,
                    SalesCount = count,
                    SalesSum = sum,
                    VEN = medicine.VEN
                });
            }
            return result;
        }
    }
}

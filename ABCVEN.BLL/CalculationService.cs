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
        public (ABCGroupModel, ABCGroupModel, ABCGroupModel) GetABC(FilterView filter)
        {
            double GetPercentageOfTotal(List<ABCUnitModel> models, List<SalesViewModel> sales)
                => models.Count() != 0 ? (double)(sales.Count()) / models.Count : 0;
            
            var medicineSales = GetSalesViewModels(filter)
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
        private IEnumerable<SalesViewModel> GetSalesViewModels(FilterView filter)
        {
            var sales = GetFiltred(filter);
            var medicines = context.Medicines.ToList();
            var result = new List<SalesViewModel>();
            foreach (var medicine in medicines)
            {
                if (filter.AccType.ToLower() == "Все".ToLower() || medicine.AccountingType.ToLower() == filter.AccType.ToLower())
                {
                    var medicineSales = sales.Where(x => x.MedicineId == medicine.Id).ToList();
                    var count = medicineSales.Sum(x => x.Count);
                    var sum = (int)medicineSales.Sum(x => x.Sum);
                    result.Add(new SalesViewModel()
                    {
                        MedicineName = medicine.TradeName,
                        SalesCount = count,
                        SalesSum = sum,
                        VEN = medicine.VEN
                    });
                }
            }
            return result;
        }

        private IEnumerable<Purchase> GetFiltred(FilterView filter)
        {
            var purchases = context.Purchases
                .Where(x=>x.Date>=filter.DateFrom && x.Date<=filter.DateTo)
                .ToList();
            if ((filter.FinSource)!="Все")
                purchases = purchases
                    .Where(x => x.FinanceSource.ToLower() == filter.FinSource.ToLower()).ToList();
            if((filter.Producer) != "Все")
                purchases = purchases
                    .Where(x => x.Producer.ToLower() == filter.Producer.ToLower()).ToList();
            if ((filter.Store) != "Все")
                purchases = purchases
                    .Where(x => x.Store.ToLower() == filter.Store.ToLower()).ToList();
            return purchases;
        }
    }
}

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
    public class ViewService : IViewService
    {
        private readonly ABCVENContext context;

        public ViewService(ABCVENContext context)
        {
            this.context = context;
        }

        public IEnumerable<SalesViewModel> GetFilteredViewModel(FilterView filterView)
        {
            var sales = context.Sales.Where(x => x.Date >= filterView.DateFrom && x.Date <= filterView.DateTo).ToList();
            var purchases = context.Purchases.ToList();
            var medicine = context.Medicines.ToList();
            if (filterView.AccType != "Все") medicine = medicine.Where(x => x.AccountingType == filterView.AccType).ToList();
            if (filterView.FinSource != "Все") purchases = purchases.Where(x => x.FinanceSource == filterView.FinSource).ToList();
            if (filterView.Producer != "Все") purchases = purchases.Where(x => x.Producer == filterView.Producer).ToList();
            if (filterView.Store != "Все") purchases = purchases.Where(x => x.Store == filterView.Store).ToList();
            var targetMedicineIds = sales.Select(x => x.MedicineId)
                .Intersect(purchases.Select(x => x.MedicineId))
                .Intersect(medicine.Select(x => x.Id));
            var targetMedicines = context.Medicines.Where(x => targetMedicineIds.Contains(x.Id)).ToList();
            return GetSalesViewModels(sales, targetMedicines);
        }

        public IEnumerable<SalesViewModel> GetSalesViewModels()
        {
            var sales = context.Sales.ToList();
            var medicines = context.Medicines.ToList();
            return GetSalesViewModels(sales, medicines);
        }

        public IEnumerable<SalesViewModel> GetSalesViewModels(List<Sale> sales, List<Medicine> medicines)
        {
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
                    SalesSum = sum
                });
            }
            return result;
        }

        public (DateTime, DateTime) GetTimeBorders()
        {
            var minDate = context.Sales.Select(x => x.Date).Min();
            var maxDate = context.Sales.Select(x => x.Date).Max();
            return (minDate, maxDate);
        }
    
    }
}

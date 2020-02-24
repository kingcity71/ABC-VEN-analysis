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
        private readonly ICalculationService calculationService;

        public ViewService(ABCVENContext context, ICalculationService calculationService)
        {
            this.context = context;
            this.calculationService = calculationService;
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

        private IEnumerable<SalesViewModel> GetSalesViewModels(List<Sale> sales, List<Medicine> medicines)
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
                    SalesSum = sum,
                    VEN = medicine.VEN
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

        public DiagrammViewModel GetDiagrammModel(DiagrammViewModel diagrammViewModel)
        {
            var calculated = calculationService.GetABC();
            var result = new DiagrammViewModel();

            result.A = GetDiagrammViewModel(calculated.Item1);
            result.B = GetDiagrammViewModel(calculated.Item2);
            result.C = GetDiagrammViewModel(calculated.Item3);
            result.Total = GetDiagrammTotalViewModel(result.A, result.B, result.C);

            //result.A = new UnitModel() { E = 20, N = 30, V = 43 };
            //result.B = new UnitModel() { E = 100, N = 200, V = 123 };
            //result.C = new UnitModel() { E = 120, N = 40, V = 23 };
            //result.Total = new UnitModel() { E = result.A.E+result.B.E+result.C.E, 
            //    N = result.A.N + result.B.N + result.C.N, 
            //    V = result.A.V + result.B.V + result.C.V
            //};

            return result;
        }

        private DiagrammUnitModel GetDiagrammViewModel(ABCGroupModel groupModel)
            => new DiagrammUnitModel()
            {
                V = groupModel.ABCModels.Where(x => x.VEN == "V").Sum(x => x.SumPercentage),
                E = groupModel.ABCModels.Where(x => x.VEN == "E").Sum(x => x.SumPercentage),
                N = groupModel.ABCModels.Where(x => x.VEN == "N").Sum(x => x.SumPercentage)
            };
        private DiagrammUnitModel GetDiagrammTotalViewModel(DiagrammUnitModel A, DiagrammUnitModel B, DiagrammUnitModel C)
        => new DiagrammUnitModel()
        {
            V = A.V + C.V + B.V,
            E = A.E + C.E + B.E,
            N = A.N + C.N + B.N
        };
    }
}

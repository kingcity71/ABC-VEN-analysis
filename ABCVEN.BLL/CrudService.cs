using ABCVEN.Data;
using ABCVEN.Entity;
using ABCVEN.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ABCVEN.BLL
{
    public class CrudService : ICrudService
    {
        private readonly ABCVENContext context;

        public CrudService(ABCVENContext context)
        {
            this.context = context;
        }
        public IEnumerable<string> GetAllAccountingTypes()
        => context.Medicines.Select(x => x.AccountingType)
            .Distinct()
            .AsEnumerable();

        public IEnumerable<string> GetAllFinSources()
        => context.Purchases.Select(x => x.FinanceSource)
            .Distinct()
            .AsEnumerable();

        public IEnumerable<string> GetAllProducers()
        => context.Purchases.Select(x => x.Producer)
            .Distinct()
            .AsEnumerable();

        public IEnumerable<string> GetAllStores()
        => context.Purchases.Select(x => x.Store)
            .Distinct()
            .AsEnumerable();

        public void SetPurchases(string[,] data)
        {
            for (var i = 0; i < data.GetLength(0); i++)
            {
                try
                {
                    if (i == 0) continue;
                    var medicine = GetMedicineByName(data[i, 0]);
                    context.Purchases.Add(new Purchase()
                    {
                        MedicineId = medicine.Id,
                        Date = DateTime.Parse(data[i, 1]),
                        Count = int.Parse(data[i, 2]),
                        Sum = int.Parse(data[i, 3]),
                        Producer = data[i, 4],
                        Supplier = data[i, 5],
                        FinanceSource = data[i, 6],
                        Store = data[i, 7]
                    });
                }
                catch (Exception ex)
                {

                }
            }
            context.SaveChanges();
        }
        public void SetSales(string[,] data)
        {
            for(var i=0; i<data.GetLength(0); i++)
            {
                if (i == 0) continue;
                var medicine = GetMedicineByName(data[i, 0]);
                context.Sales.Add(new Sale()
                {
                    MedicineId = medicine.Id,
                    Date = DateTime.Parse(data[i, 1]),
                    Count = int.Parse(data[i, 2]),
                    Sum = int.Parse(data[i, 3])
                });
            }
            context.SaveChanges();
        }
        private Medicine GetMedicineByName(string name)
        => context.Medicines.FirstOrDefault(x => x.TradeName.ToLower() == name.ToLower().Trim());
    }
}

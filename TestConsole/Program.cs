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
            DBInitial();
        }
        static void DBInitial()
        {
            using (var context = new ABCVENContext())
            {
                context.Medicines.Add(new Medicine()
                    {
                        TradeName = "ТН1",
                        InternationalNonproprietaryName ="МНН1",
                        AccountingType="Вид учета 1",
                        VEN="V"
                    });
                context.Medicines.Add(new Medicine()
                {
                    TradeName = "ТН2",
                    InternationalNonproprietaryName = "МНН2",
                    AccountingType = "Вид учета 2",
                    VEN = "E"
                });
                context.Medicines.Add(new Medicine()
                {
                    TradeName = "ТН3",
                    InternationalNonproprietaryName = "МНН3",
                    AccountingType = "Вид учета 3",
                    VEN = "N"
                });
                context.Medicines.Add(new Medicine()
                {
                    TradeName = "ТН4",
                    InternationalNonproprietaryName = "МНН4",
                    AccountingType = "Вид учета 2",
                    VEN = "E"
                });
                context.Medicines.Add(new Medicine()
                {
                    TradeName = "ТН5",
                    InternationalNonproprietaryName = "МНН5",
                    AccountingType = "Вид учета 3",
                    VEN = "V"
                });
                context.Medicines.Add(new Medicine()
                {
                    TradeName = "ТН6",
                    InternationalNonproprietaryName = "МНН6",
                    AccountingType = "Вид учета 1",
                    VEN = "N"
                });

                context.Purchases.Add(new Purchase()
                {
                    Date = DateTime.Today,
                    Count = 100,
                    Sum = 1000,
                    FinanceSource = "Источник 1",
                    MedicineId = 1,
                    Store = "Склад 1",
                    Supplier = "Поставщик 1",
                    Producer = "Производитель 1"
                });
                context.Purchases.Add(new Purchase()
                {
                    Date = DateTime.Today,
                    Count = 50,
                    Sum = 10000,
                    FinanceSource = "Источник 1",
                    MedicineId = 2,
                    Store = "Склад 2",
                    Supplier = "Поставщик 2",
                    Producer = "Производитель 1"
                });
                context.Purchases.Add(new Purchase()
                {
                    Date = DateTime.Today,
                    Count = 50,
                    Sum = 500,
                    FinanceSource = "Источник 2",
                    MedicineId = 3,
                    Store = "Склад 2",
                    Supplier = "Поставщик 3",
                    Producer = "Производитель 2"
                });
                context.Purchases.Add(new Purchase()
                {
                    Date = DateTime.Today,
                    Count = 71,
                    Sum = 892,
                    FinanceSource = "Источник 3",
                    MedicineId = 4,
                    Store = "Склад 3",
                    Supplier = "Поставщик 3",
                    Producer = "Производитель 3"
                });
                context.Purchases.Add(new Purchase()
                {
                    Date = DateTime.Today,
                    Count = 56,
                    Sum = 987,
                    FinanceSource = "Источник 4",
                    MedicineId = 5,
                    Store = "Склад 4",
                    Supplier = "Поставщик 1",
                    Producer = "Производитель 3"
                });
                context.Purchases.Add(new Purchase()
                {
                    Date = DateTime.Today,
                    Count = 2130,
                    Sum = 1002,
                    FinanceSource = "Источник 4",
                    MedicineId = 6,
                    Store = "Склад 2",
                    Supplier = "Поставщик 2",
                    Producer = "Производитель 3"
                });

                context.Sales.Add(new Sale()
                {
                    Date = DateTime.Today,
                    Count = 20,
                    MedicineId = 1,
                    Sum = 300
                });
                context.Sales.Add(new Sale()
                {
                    Date = DateTime.Today,
                    Count = 30,
                    MedicineId = 2,
                    Sum = 400
                });
                context.Sales.Add(new Sale()
                {
                    Date = DateTime.Today,
                    Count = 10,
                    MedicineId = 3,
                    Sum = 200
                });
                context.Sales.Add(new Sale()
                {
                    Date = DateTime.Today,
                    Count = 50,
                    MedicineId = 4,
                    Sum = 520
                });
                context.Sales.Add(new Sale()
                {
                    Date = DateTime.Today,
                    Count = 71,
                    MedicineId = 5,
                    Sum = 450
                });
                context.Sales.Add(new Sale()
                {
                    Date = DateTime.Today,
                    Count = 23,
                    MedicineId = 6,
                    Sum = 360
                });


                context.SaveChanges();
            }
        }
    }
}

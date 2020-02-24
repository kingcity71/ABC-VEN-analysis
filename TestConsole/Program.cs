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
           // DBInitial();
        }
        static void DBInitial()
        {
            using (var context = new ABCVENContext())
            {
                context.Producers.Add(new Producer()
                {
                    Name = "Производитель 1",
                    Country = "Канада"
                });
                context.Producers.Add(new Producer()
                {
                    Name = "Производитель 2",
                    Country = "Россия"
                });
                context.Producers.Add(new Producer()
                {
                    Name = "Производитель 3",
                    Country = "Франция"
                });
                context.Producers.Add(new Producer()
                {
                    Name = "Производитель 4",
                    Country = "Италия"
                });
                context.Producers.Add(new Producer()
                {
                    Name = "Производитель 5",
                    Country = "Испания"
                });

                context.AccountingTypes.Add(new AccountingType() { Name = "Вид учета 1" });
                context.AccountingTypes.Add(new AccountingType() { Name = "Вид учета 2" });
                context.AccountingTypes.Add(new AccountingType() { Name = "Вид учета 3" });
                context.AccountingTypes.Add(new AccountingType() { Name = "Вид учета 4" });
                context.AccountingTypes.Add(new AccountingType() { Name = "Вид учета 5" });

                context.FinanceSources.Add(new FinanceSource() { Name = "Источник финансирования 1" });
                context.FinanceSources.Add(new FinanceSource() { Name = "Источник финансирования 2" });
                context.FinanceSources.Add(new FinanceSource() { Name = "Источник финансирования 3" });
                context.FinanceSources.Add(new FinanceSource() { Name = "Источник финансирования 4" });
                context.FinanceSources.Add(new FinanceSource() { Name = "Источник финансирования 5" });

                context.Stores.Add(new Store() { Name = "Склад 1" });
                context.Stores.Add(new Store() { Name = "Склад 2" });
                context.Stores.Add(new Store() { Name = "Склад 3" });
                context.Stores.Add(new Store() { Name = "Склад 4" });
                context.Stores.Add(new Store() { Name = "Склад 5" });

                context.SaveChanges();
            }
        }
    }
}

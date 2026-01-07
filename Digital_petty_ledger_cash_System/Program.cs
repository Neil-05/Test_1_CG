using System;
using System.Collections.Generic;
using System.Linq;

namespace test
{
    // Interface for generating transaction summaries
    public interface IReportable
    {
        string GetSummary();
    }

    class Program
    {
        static void Main()
        {
            // Create ledgers for income and expenses
            var incomeLedger = new Ledger<IncomeTransaction>();
            var expenseLedger = new Ledger<ExpenseTransaction>();

            // Add income entry
            incomeLedger.AddEntry(
                new IncomeTransaction(
                    1,
                    DateTime.Today,
                    500m,
                    "Petty cash replenishment",
                    "Main Cash"
                )
            );

            // Add expense entries
            expenseLedger.AddEntry(
                new ExpenseTransaction(
                    1,
                    DateTime.Today,
                    20m,
                    "Stationery purchase",
                    "Office"
                )
            );

            expenseLedger.AddEntry(
                new ExpenseTransaction(
                    2,
                    DateTime.Today,
                    15m,
                    "Team snacks",
                    "Food"
                )
            );

            // Calculate totals
            decimal totalIncome = incomeLedger.CalculateTotal();
            decimal totalExpense = expenseLedger.CalculateTotal();
            decimal netBalance = totalIncome - totalExpense;

            // Display totals
            Console.WriteLine($"Total Income   : ${totalIncome}");
            Console.WriteLine($"Total Expense  : ${totalExpense}");
            Console.WriteLine($"Net Balance    : ${netBalance}");
            Console.WriteLine();

            // Combine all transactions for reporting
            List<Transaction> all = new();
            all.AddRange(incomeLedger.GetAll());
            all.AddRange(expenseLedger.GetAll());

            // Display transaction summaries
            foreach (var t in all)
                Console.WriteLine(t.GetSummary());
        }
    }
}

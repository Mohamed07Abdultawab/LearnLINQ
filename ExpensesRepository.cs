using System;
using System.Collections.Generic;

namespace YouTubeLINQ
{
    public record Expenses(
        DateOnly Date,
        double Amount,
        ExpensesType Type
    );

    public static class ExpensesRepository
    {
        public static IEnumerable<Expenses> GetExpenses()
        {
            return new List<Expenses>
            {
                new(new DateOnly(2024, 12, 1), 10.85, ExpensesType.Outcome),
                new(new DateOnly(2024, 12, 2), 88.17, ExpensesType.Income),
                new(new DateOnly(2024, 12, 3), 35.8,  ExpensesType.Income),
                new(new DateOnly(2024, 12, 4), 58.6,  ExpensesType.Outcome),
                new(new DateOnly(2024, 12, 6), 46.19, ExpensesType.Outcome),
                new(new DateOnly(2024, 12, 7), 91.91, ExpensesType.Income),
                new(new DateOnly(2024, 12, 8), 32.59, ExpensesType.Income),
                new(new DateOnly(2024, 12, 9), 75.7,  ExpensesType.Outcome),
                new(new DateOnly(2024, 12, 10), 68.97, ExpensesType.Income),
                new(new DateOnly(2024, 12, 11), 75.28, ExpensesType.Outcome),
                new(new DateOnly(2024, 12, 12), 3.88,  ExpensesType.Income),
                new(new DateOnly(2024, 12, 13), 12.37, ExpensesType.Outcome),
                new(new DateOnly(2024, 12, 14), 83.76, ExpensesType.Income),
                new(new DateOnly(2024, 12, 15), 32.91, ExpensesType.Outcome)
            };
        }

        public static void PrintDate(IEnumerable<Expenses> expenses)
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("|    Date    |   Amount  |    Type    |");
            Console.WriteLine("---------------------------------------");

            foreach (var expense in expenses)
            {
                Console.WriteLine($"| {expense.Date:MM/dd/yyyy} | {expense.Amount,-9:F2} | {expense.Type,-10} |");
            }

            Console.WriteLine("---------------------------------------");
        }
    }

    public enum ExpensesType
    {
        Income,
        Outcome
    }
}

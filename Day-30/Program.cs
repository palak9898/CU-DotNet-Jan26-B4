using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Person
{
    public string Name { get; set; }
    public decimal Balance { get; set; }

    public Person(string name, decimal balance)
    {
        Name = name;
        Balance = balance;
    }
}

class SettlementEngine
{
    public static List<(string Payer, string Receiver, decimal Amount)> 
        SettleExpenses(Dictionary<string, decimal> expenses)
    {
        int n = expenses.Count;
        decimal total = expenses.Values.Sum();
        decimal fairShare = total / n;

        List<Person> creditors = new List<Person>();
        List<Person> debtors = new List<Person>();

        // Calculate balances
        foreach (var entry in expenses)
        {
            decimal balance = entry.Value - fairShare;

            if (balance > 0)
                creditors.Add(new Person(entry.Key, balance));
            else if (balance < 0)
                debtors.Add(new Person(entry.Key, balance));
        }

        // Sort
        creditors = creditors.OrderByDescending(c => c.Balance).ToList();
        debtors = debtors.OrderBy(d => d.Balance).ToList();

        var transactions = new List<(string, string, decimal)>();

        int i = 0, j = 0;

        while (i < debtors.Count && j < creditors.Count)
        {
            var debtor = debtors[i];
            var creditor = creditors[j];

            decimal amount = Math.Min(-debtor.Balance, creditor.Balance);
            amount = Math.Round(amount, 2);

            transactions.Add((debtor.Name, creditor.Name, amount));

            debtor.Balance += amount;
            creditor.Balance -= amount;

            if (Math.Abs(debtor.Balance) < 0.01m) i++;
            if (Math.Abs(creditor.Balance) < 0.01m) j++;
        }

        return transactions;
    }

    public static void ExportToCSV(
        List<(string Payer, string Receiver, decimal Amount)> transactions,
        string filePath)
    {
        using StreamWriter writer = new StreamWriter(filePath);
        writer.WriteLine("Payer,Receiver,Amount");

        foreach (var t in transactions)
        {
            writer.WriteLine($"{t.Payer},{t.Receiver},{t.Amount:F2}");
        }
    }
}

class Program
{
    static void Main()
    {
        var expenses = new Dictionary<string, decimal>
        {
            { "Aman", 900m },
            { "Soman", 0m },
            { "Kartik", 1290m }
        };

        var transactions = SettlementEngine.SettleExpenses(expenses);

        Console.WriteLine("Payer,Receiver,Amount");

        foreach (var t in transactions)
        {
            Console.WriteLine($"{t.Payer},{t.Receiver},{t.Amount:F2}");
        }

        // Optional CSV Export
        SettlementEngine.ExportToCSV(transactions, "settlement.csv");
    }
}

// See https://aka.ms/new-console-template for more information
using System;

class BankTransactionAnalyzer
{
    static void Main()
    {
        Console.WriteLine("Enter transaction in the format: <TransactionId>#<AccountHolderName>#<TransactionNarration>");
        string input = Console.ReadLine();
        string[] data = input.Split('#');
        if (data.Length != 3)
        {
            Console.WriteLine("Invalid input format.");
            return;
        }

        string transactionId = data[0].Trim();
        string accountHolder = data[1].Trim();
        string narration = data[2].Trim();

        while (narration.Contains("  ")) 
        {
            narration = narration.Replace("  ", " ");
        }
        narration = narration.ToLower(); 

        bool containsKeyword = narration.Contains("deposit") || narration.Contains("withdrawal") || narration.Contains("transfer");

        string standardNarration = "cash deposit successful";

        string category;
        if (!containsKeyword)
        {
            category = "NON-FINANCIAL TRANSACTION";
        }
        else if (narration.Equals(standardNarration))
        {
            category = "STANDARD TRANSACTION";
        }
        else
        {
            category = "CUSTOM TRANSACTION";
        }

        Console.WriteLine($"Transaction ID : {transactionId}");
        Console.WriteLine($"Account Holder : {accountHolder}");
        Console.WriteLine($"Narration      : {narration}");
        Console.WriteLine($"Category       : {category}");
    }
}


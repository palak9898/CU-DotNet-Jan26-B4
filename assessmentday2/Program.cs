using System;

class MyClass
{
    public static void Main(string[] args)
    {
        string[] policyHolderNames = new string[5];
        decimal[] annualPremiums = new decimal[5];

        decimal totalPremiumAmount = 0;
        decimal highestPremium = 0;
        decimal lowestPremium = 0;
        decimal averagePremium = 0;

        MyClass obj = new MyClass();

        obj.TakeInput(policyHolderNames, annualPremiums);

        obj.Processing(ref policyHolderNames,ref annualPremiums,ref totalPremiumAmount,ref highestPremium,ref lowestPremium,ref averagePremium);

        obj.Display(policyHolderNames,annualPremiums,totalPremiumAmount,highestPremium,lowestPremium,averagePremium);
    }

    public void TakeInput(string[] policyHolderNames, decimal[] annualPremiums)
    {
        for (int i = 0; i < 5; i++)
        {
            while (true)
            {
                Console.WriteLine($"Enter name of {i + 1}th policy holder");
                string inputName = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(inputName))
                {
                    policyHolderNames[i] = inputName;
                    break;
                }

                Console.WriteLine("Name cannot be empty... Input again");
            }

            while (true){
                Console.WriteLine($"Enter amount of {i + 1}th policyholder");

                if (decimal.TryParse(Console.ReadLine(), out decimal inputPremium))
                {
                    if (inputPremium > 0)
                    {
                        annualPremiums[i] = inputPremium;
                        break;
                    }
                    else
                    {
                    Console.WriteLine("Enter amount greater than 0");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a numeric value.");
                }
            }

        }
    }

    public void Processing(ref string[] policyHolderNames,ref decimal[] annualPremiums,ref decimal totalPremiumAmount,ref decimal highestPremium,ref decimal lowestPremium,ref decimal averagePremium){
        totalPremiumAmount = 0;
        highestPremium = annualPremiums[0];
        lowestPremium = annualPremiums[0];

        for (int i = 0; i < 5; i++)
        {
            totalPremiumAmount += annualPremiums[i];

            if (annualPremiums[i] > highestPremium)
                highestPremium = annualPremiums[i];

            if (annualPremiums[i] < lowestPremium)
                lowestPremium = annualPremiums[i];
        }
        averagePremium = totalPremiumAmount / 5;
    }

    public void Display(string[] policyHolderNames,decimal[] annualPremiums,decimal totalPremiumAmount,decimal highestPremium,decimal lowestPremium,decimal averagePremium){
        Console.WriteLine("\nINSURANCE PREMIUM SUMMARY");
        Console.WriteLine("-------------------------------------------------------");
        Console.WriteLine("{0,-20} {1,-15} {2,-10}", "NAME", "PREMIUM", "CATEGORY");
        Console.WriteLine("-------------------------------------------------------");

        for (int i = 0; i < 5; i++)
        {
            string name = policyHolderNames[i].ToUpper();
            string category;

            if (annualPremiums[i] < 10000)
                category = "LOW";
            else if (annualPremiums[i] <= 25000)
                category = "MEDIUM";
            else
                category = "HIGH";

            Console.WriteLine("{0,-20} {1,-15:F2} {2,-10}",
                name,
                annualPremiums[i],
                category
            );
        }

        Console.WriteLine("-------------------------------------------------------");
        Console.WriteLine($"Total Premium   : {totalPremiumAmount:F2}");
        Console.WriteLine($"Average Premium : {averagePremium:F2}");
        Console.WriteLine($"Highest Premium : {highestPremium:F2}");
        Console.WriteLine($"Lowest Premium  : {lowestPremium:F2}");
    }
}

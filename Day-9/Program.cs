// See https://aka.ms/new-console-template for more information
using System;

class Day9
{
    public static void Main(string[] args)
    {
        decimal[] dailySales = new decimal[7];
        Console.WriteLine("Enter sales for each day(1-7)");
        decimal totalSales = 0;
        for(int i = 0; i < 7; i++)
        {
            while (true)
            {
                Console.WriteLine($"Enter sales for {i+1}th day");
                decimal input = decimal.Parse(Console.ReadLine());
                if (input >= 0)
                {
                    dailySales[i]= input;
                    break;
                }
                else
                {
                    Console.WriteLine("Enter valid amount greater than or equal to 0");
                }
            }

            totalSales += dailySales[i];

        }
        decimal averageSales = totalSales/(dailySales.Length);
        decimal highestSales = dailySales.Max();
        int highestIndex = Array.IndexOf(dailySales,highestSales);
        decimal lowestSales = dailySales.Min();
        int lowestIndex = Array.IndexOf(dailySales,lowestSales);
        int count =0;
        for(int i = 0; i < 7; i++)
        {
            if(averageSales < dailySales[i])
            {
                count+=1;
            }
        }
        string[] category = new string[7];

        for(int i = 0; i < 7; i++)
        {
            if(dailySales[i]< 5000)
            {
                category[i] = "Low";
            }
            else if(dailySales[i]>= 5000 && dailySales[i] <= 15000)
            {
                category[i] = "Medium";
            }
            else
            {
                category[i] = "High";
            }

        }
        Console.WriteLine("Weekly Sales Report");
        Console.WriteLine("---------------");

        Console.WriteLine($"totalSales    :{totalSales}");
        Console.WriteLine($"Average Daily Sale   :{averageSales:F2}");
        Console.WriteLine($"Highest Sale     :{highestSales}(Day{highestIndex})");
        Console.WriteLine($"Lowest Sale      :{lowestSales}(Day{lowestIndex})");
        Console.WriteLine($"Days Above Average :{count}");

        Console.WriteLine("Day");
        for(int i = 0; i < 7; i++)
        {
            Console.WriteLine($"{i+1}: {category[i]}");
        }
        
    }
}

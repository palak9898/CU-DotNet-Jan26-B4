using System;
class Day10
{
    public static void Main(string[] args)
    {
        int days = 7;
        decimal[] sales = new decimal[days];
        string[] categories = new string[days];

        Console.Write("Is it a festive week? (true/false): ");
        bool isFestiveWeek = bool.Parse(Console.ReadLine());

        ReadWeeklySales(sales);

        decimal total = CalculateTotal(sales);
        decimal average = CalculateAverage(total, days);

        decimal highest = FindHighestSale(sales, out int highestDay);
        decimal lowest = FindLowestSale(sales, out int lowestDay);

        decimal discountPercentage = CalculateDiscount(total);
        decimal extraDiscountPercentage = CalculateDiscount(total, isFestiveWeek);
        decimal discount = (discountPercentage*total)/100;
        decimal extraDiscount = (discount*extraDiscountPercentage)/100;

        decimal taxableAmount = total - discount - extraDiscount;
        decimal tax = CalculateTax(taxableAmount);

        decimal finalAmount = CalculateFinalAmount(total, discount, tax, extraDiscount);

        GenerateSalesCategory(sales, categories);

        Console.WriteLine("\nWeekly Sales Summary");
        Console.WriteLine("---------------------");
        Console.WriteLine($"Total Sales          : {total}");
        Console.WriteLine($"Average Daily Sale   : {average}");
        Console.WriteLine($"Highest Sale         : {highest} (Day {highestDay + 1})");
        Console.WriteLine($"Lowest Sale          : {lowest} (Day {lowestDay + 1})");
        Console.WriteLine($"Discount Applied     : {discountPercentage + extraDiscount}%");
        Console.WriteLine($"Extra Discount       : {extraDiscount}%");
        Console.WriteLine($"Tax Amount           : {tax}");
        Console.WriteLine($"Final Payable Amount : {finalAmount}");

        Console.WriteLine("\nDay-wise Category");
        for (int i = 0; i < days; i++)
        {
            Console.WriteLine($"Day {i + 1} : {categories[i]}");
        }
    }

    static void ReadWeeklySales(decimal[] sales)
    {   
        #region validate
        Console.WriteLine("Enter sales for a week:");
        for (int i = 0; i < 7; i++)
        {
            while (true)
            {
                Console.Write($"Enter sale for Day {i + 1}: ");
                if (decimal.TryParse(Console.ReadLine(), out decimal input) && input >= 0)
                {
                    sales[i] = input;
                    break;
                }
                Console.WriteLine("Invalid input. Enter a positive number.");
            }
        }
        #endregion 

    }

    static decimal CalculateTotal(decimal[] sales)
    {
        return sales.Sum();
    }

    static decimal CalculateAverage(decimal totalSales, int days)
    {
        return totalSales/ days;
    }

    static decimal FindHighestSale(decimal[] sales, out int day)
    {
        decimal highest = sales.Max();
        day = Array.IndexOf(sales, highest);
        return highest;
    }

    static decimal FindLowestSale(decimal[] sales, out int day)
    {
        decimal lowest = sales.Min();
        day = Array.IndexOf(sales, lowest);
        return lowest;
    }

    static decimal CalculateDiscount(decimal total)
    {
        return total >= 50000 ? 10 : 5;
    }

    static decimal CalculateDiscount(decimal total, bool isFestiveWeek)
    {
        return isFestiveWeek ? 5 : 0;
    }

    static decimal CalculateTax(decimal amount)
    {
        return (18 * amount)/ 100;
    }

    static decimal CalculateFinalAmount(decimal total, decimal discount, decimal tax, decimal extraDiscount)
    {
        decimal afterDiscount = total - (discount * total / 100);
        decimal afterExtraDiscount = afterDiscount - (extraDiscount * afterDiscount / 100);
        decimal finalAmount = afterExtraDiscount + tax;

        return finalAmount;
    }

    static void GenerateSalesCategory(decimal[] sales, string[] categories)
    {
        for (int i = 0; i < 7; i++)
        {
            if (sales[i] < 5000)
                categories[i] = "Low";
            else if (sales[i] <= 15000)
                categories[i] = "Medium";
            else
                categories[i] = "High";
        }
    }
}

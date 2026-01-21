// See https://aka.ms/new-console-template for more information
using System;


class Practice
{
    public static void Main()
    {

        Console.WriteLine("Enter true or false if you want a service or not");
        
        Console.WriteLine("Tread-Mill");
        bool treadMill = bool.Parse(Console.ReadLine());
        Console.WriteLine("Weight-Ligting");
        bool weightLifting = bool.Parse(Console.ReadLine());
        Console.WriteLine("Zumba Classes");
        bool zumbaClasses = bool.Parse(Console.ReadLine());
        double billAmount = CalculateGymBill(treadMill,weightLifting,zumbaClasses);
        Console.WriteLine($"Bill is {billAmount}");

    }
    static void GetSquareAndCube(int num, out int square, out int cube)
    {
        square = Convert.ToInt32(Math.Pow(num,2));
        cube = Convert.ToInt32(Math.Pow(num,3));
    }
    static double CalculateGymBill(bool treadMill, bool weightLifting, bool zumbaClasses)
    {
        double bill = 1000.0;
        if(treadMill)
        {
            bill += 300;
        }
        if (weightLifting)
        {
            bill+= 500;
        }
        if (zumbaClasses)
        {
            bill +=250;
        }
        else
        {
            Console.WriteLine("No sservice opted so fee of 200 is applied");
            bill = bill +200;
        }
        bill += bill * 0.05;
        return bill;
    }    
} 

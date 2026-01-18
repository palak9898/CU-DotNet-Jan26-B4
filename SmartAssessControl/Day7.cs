// See https://aka.ms/new-console-template for more information
using System;

class Day7
{
    public static void Main()
    {
        Console.WriteLine("Enter value of GateCode, UserInitial, AccessLevel, IsActive, Attempts in onle line with spacing");

        string input = Console.ReadLine();

        string[] data = input.Split(" ");

        string GateCode = data[0];
        char UserInitial = data[1][0];
        byte AccessLevel = byte.Parse(data[2]);
        bool IsActive = bool.Parse(data[3]);
        byte Attempts = byte.Parse(data[4]);

        if(GateCode.Length!=2 || !char.IsLetter(GateCode[0]) || !char.IsDigit(GateCode[1]))
        {
            Console.WriteLine("INVALID ACCESS LOG");
            return;
        }
        if(!char.IsLetter(UserInitial) || !char.IsUpper(UserInitial))
        {
            Console.WriteLine("INVALID ACCESS LOG");
            return;
        }
        if(AccessLevel<1 || AccessLevel>9)
        {
            Console.WriteLine("INVALID ACCESS LOG");
            return;
        }
        
        if(Attempts>200){
            Console.WriteLine("INVALID ACCESS LOG");
            return;
        }
        string status;
        if(IsActive == false)
        {
            status = "ACCESS DENIED - INACTIVE USER";
        }
        else if (Attempts > 100)
        {
            status = "ACCESS DENIED - TOO MANY ATTEMPTS";
        }
        else if (AccessLevel >= 5)
        {
            status = "ACCESS GRANTED - HIGH SECURITY";
        }
        else
        {
            status = "ACCESS GRANTED - STANDARD";
        }

        Console.WriteLine($"Gate  :   {GateCode} ");
        Console.WriteLine($"User  :   {UserInitial} ");
        Console.WriteLine($"Level :  {AccessLevel} ");
        Console.WriteLine($"Attempts  : {Attempts} ");
        Console.WriteLine($"Status  : {status} ");

    } 
}


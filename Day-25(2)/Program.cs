// See https://aka.ms/new-console-template for more information
using System;
using System.Net.NetworkInformation;

class Program
{
    static void Main()
    {
        // string pin = "";
        // Console.Write("Enter 4-digit PIN: ");

        // while (pin.Length < 4)
        // {
        //     ConsoleKeyInfo key = Console.ReadKey(true); //to show or not the entered value

        //     if (char.IsDigit(key.KeyChar))
        //     {
        //         pin += key.KeyChar; 
        //         Console.Write("*");    
        //     }
        // }
        // Console.WriteLine();
        // Console.WriteLine("PIN entered successfully.");
        // Console.WriteLine("Actual PIN: " + pin); 
        
        Console.WriteLine("Enter 4-digit pin");
        string str="" ;
        while(str.Length<4){
            ConsoleKeyInfo info = Console.ReadKey(true);
            if(info.Key == ConsoleKey.Backspace && str.Length>0)
            {
                str = str.Substring(0, str.Length-1);

            }
            else
            {
                str += info.KeyChar;
                Console.Write("*");
            } 
            
        }
        Console.WriteLine(str);
    }
}


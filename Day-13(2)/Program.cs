// See https://aka.ms/new-console-template for more information
using System;
class Day13
{
    public static void Main(string[] args){
        displayOutput();
        displayOutput(ch: '$');
        displayOutput(60, '+');
        displayOutput(70);
    }
    static void displayOutput(int ch = 40, char chr = '-'){

        for(int i=0;i< ch; i++)
        {
            Console.Write(chr);
            
        }
        Console.WriteLine(" ");
            
    }
    
}

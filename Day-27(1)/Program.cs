using System;
class Day27
{
    static void Main(string[] args)
    {
        
        
        string file = @"journal.txt";
        
        try
        {
            //FileStream fs = new FileStream(File, FileMode.Append);
            using StreamWriter sw  = new StreamWriter(file,true);
            Console.WriteLine("Daily Reflection Entry");
            do
            {
            string input = Console.ReadLine();
            if(input == "stop")
            {
                break;
            }
            sw.WriteLine(input);
            }
            while(true);
        }
        catch(FileNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch
        {
            System.Console.WriteLine("Error while opening file");
        }
        
    }
}

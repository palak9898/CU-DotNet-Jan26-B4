// See https://aka.ms/new-console-template for more information
class Practice
{
    static void Main(string[] args)
    {
        // try
        // {
        //     string file = @"..\..\..\file1.txt";
        //     using FileStream fs = new FileStream(file,FileMode.Create);
        //     char ch;
        //     do
        //     {   int i = fs.ReadByte(); 
        //         if(i!= -1)
        //         {
        //             System.Console.WriteLine((char)i);
        //         }
        //         else
        //         {
        //             break;
        //         }
            
        //         Console.Write(ch);
        //     }
        //     while (true);
            
        //     // for(char ch = 'A'; ch <= 'Z'; ch++)
        //     // {
        //     //     fs.WriteByte((byte)ch);
        //     // }
            
        
        // }
        // catch(Exception ec)
        // {
        //     System.Console.WriteLine("error is - " + ec);
        // }
        string file = @"stud.csv";
        using FileStream fs = new FileStream(file,FileMode.Create);
        using StreamWriter sw = new StreamWriter(fs);
        string[] data =
        {
            "1,stud1,77",
            "2,stud2,67",
            "3,stud3,20"
        };
        foreach (string line in data)
        {
            sw.WriteLine(line);
        }
    }
}

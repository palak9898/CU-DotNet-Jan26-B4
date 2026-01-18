// See https://aka.ms/new-console-template for more information

// using System;
// class Day8{
//     public static void Main()
//     {
//         Console.WriteLine("Enter UserName | Login Message");
//         string input = Console.ReadLine();

//         string[] data = input.Split("|");
//         if (data.Length < 2)
//         {
//             Console.WriteLine("Invalid input format. Please enter: UserName|LoginMessage");
//             return;
//         }
//         string UserName = data[0];
//         string LoginMessage = data[1].Trim().ToLower();

//         bool contain = LoginMessage.Contains("successful");
//         string status="";
//         string standardMessage = "login successful";
//         if(contain && contain.Equals("login successful"))
//         {
//             status = "LOGIN SUCCESS";
//         }
//         else if (!contain)
//         {
//             status = "LOGIN FAILED";
//         }
//         else if(!contain.Equals("login successful") && contain== true)
//         {
//             status = "LOGIN SUCCESS(CUSTOM MESSAGE)";
//         }

//         Console.WriteLine($"User   : {UserName}");
//         Console.WriteLine($"Message : {LoginMessage}");
//         Console.WriteLine($"Status   :{status}");
//     }
// }
using System;

class Day8
{
    public static void Main()
    {
        Console.WriteLine("Enter UserName | Login Message");
        string input = Console.ReadLine();
        tring[] data = input.Split('|');

        if (data.Length< 2)
        {
            Console.WriteLine("Invalid input format. Please enter: UserName|LoginMessage");
            return;
        }

        string UserName = data[0].Trim();            
        string LoginMessage = data[1].Trim();          

        string status = "";
        string standardMessage = "login successful";

        if (LoginMessage.IndexOf("successful", StringComparison.OrdinalIgnoreCase) >= 0)
        {
            if (LoginMessage.Equals(standardMessage, StringComparison.OrdinalIgnoreCase))
            {
                status = "LOGIN SUCCESS";
            }
            else
            {
                status = "LOGIN SUCCESS (CUSTOM MESSAGE)";
            }
        }
        else
        {
            status = "LOGIN FAILED";
        }
        Console.WriteLine($"User    : {UserName}");
        Console.WriteLine($"Message : {LoginMessage}");
        Console.WriteLine($"Status  : {status}");
    }
}


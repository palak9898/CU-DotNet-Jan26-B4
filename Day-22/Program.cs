

//create string with pan number and validate it. if right return true else false
using System.Text.RegularExpressions;

class PanPractice
{
    //public static bool Validate(string str)
    //{
        // if (str.Length != 10)
        // {
        //     return false;
        // }
        // for(int i = 0; i < 5; i++)
        // {
        //     if(!(str[i]>='A' && str[i] <= 'Z'))
        //     {
        //         return false;
        //     }
        // }
        // for(int i = 5; i < 9; i++)
        // {
        //     if(!(str[i]>='0' && str[i] <= '9'))
        //     {
        //         return false;
        //     }
        // }
        // if (!(str[9] >= 'A' && str[9] <= 'Z'))
        //     return false;

        // return true;
    //}
    public static void Main(string[] args)
    {
        // string str = "HAHPP1203A";
        // bool validated = Validate(str);
        // Console.WriteLine(validated);
        string pan = "ABCDE1234Z";
        bool validPan = Regex.IsMatch(pan,@"^[A-Z]{5}[0-9]{4}[A-Z]{1}$");
        Console.WriteLine(validPan);  //it checks if some is right then also return true so we must check for exact matching 

        string mobile = "9988776655";
        bool validMob = Regex.IsMatch(mobile, @"^[7-9]{1}[0-9]{3}-[0-9]{5}$");
        Console.WriteLine(validMob);

        string name = "aal";
        bool validName = Regex.IsMatch(name,@"^[A-Z]{1}[a-z]{2,}$");
        Console.WriteLine(validName);

        string fullName = "Palak Arora";
        bool validFullName = Regex.IsMatch(name,@"^[A-Z]{1}[a-z]{2,}[ ]{1}[A-Z]{1}[a-z]{2,}$");
        Console.WriteLine(validFullName);


    }

}
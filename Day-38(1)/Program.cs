
// class Program
// {
//     public static string CleanseAndInvert(string input)
//     {
//         if(input == null || input.Length < 6)
//         {
//             return "";
//         }
//         for(int i=0;i< input.Length; i++)
//         {
//             if(!(input[i]>= 'a' && input[i]<= 'z') || (input[i]>='A' && input[i]<='Z'))
//             {
//                 return "";
//             }
//         }
//         string result = "";
//         input = input.ToLower();
//         for(int i=0;i<input.Length ; i++)
//         {
//             if(input[i] % 2 != 0)
//             {
//                 result += input[i];
//             }
//         }
//         string uppercaseString = result.ToUpper();
//         string reversedInput = "";
//         for(int i=result.Length -1; i >= 0; i--)
//         {
//             if(i%2 == 0)
//             {
//                 reversedInput +=uppercaseString[i];
//             }
//             else
//             {
//                 reversedInput += result[i];
//             }

//         } 
//         return reversedInput;
//     }
//     static void Main(string[] args)
//     {
//         string output = CleanseAndInvert("B@rbie");
//         if(output == "")
//         {
//             System.Console.WriteLine("Invalid String");
//         }
//         System.Console.WriteLine(output);
//     }
// }
// using System.Runtime.InteropServices;

// class Program
// {
//     public static int SumOfDigitsInString(string input)
//     {
//         string digits="";
//         int sum =0;
//         bool flag = true;
//         for(int i = 0; i < input.Length; i++)
//         {
//             if(input[i] >= '0' && input[i] <= '9')
//             {
//                 flag = false;
//             }
//         }
//         if (flag)
//         {
//             return -1;
//         }
//         for(int i=0;i<input.Length; i++)
//         {
//             if(input[i] >= '0' && input[i] <= '9')
//             {
//                 digits+=input[i];
//             }
//         }
//         for(int i = 0; i < digits.Length; i++)
//         {
//             int currentDigit = digits[i] - '0';
//             sum+= currentDigit;
//         }
//         return sum;
//     }
//     static void Main(string[] args)
//     {
//         int result =  SumOfDigitsInString("A2b5c9");
//         System.Console.WriteLine(result);
//     }
// }
class Program
{
    public static void VowelShiftCipher(string input)
    {
        string isVowel = "aeiou";
        string isConsonant = "bcdfghjklmnpqrstvwxyz";
        char[] arr = input.ToCharArray();
        string output = "";
        for(int i=0;i<arr.Length; i++)
        {
            char currentElement = arr[i];

            if (isVowel.Contains(currentElement))
            {
                int index = isVowel.IndexOf(currentElement);
                if( index >=0 && index <= isVowel.Length - 2)
                {
                    output += isVowel[index +1];
                }
                else
                {
                    output+= isVowel[0];
                }
            }
            else
            {
                int index = isConsonant.IndexOf(currentElement);
                if(index == isConsonant.Length - 1)
                {
                    output+= isConsonant[0];
                }
                else
                {
                    output += isConsonant[index+1];
                }
                
            }
        }
        System.Console.WriteLine(output);

    }
    static void Main(string[] args)
    {
        VowelShiftCipher("hello");
    }
}
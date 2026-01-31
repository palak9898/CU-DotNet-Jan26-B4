
using System;

class Practice1
{
    public static void Main(string[] args)
    {
        string str = "abbaaabbbccccddddd";

        char currentChar = str[0];
        int count = 1;

        for (int i = 1; i < str.Length; i++)
        {
            if (currentChar == str[i])
            {
                count++;
            }
            else
            {
                Console.Write(currentChar);
                Console.Write(count);

                currentChar = str[i];
                count = 1;
            }
        }

        // Print last character group
        Console.Write(currentChar);
        Console.Write(count);
    }
}

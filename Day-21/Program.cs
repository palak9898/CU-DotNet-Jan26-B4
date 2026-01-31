
using System;
using System.Collections.Immutable;

// class Program
// {
//     static void Main()
//     {
//         string sentence = "this is a sentence";
//         sentence = sentence.ToLower();

//         for(char ch = 'a'; ch <= 'z'; ch++)
//         {
//             int count = 0;
//             foreach (char c in sentence)
//             {
//                 if(c == ch){
//                     count++;
//                 }
//             }
//             Console.WriteLine($"character is {ch} : {count}");
//         }
//     }
// 

// class Program
// {
//     static void Main()
//     {
//         string sentence = "this is a sentence".ToLower();

//         char[] arr = sentence.Replace(" ", "").ToCharArray();

//         Array.Sort(arr);

//         int[] freq = new int[26];   

//         foreach (char c in arr)
//         {
//             freq[c - 'a']++;
//         }

//         for (int i = 0; i < 26; i++)
//         {
//             Console.WriteLine($"{(char)(i + 'a' )} : {freq[i]}");
//         }
//     }
// }
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string sentence = "this is a sentence".ToLower();

        char[] arr = sentence.Replace(" ", "").ToCharArray();

        Dictionary<char, int> dict = new Dictionary<char, int>();

        for (char c = 'a'; c <= 'z'; c++)
        {
            dict[c] = 0;
        }

        foreach (char c in arr)
        {
            dict[c]++;
        }

        foreach (var item in dict)
        {
            Console.WriteLine($"{item.Key} : {item.Value}");
        }
    }
}



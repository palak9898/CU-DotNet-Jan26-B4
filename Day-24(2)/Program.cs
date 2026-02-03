// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.Net.Cache;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Encodings.Web;

class Day24
{
    static void Main(string[] args)
    {
        Hashtable ht = new Hashtable();
        ht.Add(101, "Alice");
        ht.Add(102, "Bob");
        ht.Add(103, "Charlie");
        ht.Add(104, "Diana");
        ht.Add(105, "Edward");
        
        //unique key check
        if(ht.ContainsKey(105))
        {
            System.Console.WriteLine("Id already exists");
        }
        else
        {
            ht.Add(105, "Edward");
        }
        foreach(DictionaryEntry item in ht)
        {
            System.Console.WriteLine("ID: " + item.Key + " Name: " + item.Value);
        }
        // data retrieval and boxing
        foreach(DictionaryEntry item in ht)
        {
            if(item.Key is 102)
            {
                string name = (string)(item.Value);
                System.Console.WriteLine(name);
            }
        }
        ht.Remove(103);
        System.Console.WriteLine(ht.Count);
    }
}

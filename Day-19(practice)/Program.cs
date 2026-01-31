// See https://aka.ms/new-console-template for more information
using System.Collections;

class Collections
{
    static IEnumerable<int> GetFactorial(int nums)
    {
        int fact = 1;
        for(int i = 2; i <= nums; i++)
        {
            fact*=i;
            yield return fact;
        }
    }
    public static void Main()
    {
        foreach(var item in GetFactorial(5))
        {
            Console.WriteLine(item);
        }
        // non generic collection 
        ArrayList list = new ArrayList();
        list.Add(12);
        list.Add("abc");

        foreach(var item in list)
        {
            Console.Write(item);
        }


        List<int> marks = new List<int>{
            44,55,66,77
        };
        marks.Add(14);
        marks.Insert(0, 22);

        Console.WriteLine(marks.Count);
        Console.WriteLine(string.Join(",", marks));
        //Console.WriteLine(marks);
        foreach(var item in marks)
        {
            Console.Write(item);
        }
    }
}

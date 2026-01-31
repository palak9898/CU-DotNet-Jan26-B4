class myClass
{
    

static void Main(string[] args)
{
    Dictionary<string, string> countrtCapitals = new Dictionary<string, string>();
    countrtCapitals.Add("India","Delhi");
    countrtCapitals.Add("Australia","Perth");
    countrtCapitals.Add("Afganistan", "Kabul");
    countrtCapitals["Monaco"] = "Monaco";  // modify existing 
    if (!countrtCapitals.ContainsKey("Afganistan"))
    {
        countrtCapitals.Add("Afganistan", "Kabul");  // if condition to check value
    }
    else
    {
        Console.WriteLine("already exists");
    }

    foreach (KeyValuePair<string, string> item in countrtCapitals)
    {
        Console.WriteLine($"{item.Key } - {item.Value}");
    }
    foreach(string capital in countrtCapitals.Values)
    {
            Console.WriteLine(capital);
    }
    Console.WriteLine("Enter any country");
    string ctr = Console.ReadLine();
    string cap = string.Empty;
    bool existing =  countrtCapitals.TryGetValue(ctr, out cap);  // if avai;able assign value to cap else false staored
        if (existing)
        {
            Console.WriteLine(cap);
        }
        else
        {
            Console.WriteLine($"country {ctr} donot exist");
        }
    Console.WriteLine($"{countrtCapitals[ctr]}");


}
}

// See https://aka.ms/new-console-template for more information

class SortedDictPractice
{
    static void Main(string[] args)
    {
        SortedDictionary<double,string> dict = new SortedDictionary<double, string>();
        dict.Add(55.42,"SwiftRacer");
        dict.Add(52.10,"SpeedDemon");
        dict.Add(58.91,"SteadyEddie");
        dict.Add(51.05,"TurboTom");

        foreach(var item in dict)
        {
            System.Console.WriteLine(item.Key + " " + item.Value);
        }

        System.Console.WriteLine("First item is: "+ dict.Keys.First()+ " Last item is: " + dict.Keys.Last()); 
        double idToRemove=0;
        foreach(var item in dict)
        {
            
            if(item.Value == "SteadyEddie")
            {
                idToRemove = item.Key;     
            }
        }
        if(idToRemove!=0){
        dict.Remove(idToRemove);
        }
        
        System.Console.WriteLine("Deletion done");
        dict.Add(54.00,"SteadyEddie");
        

        Console.WriteLine("List after updation ");
        System.Console.WriteLine();
        foreach(var item in dict)
        {
            System.Console.WriteLine( item.Key + " " + item.Value);
        }
    }
}

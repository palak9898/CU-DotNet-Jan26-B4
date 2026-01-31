// See https://aka.ms/new-console-template for more information
using System.Security.AccessControl;
class Laptop: IComparable<Laptop>
{
    public int LaptopID { get; set; }
    public string Company { get; set; }
    public string ModelName { get; set; }
    public int Price { get; set; }
    // public int CompareTo(Object? obj)
    // {
    //     Laptop other = (Laptop)obj;   Conversion is required for comparison 
    //     return this.LaptopID.CompareTo(other.LaptopID);
        
    // }
    public int CompareTo(Laptop? other)
    {
        return this.LaptopID.CompareTo(other.LaptopID);
        
    }
    public override string ToString()
    {
        return $"{LaptopID} {Company} {ModelName} {Price}";
    }
}
class LaptopPriceSorter: IComparer<Laptop>
{
    public int Compare(Laptop? x, Laptop? y)
    {
        return x.Price.CompareTo(y.Price);
    }
}
class LaptopCompanySorter: IComparer<Laptop>
{
    public int Compare(Laptop? x, Laptop? y)
    {
        return x.Company.CompareTo(y.Company);
    }
}
class Demo
{
    public static void Main()
    {
        // Laptop l1 = new Laptop[]        {
        //     LaptopID= 105,
        //     Company = "Dell",
        //     ModelName = "e4",
        //     Price = 67000
            
        // };
        // Laptop[] laptops = new Laptop[]. Array of laptop
        // {
        //     new Laptop(){
        //     LaptopID= 106,
        //     Company = "Hp",
        //     ModelName = "e4",
        //     Price = 67000
            
        // },    
        //     new Laptop(){
        //     LaptopID= 104,
        //     Company = "Lenovo",
        //     ModelName = "e4",
        //     Price = 67000
            
        // } Array.Sort(laptops);
        
        List<Laptop> laptops = new List<Laptop>// //Array of laptop
        {
            new Laptop(){
            LaptopID= 106,
            Company = "Hp",
            ModelName = "e4",
            Price = 67000
            
        },    
            new Laptop(){
            LaptopID= 104,
            Company = "Lenovo",
            ModelName = "e4",
            Price = 50000
            
        }
        };
        //IComparer<Laptop> priceSorter = new LaptopPriceSorter();  //interface object refer to child class object
        laptops.Sort(new LaptopPriceSorter());  //write collection name //if nothing is passed comparablee will execute
        
        foreach(var item in laptops)
        {
            Console.WriteLine(item);
        }
        
        Console.WriteLine("Done");
    }
}



class Flight: IComparable<Flight>
{
    public string FlightNumber { get; set; }
    public decimal Price { get; set; }
    public TimeSpan Duration { get; set; }
    public DateTime DepartureTime { get; set; }
    public Flight(string number, decimal price, TimeSpan duration, DateTime departure)
    {
        FlightNumber = number;
        Price = price;
        Duration = duration;
        DepartureTime = departure;
#if DEBUG
       Console.WriteLine("Constructors");
#endif
    }
    public int CompareTo(Flight? fly)
    {
        if (fly == null) return 1;
        return this.Price.CompareTo(fly?.Price);
    }
    public override string ToString()
    {
        return $"Price: {Price}, Duration : {Duration},DepartureTime: {DepartureTime}";
    }
}
class DurationComparer : IComparer<Flight>
{
    public int Compare(Flight? fly1, Flight? fly2)
    {
        if (fly1 == null || fly2 == null) return 0;
        return fly1.Duration.CompareTo(fly2.Duration);
    }
}
class DepartureComparator : IComparer<Flight>
{
    public int Compare(Flight? fly1, Flight? fly2)
    {
        if (fly1 == null || fly2 == null) return 0;
        return fly1.DepartureTime.CompareTo(fly2.DepartureTime);
    }
}
class Day20first
{
    public static void Main(String[] args)
    {
        List<Flight> fly = new List<Flight>
        {
            new Flight("ABC123", 6700, new TimeSpan(3, 5, 40), new DateTime(2027, 1, 30, 10, 30, 34) ),
            new Flight("XYZ987", 6000, new TimeSpan(1, 2, 28), new DateTime(2025, 2, 28, 10, 30, 0) ),
            new Flight("XYZ987", 5600, new TimeSpan(2, 2, 28), new DateTime(2025, 3, 28, 10, 30, 0) )

        };
        fly.Add
        (
            new Flight("LMN555", 8000,
            new TimeSpan(0, 5, 0, 0),
            new DateTime(2026, 5, 10, 9, 0, 0))
        );

        Console.WriteLine("-------Before Sorting------");
        foreach(var item in fly)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("-------Economy View--------");
        fly.Sort();
        foreach(var item in fly)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("-------Business Runner View--------");
        fly.Sort(new DurationComparer());
        foreach(var item in fly)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("-------Early Runner View--------");
        fly.Sort(new DepartureComparator());
        foreach(var item in fly)
        {
            Console.WriteLine(item);
        }
        

    }
}
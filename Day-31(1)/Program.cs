class Student
{
    public int Id;
    public string Name;
    public string Class;
    public int Marks;
}
class Employee
{
    public int Id;
    public string Name;
    public string Dept;
    public double Salary;
    public DateTime JoinDate;
}
class Book { 
    public string Title; 
    public string Author; 
    public string Genre; 
    public int Year; 
    public double Price; 
}
class Customer 
{ 
    public int Id; 
    public string Name; 
    public string City; 
}
class Order 
{
    public int OrderId; 
    public int CustomerId; 
    public double Amount; 
}
class Movie 
{ 
    public string Title; 
    public string Genre; 
    public double Rating; 
    public int Year; 
}
class Product 
{ 
    public int Id; 
    public string Name; 
    public string Category; 
    public double Price; 
}
class Sale 
{ 
    public int ProductId; 
    public int Qty; 
}
class CartItem
{
    public string Name;
    public string Category;
    public double Price;
    public int Qty;
}
class CartSummaryDTO
{
    public string Name;
    public string Category;
    public double FinalAmount;
}



class LinqPreactice
{
    static void Main(string[] args)
    {
        // 1. Student performance analysis
        var students = new List<Student>
        {
            new Student{Id=1, Name="Amit", Class="10A", Marks=85},
            new Student{Id=2, Name="Neha", Class="10A", Marks=72},
            new Student{Id=3, Name="Rahul", Class="10B", Marks=90},
            new Student{Id=4, Name="Pooja", Class="10B", Marks=60},
            new Student{Id=5, Name="Kiran", Class="10A", Marks=95}

        };

        // var top3ByMarks = students.OrderByDescending(o=> o.Marks).Take(3);
        // foreach (var item in top3ByMarks)
        // {
        //     System.Console.WriteLine(item.Name + " - " + item.Marks);
        // }    
        // var grouping = students.GroupBy(o=> o.Class).Select(o=> new{ClassName = o.Key, Average = o.Average(o=>o.Marks) });
        // foreach (var item in grouping)
        // {
        //     System.Console.WriteLine(item.ClassName + " - " + item.Average);
        // }
        // var averageMarks = students.Average(o=> o.Marks);
        // var marksBelowAverage = students.Where(o=> o.Marks < averageMarks);
        // var belowAvg = students.Where(s=> s.Marks <(students.Where(x=>x.Class == s.Class).Average(a=>a.Marks)));
        // foreach (var item in marksBelowAverage)
        // {
        //     System.Console.WriteLine(item.Marks + " - " + item.Name);
        // }

        // var orderStudents = students.OrderBy(o=> o.Class).ThenByDescending(o=> o.Marks);
        // foreach (var item in orderStudents)
        // {
        //     System.Console.WriteLine(item.Marks + " - " + item.Class);
        // }


        // 2. employee salary system


        // var employees = new List<Employee>
        // {
        //     new Employee{Id=1, Name="Ravi", Dept="IT", Salary=80000, JoinDate=new DateTime(2019,1,10)},
        //     new Employee{Id=2, Name="Anita", Dept="HR", Salary=60000, JoinDate=new DateTime(2021,3,5)},
        //     new Employee{Id=3, Name="Suresh", Dept="IT", Salary=120000, JoinDate=new DateTime(2018,7,15)},
        //     new Employee{Id=4, Name="Meena", Dept="Finance", Salary=90000, JoinDate=new DateTime(2022,9,1)}
        // };

        // var highest = employees.Max(o=> o.Salary);
        // System.Console.WriteLine(highest);
        // var lowest = employees.Min(o=> o.Salary);
        // System.Console.WriteLine(lowest);

        // var employeePerDepartMent = employees.GroupBy(o=> o.Dept).Count();
        // System.Console.WriteLine(employeePerDepartMent);

        // var joiningAfter2020 = employees.Where(o=>o.JoinDate.Year> 2020);
        // foreach (var item in joiningAfter2020)
        // {
        //     System.Console.WriteLine(item.JoinDate + " - " + item.Name);
        // }
        // var projection = employees.Select(o=> new {o.Name,o.Salary });
        // foreach (var item in projection)
        // {
        //     System.Console.WriteLine(item.Name + " - " + item.Salary);
        // }

        //4.Library Management
        // var books = new List<Book>
        // {
        //     new Book{Title="C# Basics", Author="John", Genre="Tech", Year=2018, Price=500},
        //     new Book{Title="Java Advanced", Author="Mike", Genre="Tech", Year=2016, Price=700},
        //     new Book{Title="History India", Author="Raj", Genre="History", Year=2019, Price=400},
        //     new Book{Title="golang Advanced", Author="Praj", Genre="Tech", Year=2013, Price=700},
        // };

        // var booksAfter2015 = books.Where(o=> o.Year> 2015);
        // foreach (var item in booksAfter2015)
        // {
        //     System.Console.WriteLine(item.Year + " - " + item.Author);
        // }

        // var multipleGrouping = books.GroupBy(o=>o.Genre).Count();
        // System.Console.WriteLine(multipleGrouping);

        // var mostExpensive = books.GroupBy(b => b.Genre).Select(g => g.OrderByDescending(b => b.Price).FirstOrDefault());

        // foreach (var book in mostExpensive)
        // {
        //     Console.WriteLine($"{book.Genre} - {book.Title} - {book.Price}");
        // }
        // var authors = books.Select(b => b.Author).Distinct();

        // foreach (var author in authors)
        // {
        //     Console.WriteLine(author);
        // }


        //5.customer order analysis

        // var orders = new List<Order>
        // {
        //     new Order{OrderId=1, CustomerId=1, Amount=20000},
        //     new Order{OrderId=2, CustomerId=1, Amount=40000}
        // };
        // var movies = new List<Movie>
        // {
        //     new Movie{Title="Inception", Genre="SciFi", Rating=9, Year=2010},
        //     new Movie{Title="Avatar", Genre="SciFi", Rating=8.5, Year=2009},
        //     new Movie{Title="Titanic", Genre="Drama", Rating=8, Year=1997}
        // };

        // var filteredMovies = movies.Where(o=>o.Rating>8);

        // foreach (var movie in filteredMovies)
        // {
        //    Console.WriteLine(movie.Rating + " " + movie.Genre);
        // }

        // var groupByGenre = movies.GroupBy(o=>o.Genre).Average()

        // 3.
        var products = new List<Product>
        {
            new Product{Id=1, Name="Laptop", Category="Electronics", Price=50000},
            new Product{Id=2, Name="Phone", Category="Electronics", Price=20000},
            new Product{Id=3, Name="Table", Category="Furniture", Price=5000}
        };
        var sales = new List<Sale>
        {
            new Sale{ProductId=1, Qty=10},
            new Sale{ProductId=2, Qty=20}
        };

        var joinedData = products.Join(sales, o=> o.Id, i=> i.ProductId, (p,s)=> new {p.Name, s.Qty});
        foreach (var j in joinedData)
        {
            System.Console.WriteLine($"{j.Name} - {j.Qty}");
        }
        var revenuePerProduct = products.Join(sales, o=> o.Id, i=> i.ProductId,(p, s) => new {p.Category, p.Price });
        //8.
        var cart = new List<CartItem>
        {
            new CartItem{Name="TV", Category="Electronics", Price=30000, Qty=1},
            new CartItem{Name="Sofa", Category="Furniture", Price=15000, Qty=1}
        };
        double totalCartValue = cart.Sum(item => item.Price * item.Qty);

        Console.WriteLine($"Total Cart Value: {totalCartValue}");
        var categoryTotals = cart.GroupBy(item => item.Category).Select(group => new
        {
            Category = group.Key,
            TotalCost = group.Sum(item => item.Price * item.Qty)
        });

        foreach (var item in categoryTotals)
        {
            Console.WriteLine($"{item.Category} → {item.TotalCost}");
        }
        var discountedCart = cart.Select(item => new
        {
            item.Name,
            item.Category,
            item.Qty,
            OriginalPrice = item.Price,
            FinalPrice = item.Category == "Electronics"
                            ? item.Price * 0.9
                            : item.Price
        });
        var cartSummary = cart.Select(item => new CartSummaryDTO
        {
            Name = item.Name,
            Category = item.Category,
            FinalAmount = (item.Category == "Electronics"
                            ? item.Price * 0.9
                            : item.Price) * item.Qty
        });





    }
}


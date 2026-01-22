// See https://aka.ms/new-console-template for more information
// using System;

// namespace OOPSPractice
// {
    
//     class Day15
//     {
//         public static void Main(String[] args)
//         {
//             Employee employee1 = new Employee();
//             employee1.FirstName= "Palak";
//             employee1.LastName = "Arora";
//             Console.WriteLine(employee1);
//             //employee1.Display();

//             //Object initializer
//             Employee employee2 = new Employee()
//             {
//                 FirstName = "Amit",
//                 LastName = "Chauhan",
//                 Salary = 3000

//             };
//             Console.WriteLine(employee2);
//             Employee employee3 = new Employee()
//             {
//                 FirstName = "Amit", // remaining values will be assigned by constructor 
//                 Salary = 3500
//             };
//             bool salaryGreater = employee2.IsSalaryGreater(employee3);
//             Console.WriteLine(employee3);
//             Console.WriteLine(salaryGreater);

//         }
//     }
//     class Employee
//     {
//         public Employee(){
//             FirstName = "New";
//             LastName = "Employee";
//             // Full Name cannot be assigned as it is read only 

//         }
//         public int Salary { get; set; }
//         public string FirstName { get; set; }
//         public string LastName { get; set; }

//         public string FullName { 
//             get{
//                 return $"{FirstName} {LastName}";
//             } 
//         }

//         // public void Display()
//         // {
//         //     Console.WriteLine($"{FullName}");
//         // }
//         public override string ToString()
//         {
//             return $"FirstName : {FirstName} LastName : {LastName} FullName : {FullName} Salary : {Salary}";
//         }
//         public bool IsSalaryGreater(Employee emp)
//         {
//             if(Salary > emp.Salary) //this.Salary or Salary is salary of who called the method
//             return true;
//             else
//             return false;
//         }
//     }
// }
using System;
using System.Numerics;

class Day15
{
    public static void Main(string[] args)
    {
        Height person1 = new Height(5, 6.5);
        Height person2 = new Height(6, 7.5);
        Console.WriteLine(person1);
        Console.WriteLine(person2);

        Height totalHeight = person1.AddHeights(person2);
        Console.WriteLine(totalHeight);
    }
}
class Height
{
    public int Feet { get; set; }
    public double Inches { get; set; }
    public Height()
    {
        Feet = 0;
        Inches = 0.0;
    }
    public Height(int feet, double inches)
    {
        Feet = feet;
        Inches = inches;
    }
    public Height(double inches)
    {
        Inches = inches;
    }
    public Height AddHeights(Height h2)
    {
        int totalFeet = Feet + h2.Feet;
        double totalInches = Inches + h2.Inches;
        if(totalInches >= 12)
        {
            totalFeet += (int)(totalInches/12);
            totalInches = totalInches % 12;
        }
        return new Height(totalFeet, totalInches);
    }
    public override string ToString()
    {
        return $"Height : {Feet} feet {Inches :F2} inches";
        
    }

}
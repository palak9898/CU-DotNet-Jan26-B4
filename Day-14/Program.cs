// See https://aka.ms/new-console-template for more information
using System;

namespace OOPSPractice
{
    
    class Day14
    {
        public static void Main(String[] args)
        {
            Employee emp = new Employee();
            emp.SetId(12960);
            int identityCode = emp.GetId();
            emp.Name = "Palak";
            emp.Department = "IT";
            emp.Salary =52000;
            emp.Display();
            
        }
    }
    class Employee
    {
        private int id;

        public void SetId(int id)
        {
            this.id = id;
        }
        public int GetId()
        {
            return id;
        }

        // AUTOPROPERTY
        public string Name { get; set; }

        // FULLPROPERTY
        private string department;
        public string Department
        {
            get { return department; }
            set { 
                if(value == "Accounts" || value =="IT" || value == "Sales"){
                department = value; }
            }
        }
        //FULLPROPERTY
        private int salary;
        public int Salary
        {
            get { return salary; }
            set { 
                if(value>50000 && value< 90000){
                    salary = value; }
            }
        }
        
        public void Display()
        {
            Console.WriteLine($" Name is : {Name}");
            Console.WriteLine($"Id is :{id}");
            Console.WriteLine($"Department is: {department}");
            Console.WriteLine($"Salary :{salary}");
        }
    }

}

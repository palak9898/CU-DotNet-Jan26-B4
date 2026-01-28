// See https://aka.ms/new-console-template for more information
namespace OOPSPractice
{
    class Practice
    {
        class Employee
        {
            public int EmployeeId { get; set; }
            public string EmployeeName { get; set; }
            public decimal BasicSalary { get; set; }
            public int ExperienceInYears { get; set; }

            public Employee(int employeeId, string employeeName, decimal basicSalary, int experienceInYears)
            {
                EmployeeId = employeeId;
                EmployeeName = employeeName;
                BasicSalary = basicSalary;
                ExperienceInYears = experienceInYears;
            }
            decimal annualSalary;
            public decimal CalculateAnnualSalary()
            {
                annualSalary = BasicSalary*12;
                return annualSalary;
            }
            public void DisplayEmployeeDetails()
            {
                Console.WriteLine($"Employee Id - {EmployeeId}, Employee name  - {EmployeeName}, Basic Salary - {BasicSalary} Annual Salary - {annualSalary}");
            }

        }
        class PermanentEmployee: Employee
        {
            public PermanentEmployee(int employeeId, string employeeName, decimal basicSalary, int experienceInYears)
            :base(employeeId, employeeName, basicSalary, experienceInYears)
            {
                
            }
            public new decimal CalculateAnnualSalary()
            {
                decimal rentAllowance = 0.2m * BasicSalary;
                decimal specialAllowance = 0.1m * BasicSalary;
                decimal loyalityBonus;
                if (ExperienceInYears >= 5)
                {
                    loyalityBonus = 50000;
                }
                else
                {
                    loyalityBonus = 0;
                }
                decimal annualSalary = (BasicSalary + rentAllowance + specialAllowance) + loyalityBonus;
                return annualSalary;
            }
                
        }
        class ContractEmployee: Employee
        {
            public int ContractDurationInMonths { get; set;}
            public ContractEmployee(int employeeId, string employeeName, decimal basicSalary, int experienceInYears, int months)
            :base(employeeId, employeeName, basicSalary, experienceInYears)
            {
                ContractDurationInMonths = months;
            }
            public new decimal CalculateAnnualSalary()
            {
                decimal ContractCompletionBonus= 12;
                if (ContractDurationInMonths >= 12)
                {
                    ContractCompletionBonus = 30000;
                }
                else
                {
                    ContractCompletionBonus = 0;
                }
                return BasicSalary*12 + ContractCompletionBonus;
 
            }
        }
        class InternEmployee: Employee
        {
            public InternEmployee(int employeeId, string employeeName, decimal basicSalary, int experienceInYears)
            :base(employeeId, employeeName, basicSalary, experienceInYears)
            {
                
            }
            public new decimal CalculateAnnualSalary()
            {
                return BasicSalary * 12;
            }
        }
        public static void Main(string[] args)
        {
            Employee emp1 = new PermanentEmployee(123, "Palak", 25000, 2);
            PermanentEmployee emp2 = new PermanentEmployee(123, "Palak", 25000, 2);
            
            Console.WriteLine("salary by Object of base class");
            Console.WriteLine(emp1.CalculateAnnualSalary());
            Console.WriteLine("salary by Object of derived class");
            Console.WriteLine(emp2.CalculateAnnualSalary());
        }
    }
}

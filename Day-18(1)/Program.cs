// // IS - A relationship
// namespace OOPSLearning
// {
//     class Person
//     {
//         public Person(){
//             AadharId = 0;
//             Name = string.Empty;

//         }
//          public Person(int id, string name){
//             AadharId = id;
//             Name = name;
//         }
//         public override string ToString()
//         {
//             return $"Id - {AadharId}, Name - {Name}";
//         }
//         public int AadharId { get; set; }
//         public string Name { get; set; }
//     }
//     class Student : Person
//     {
//         public Student()
//         {
//             Degree = string.Empty;
//             College = string.Empty;
//         }
//         public Student(string degree,string college )
//         {
//             Degree = degree;
//             College = college;
//         }
//         public override string ToString()
//         {
//             base.ToString();
//             return base.ToString + $"Degree - {Degree}, College - {College}, Id - {AadharId} ,Name - {Name} ";
//         }
//         public Student(int id, string name, string degree, string college)
//         :base(id,name) //base keyword for base class constructor
//         {
//             Degree = degree;
//             College = college;
//         }
//         public string College { get; set; }
//         public string Degree { get; set; }
//     }
//     internal class InheritancePractice
//     {
//         static void Main(string[] args)
//         {
//          Student s1 = new Student(
//             111,"Stud1", "BSC" , "GovtCollege"
//          );
//          Console.WriteLine(s1);   
//         }
//     }
// }
namespace OOPSLearning
{
    class Loan
    {
        public int LoanNumber { get; set; }
        public string CustomerName { get; set; }
        public int PrincipalAmount { get; set; }
        public int TenureInYears { get; set; }
        public Loan()
        {
            CustomerName = string.Empty;
            LoanNumber = 0;
            PrincipalAmount = 0;
            TenureInYears = 0;
        }
        public Loan(string customerName, int loanNumber, int principalAmount, int tenureInYears)
        {
            this.CustomerName = customerName;
            this.LoanNumber = loanNumber;
            this.PrincipalAmount = principalAmount;
            this.TenureInYears = tenureInYears;
        }
        public int CalculateEMI()
        {
            int interest = (PrincipalAmount * 10* TenureInYears)/100;
            return interest;
        }
        public void Display()
        {
            Console.WriteLine("Loan Displayed");
        }

    }
    class HomeLoan : Loan
    {
        public new int CalculateEMI()
        {
            int interest = ((PrincipalAmount * 8* TenureInYears)/100) + ((PrincipalAmount*1 * TenureInYears)/100);
            return interest;
        }
        public new void Display()
        {
            Console.WriteLine("HomeLoan Displayed");
        }
    }
    class CarLoan: Loan
    {
        public new int CalculateEMI()
        {
            PrincipalAmount = PrincipalAmount + 15000;
            int interest = ((PrincipalAmount * 9 * TenureInYears)/100) + ((PrincipalAmount * 1 * TenureInYears)/100);
            return interest;
        }
        public new void Display()
        {
            Console.WriteLine("CarLoan Displayed");
        }
    }
    internal class InheritancePractice
    {
        static void Main(string[] args)
        {
         Loan l1 = new Loan()
        {
            CustomerName = "palak",
            LoanNumber = 1,
            PrincipalAmount = 100,
            TenureInYears = 2
        };
         
         Loan[] loan1 = new Loan[4]
         {
            new HomeLoan(),
            new HomeLoan(),
            new CarLoan(),  // anonymous object with no name 
            new CarLoan()
         };
         

         for(int i = 0; i < 4; i++)
            {
                loan1[i].Display();
            }

         
        }
    }
}
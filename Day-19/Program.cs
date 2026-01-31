// since display of base class is always called so we create virtual method 
// namespace OOPSLearning
// // 
// {
//     abstract class Loan
//     {
//         public int LoanNumber { get; set; }
//         public string CustomerName { get; set; }
//         public int PrincipalAmount { get; set; }
//         public int TenureInYears { get; set; }
//         public Loan()
//         {
//             CustomerName = string.Empty;
//             LoanNumber = 0;
//             PrincipalAmount = 0;
//             TenureInYears = 0;
//         }
//         public Loan(string customerName, int loanNumber, int principalAmount, int tenureInYears)
//         {
//             this.CustomerName = customerName;
//             this.LoanNumber = loanNumber;
//             this.PrincipalAmount = principalAmount;
//             this.TenureInYears = tenureInYears;
//         }
//         public int CalculateEMI()
//         {
//             int interest = (PrincipalAmount * 10* TenureInYears)/100;
//             return interest;
//         }
//         public virtual void Display()
//         {
//             Console.WriteLine("Loan Displayed");
//         }
//         public abstract void AbstractMethod();

//     }
//     class HomeLoan : Loan
//     {
//         public new int CalculateEMI()
//         {
//             int interest = ((PrincipalAmount * 8* TenureInYears)/100) + ((PrincipalAmount*1 * TenureInYears)/100);
//             return interest;
//         }
//         public override void Display()
//         {
//             Console.WriteLine("HomeLoan Displayed");
//         }
//         public override void AbstractMethod()
//         {
//             Console.WriteLine("Abstract method in Homeloan ");
//         }
//     }
//     class CarLoan: Loan
//     {
//         public new int CalculateEMI()
//         {
//             PrincipalAmount = PrincipalAmount + 15000;
//             int interest = ((PrincipalAmount * 9 * TenureInYears)/100) + ((PrincipalAmount * 1 * TenureInYears)/100);
//             return interest;
//         }
//         public override void Display()
//         {
//             Console.WriteLine("CarLoan Displayed");
//         }
//          public override void AbstractMethod()
//         {
//             Console.WriteLine("Abstract method in Carloan ");
//         }
//     }
//     internal class InheritancePractice
//     {
//         static void Main(string[] args)
//         {
//         //  Loan l1 = new Loan()
//         // {
//         //     CustomerName = "palak",
//         //     LoanNumber = 1,
//         //     PrincipalAmount = 100,
//         //     TenureInYears = 2
//         // };
         
//          Loan[] loan1 = new Loan[4]
//          {
//             new HomeLoan(),
//             new HomeLoan(),
//             new CarLoan(),  // anonymous object with no name 
//             new CarLoan()
//          };
         

//          for(int i = 0; i < 4; i++)
//             {
//                 loan1[i].Display();
//                 loan1[i].AbstractMethod();
//             }
         
//         }
//     }

// class DoPayment
//     {
        
//     }
//     internal interface IProcessPayment
//     {
//         void ProcessPayment();
//     }
//     internal interface IConfirmPayment
//     {
//         void ConfirmPayment();
//     }
//     class Payments: DoPayment, IProcessPayment, IConfirmPayment
//     {
//         public void ConfirmPayment()
//         {
//             Console.WriteLine("Confirm Payment method");
//         }
//         public void ProcessPayment()
//         {
//             Console.WriteLine("Process Payment method");
//         }
//     }

// }



class Loan
{
    public string ClientName { get; set; }
    public double Principal { get; set; }
    public double InterestRate { get; set; }

    public Loan(string clientName, double principal, double interestRate){
        ClientName = clientName;
        Principal = principal;
        InterestRate = interestRate;
    }
    public override string ToString()
    {
        return $"{ClientName},{Principal},{InterestRate}";
    }
    string RiskLevel= "";
    public string CalculateRiskLevel()
    {
        if(InterestRate> 10 )
        {
            RiskLevel = "HIGH";
        }
        else if(InterestRate>= 5 && InterestRate <= 10 )
        {
            RiskLevel = "MEDIUM";
        }
        else if(InterestRate < 5)
        {
            RiskLevel = "LOW";
        }
        return RiskLevel;
    }
    public double CalculateInterestAmount()
    {
        return (Principal * InterestRate)/100;
    }
}
class Day27
{
    static void Main(string[] args)
    {
        Loan l1 = new Loan("Palak",340000,5.9);
        Loan l2 = new Loan("kiyt",670000,3.2);
        Loan l3 = new Loan("Boby",15000,15);
        
        string file ="textFile.txt";
        if (!File.Exists(file))
        {
            System.Console.WriteLine("File does not exists");
            return;
        }

        List<Loan> listOfLoans = new List<Loan>();
        listOfLoans.Add(l1);
        listOfLoans.Add(l2);
        listOfLoans.Add(l3);

        using (StreamWriter sw = new StreamWriter(file,true))
        {
            foreach (var loan in listOfLoans)
            {
            sw.WriteLine(loan);
            }
        }

        using (StreamReader sr = new StreamReader(file)){
            Console.WriteLine("Client".PadRight(10) + "Principal".PadRight(15) + "Interest".PadRight(10) + "Risk Level");
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] data = line.Split(',');
                if (data.Length != 3)
                    continue;
                //loan.ClientName = data[0];
                double principal =0;
                double interestRate=0;
                bool isValidPrincipal = double.TryParse(data[1], out principal);
                bool isValidInterestRate = double.TryParse(data[2],out interestRate);
                if(!isValidInterestRate || !isValidPrincipal)
                {
                    System.Console.WriteLine("Tryingt o parse wrong value");
                    continue;
                }
                Loan loan = new Loan(data[0],principal,interestRate);
                //System.Console.WriteLine("Client".PadLeft(14) + "Principal".PadLeft(4)+ "Interest".PadRight(5)+ "Risk Level".PadRight(15));
                Console.WriteLine($"{loan.ClientName} | {loan.Principal:C} | {loan.CalculateInterestAmount():C} | {loan.CalculateRiskLevel()}");
            }
        }
        //File.WriteAllText(file, "");
    }
}
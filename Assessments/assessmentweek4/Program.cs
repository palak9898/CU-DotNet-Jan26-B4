// See https://aka.ms/new-console-template for more information
class A
{
    public class Patient
    {
        public string Name { get; set; }
        public decimal BaseFee { get; set; }
        public virtual decimal CalculateFinalBill()
        {
            return BaseFee;
        }
        public Patient(string name, decimal basefee)
        {
            Name = name;
            BaseFee =basefee;
        }
    }
    public class Inpatient: Patient
    {
        public int DayStayed { get; set; }
        public decimal DailyRate { get; set; }

        public Inpatient(int dayStayed, decimal dailyRate ,string name, decimal basefee)
        :base(name, basefee)
        {
            DayStayed = dayStayed;
            DailyRate = dailyRate;
        }

        public override decimal CalculateFinalBill()
        {
            decimal total = BaseFee + (DayStayed * DailyRate);
            return total;
        }
    }
    class Outpatient : Patient
    {
        public decimal Procedurefee { get; set; }
        public Outpatient(decimal procedurefee, string name, decimal baseFee)
        :base(name, baseFee)
        {
            Procedurefee = procedurefee;
        }
        public override decimal CalculateFinalBill()
        {
            decimal total = BaseFee + Procedurefee;
            return total;
        }
    }
    class EmergencyPatient: Patient
    {
        public int SeverityLevel { get; set; }
        public EmergencyPatient(int severityLevel, string name ,decimal basefee)
        :base(name , basefee)
        {
            SeverityLevel = severityLevel;
        }
        public override decimal CalculateFinalBill()
        {
            decimal total = BaseFee * SeverityLevel;
            return total;
        }
    }
    class HospitalBilling
    {
        List<Patient> patients {get; set;} =  new List<Patient>();

        public void AddPatient(Patient p)
        {
            patients.Add(p);
        }
        public void GenerateDailyReport()
        {
            foreach(var p in patients)
            {
                Console.WriteLine($"Patient Name : {p.Name}");
                Console.WriteLine(p.CalculateFinalBill().ToString("C2"));
            }
        }
        public decimal CalculateTotalRevenue()
        {
            decimal total =0;
            foreach(var t in patients)
            {
                total += t.CalculateFinalBill();
            }
            return total;
        }
        public int GetInpatientCount()
        {
            int count =0;
            foreach(var c in patients)
            {
                if(c is Inpatient)
                {
                    count++;
                }
            }
            return count;
        }

    }
    static void Main(string[] args)
    {
        
        Patient p1 = new Patient("Palak", 1000);
        Patient p2 = new Patient("Vishu", 500);
        Patient p3 = new Inpatient(2, 3500m, "Rahul", 800);
        Patient p4 = new Outpatient(500, "Hitik", 300);
        Patient p5 = new EmergencyPatient(2, "Nikita", 200);

        HospitalBilling hospitalBilling = new HospitalBilling();
        hospitalBilling.AddPatient(p1);
        hospitalBilling.AddPatient(p2);
        hospitalBilling.AddPatient(p3);
        hospitalBilling.AddPatient(p4);
        hospitalBilling.AddPatient(p5);

        hospitalBilling.GenerateDailyReport();
        Console.WriteLine("Total Cost is : "+hospitalBilling.CalculateTotalRevenue());
        Console.WriteLine("Inpatient count is : " + hospitalBilling.GetInpatientCount());
    }
}

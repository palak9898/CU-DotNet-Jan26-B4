// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata;

abstract class UtilityBill
{
    protected UtilityBill(int consumerId, string consumerName, decimal unitsConsumed, decimal ratePerUnit){
        ConsumerId = consumerId;
        ConsumerName = consumerName;
        UnitsConsumed = unitsConsumed;
        RatePerUnit = ratePerUnit;
    }
    public int ConsumerId { get; set; }
    public string ConsumerName { get; set; }
    public decimal UnitsConsumed { get; set; }
    public decimal RatePerUnit { get; set; }

    public abstract decimal CalculateBillAmount();
    public virtual decimal CalculateTax(decimal billAmount)
    {
        return billAmount* 0.05m;
    }
    public void PrintBill()
    {
        decimal amount =  CalculateBillAmount();
        decimal tax = CalculateTax(amount);
        Console.WriteLine($"Consumer Details : {ConsumerId} , {ConsumerName} \n "+ $"Final Payable amount: {amount+tax}");

    }
    class ElectricityBill : UtilityBill
    {
        public ElectricityBill(int consumerId,string consumerName ,decimal ratePerUnit,decimal unitsConsumed): base(consumerId, consumerName,unitsConsumed, ratePerUnit){
            
        }
        public override decimal CalculateBillAmount()
        {
            decimal billAmount = UnitsConsumed * RatePerUnit;
            if(UnitsConsumed > 300)
            {    
                billAmount += 0.1m * billAmount;
            }
            return billAmount;

        }
    }
    class WaterBill: UtilityBill
    {
        public WaterBill(int consumerId,string consumerName ,decimal ratePerUnit, decimal unitsConsumed): base(consumerId, consumerName,unitsConsumed, ratePerUnit){
            
        }
        public override decimal CalculateBillAmount()
        {
            return UnitsConsumed* RatePerUnit;
        }
        public override decimal CalculateTax(decimal billAmount)
        {
            return billAmount*0.02m;
        }
    }
    class GasBill: UtilityBill
    {
        public GasBill(int consumerId,string consumerName ,decimal ratePerUnit,decimal unitsConsumed): base(consumerId, consumerName,unitsConsumed, ratePerUnit){
            
        }
        
        public override decimal CalculateBillAmount()
        {
            return RatePerUnit* UnitsConsumed + 150;
        }
        public override decimal CalculateTax(decimal billAmount)
        {
            return 0;
        }
    }
    public static void Main(string[] args)
    {
        List <UtilityBill> li = new List<UtilityBill>
        {
            new ElectricityBill(123,"Palak",360,1),
            new WaterBill(2,"Amit",120,2),
            new GasBill(3,"Riya",90,3)
        };
        foreach(var item in li)
        {
            item.PrintBill();
        }

    }

}

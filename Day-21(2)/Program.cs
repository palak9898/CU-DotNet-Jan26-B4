class DictionaryPractice
{
    class Policy
    {
        public string HolderName { get; set; }
        public decimal Premium { get; set; }
        public int RiskScore { get; set; }
        public DateTime RenewalDate { get; set; }
    }
    class PolicyHandler
    {
        Dictionary<int,Policy> policyData = new Dictionary<int, Policy>();
        public void BulkAdjustment(Policy pobj)
        {
            
        }
    }
    static void Main(string[] args)
    {
        
    }
}

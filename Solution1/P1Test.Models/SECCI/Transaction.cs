namespace P1Test.Models.SECCI
{
    public class Transaction
    {
        public string TransactionId { get; set; }
        public string TransactionCode { get; set; }
        public string Narrative { get; set; }
        public DateTime PostDate { get; set; }
        public DateTime ValueDate { get; set; }
        public double Amount { get; set; }
    }
}

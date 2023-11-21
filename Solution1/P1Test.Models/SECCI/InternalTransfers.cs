namespace P1Test.Models.SECCI
{
    public class InternalTransfers
    {
        public List<Transaction> TransactionsIn { get; set; }
        public List<Transaction> TransactionsOut { get; set; }
        public double TotalIn { get; set; }
        public double TotalOut { get; set; }
    }
}

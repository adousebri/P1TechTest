namespace P1Test.Models.SECCI
{
    public class Transfers
    {
        public List<Transaction> TransactionsIn { get; set; }
        public List<Transaction> TransactionsOut { get; set; }
        public int TotalIn { get; set; }
        public int TotalOut { get; set; }
    }
}

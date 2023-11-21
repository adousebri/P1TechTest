namespace P1Test.Models.SECCI
{
    public class Performance
    {
        public List<Transaction> TransactionsRealised { get; set; }
        public List<PositionsRetained> PositionsRetained { get; set; }
        public int TotalRealised { get; set; }
        public int TotalRetained { get; set; }
    }

}

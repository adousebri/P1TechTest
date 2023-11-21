namespace P1Test.Models.SECCI
{
    public class SummaryData
    {
        public string FirmId { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Language { get; set; }
        public string Currency { get; set; }
        public List<string> NodeId { get; set; }
        public List<string> NodeName { get; set; }
        public string Status { get; set; }
        public string ClientType { get; set; }
        public List<Position> Positions { get; set; }
        public List<Transaction> CompleteTransactions { get; set; }
        public List<Account> Accounts { get; set; }
        public double BookValue { get; set; }
        public double NonTransferBookValue { get; set; }
        public int TransferBookValue { get; set; }
        public int OpeningValue { get; set; }
        public double CurrentValue { get; set; }
        public double UninvestedCash { get; set; }
        public double ClosingCashValue { get; set; }
        public double Growth { get; set; }
        public double GrowthPercent { get; set; }
        public double AdjustedGrowth { get; set; }
        public double AdjustedGrowthPercent { get; set; }
        public int TransferValue { get; set; }
        public int UncrystallisedValue { get; set; }
        public List<Product> Products { get; set; }
    }
}

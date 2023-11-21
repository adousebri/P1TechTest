namespace P1Test.Models.SECCI
{
    public class Account
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string AccountType { get; set; }
        public string Currency { get; set; }
        public string WrapperType { get; set; }
        public string NodeId { get; set; }
        public string Status { get; set; }
        public bool RecurringPayment { get; set; }
        public WrapperDetail WrapperDetail { get; set; }
        public double CurrentValue { get; set; }
        public int OpeningValue { get; set; }
        public int OpeningStockValue { get; set; }
        public int OpeningCashValue { get; set; }
        public double BookValue { get; set; }
        public int TransferBookValue { get; set; }
        public double NonTransferBookValue { get; set; }
        public double Growth { get; set; }
        public double AdjustedGrowth { get; set; }
        public double AlosingCashValue { get; set; }
        public double UninvestedCash { get; set; }
        public double ClosingStockValue { get; set; }
        public double GrowthPercent { get; set; }
        public double AdjustedGrowthPercent { get; set; }
        public int TransferValue { get; set; }
        public double Allocation { get; set; }
        public string AssetAllocationId { get; set; }
        public string AssetAllocationName { get; set; }
        public string NodeName { get; set; }
        public List<PortfolioGroup> PortfolioGroups { get; set; }
    }

}

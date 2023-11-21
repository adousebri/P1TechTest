namespace P1Test.Models.SECCI
{
    public class Position
    {
        public string PositionType { get; set; }
        public string Currency { get; set; }
        public double CurrentValue { get; set; }
        public int OpeningValue { get; set; }
        public double Growth { get; set; }
        public double GrowthPercent { get; set; }
        public double AdjustedGrowth { get; set; }
        public double AdjustedGrowthPercent { get; set; }
        public double Allocation { get; set; }
        public string Isin { get; set; }
        public string AssetId { get; set; }
        public string AssetName { get; set; }
        public double? Quantity { get; set; }
        public double? BookValue { get; set; }
        public int? TransferBookValue { get; set; }
        public double? NonTransferBookValue { get; set; }
        public double? CurrentPrice { get; set; }
        public DateTime? CurrentPriceDate { get; set; }
        public double? MinimumTransferUnit { get; set; }
    }
}

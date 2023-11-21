namespace P1Test.Models.SECCI
{
    public class PositionsRetained
    {
        public string Isin { get; set; }
        public string AssetName { get; set; }
        public double Quantity { get; set; }
        public double BookValue { get; set; }
        public int TransferBookValue { get; set; }
        public double NonTransferBookValue { get; set; }
        public double CurrentValue { get; set; }
        public int Growth { get; set; }
        public int AdjustedGrowth { get; set; }
    }
}

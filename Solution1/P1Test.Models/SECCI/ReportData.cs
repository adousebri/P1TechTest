namespace P1Test.Models.SECCI
{
    public class ReportData
    {
        public string Id { get; set; }
        public string Nme { get; set; }
        public string FirmId { get; set; }
        public string Currency { get; set; }
        public Payments Payments { get; set; }
        public Charges Charges { get; set; }
        public Income Income { get; set; }
        public Transfers Transfers { get; set; }
        public InternalTransfers InternalTransfers { get; set; }
        public Performance Performance { get; set; }
        public int OpeningValue { get; set; }
        public double ClosingValue { get; set; }
    }
}

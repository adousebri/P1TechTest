namespace P1Test.Models.SECCI
{
    public class ListPortFoliosData
    {
        public string Id { get; set; }
        public string FirmId { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public List<string> NodeId { get; set; }
        public List<string> NodeName { get; set; }
        public string Currency { get; set; }
        public double CurrentValue { get; set; }
        public int Accounts { get; set; }
        public double UninvestedCash { get; set; }
        public double Growth { get; set; }
        public double GrowthPercent { get; set; }
        public double AdjustedGrowth { get; set; }
        public double AdjustedGrowthPercent { get; set; }
    }
}

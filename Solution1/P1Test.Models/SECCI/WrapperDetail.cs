namespace P1Test.Models.SECCI
{
    public class WrapperDetail
    {
        public string WrapperType { get; set; }
        public bool Discretionary { get; set; }
        public bool Advised { get; set; }
        public bool Trust { get; set; }
        public string ClientProductId { get; set; }
        public string SchemeProductId { get; set; }
        public string ProductStatus { get; set; }
        public string AssetAllocationId { get; set; }
        public string AssetAllocationName { get; set; }
        public ProductDetail ProductDetail { get; set; }
    }
}

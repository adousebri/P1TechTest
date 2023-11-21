namespace P1Test.API.SECCI.Requests
{
    using MediatR;
    using P1Test.Models.FrontEnd;

    public class GetPortfolioSummaryRequest : IRequest<PortfolioSummaryModel>
    {
        public string FirmId { get; set; }

        public string Id { get; set; }
    }
}

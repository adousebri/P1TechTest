namespace P1Test.API.SECCI.Handlers
{
    using MediatR;
    using P1Test.API.SECCI.Extensions;
    using P1Test.API.SECCI.Requests;
    using P1Test.Interfaces.API;
    using P1Test.Models.FrontEnd;

    public class GetPortfolioSummaryHandler : IRequestHandler<GetPortfolioSummaryRequest, PortfolioSummaryModel>
    {
        private readonly IPortfolioDataAPI _portfolioDataAPI;

        public GetPortfolioSummaryHandler(IPortfolioDataAPI portfolioDataAPI)
        {
            _portfolioDataAPI = portfolioDataAPI;
        }

        public async Task<PortfolioSummaryModel> Handle(GetPortfolioSummaryRequest request, CancellationToken cancellationToken)
        {
            var portFolios = await _portfolioDataAPI.GetPortfolioSummary(request.FirmId, request.Id);

            return new PortfolioSummaryModel()
            {

            };
        }
    }
}

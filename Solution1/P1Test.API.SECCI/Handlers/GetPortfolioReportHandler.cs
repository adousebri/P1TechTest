namespace P1Test.API.SECCI.Handlers
{
    using MediatR;
    using P1Test.API.SECCI.Extensions;
    using P1Test.API.SECCI.Requests;
    using P1Test.Interfaces.API;
    using P1Test.Models.FrontEnd;

    public class GetPortfolioReportHandler : IRequestHandler<GetPortfolioReportRequest, PortfolioReportModel>
    {
        private readonly IPortfolioDataAPI _portfolioDataAPI;

        public GetPortfolioReportHandler(IPortfolioDataAPI portfolioDataAPI)
        {
            _portfolioDataAPI = portfolioDataAPI;
        }

        public async Task<PortfolioReportModel> Handle(GetPortfolioReportRequest request, CancellationToken cancellationToken)
        {
            var portFolios = await _portfolioDataAPI.GetPortfolioReport(
                request.FirmId,
                request.FromDate.HasValue ? request.FromDate.Value : DateTime.Today.StartOfToday(),
                request.ToDate.HasValue ? request.FromDate.Value : DateTime.Today.EndOfToday());

            return new PortfolioReportModel()
            {
                
            };
        }
    }
}

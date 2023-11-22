namespace P1Test.MiddleWare.Services
{
    using MediatR;
    using P1Test.API.SECCI.Requests;
    using P1Test.Interfaces.API;
    using P1Test.Interfaces.Services;
    using P1Test.Models.FrontEnd;

    public class P1MiddleWare : IMiddleWareService
    {
        private readonly IMediator _mediator;

        public P1MiddleWare(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<FirmSummary> FirmSummary()
        {
            var portfolois = await _mediator.Send(new GetListPortFoliosRequest());
            //var portFolioReport = await _mediator.Send(new GetPortfolioReportRequest());
            //var portFolioSummary = await _mediator.Send(new GetPortfolioSummaryRequest());

            return new FirmSummary()
            {
                FirmId = portfolois.PortFolios.First().FirmId,
                ClientType = portfolois.PortFolios.First().ClientType,
                Currency = portfolois.PortFolios.First().Currency,
                Name = portfolois.PortFolios.First().Name,
                Status = portfolois.PortFolios.First().Status
            };
        }
    }
}

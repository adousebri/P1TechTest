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

        public FirmSummary FirmSummary()
        {
            var portfolois = _mediator.Send(new GetListPortFoliosRequest());
            var portFolioReport = _mediator.Send(new GetPortfolioReportRequest());
            var portFolioSummary = _mediator.Send(new GetPortfolioSummaryRequest());

            return new FirmSummary();
        }
    }
}

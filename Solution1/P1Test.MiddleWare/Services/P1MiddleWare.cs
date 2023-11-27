namespace P1Test.MiddleWare.Services
{
    using MediatR;
    using P1Test.API.SECCI.Requests;
    using P1Test.Interfaces.Services;
    using P1Test.Models.FrontEnd;
    using System.Collections.Generic;

    public class P1MiddleWare : IMiddleWareService
    {
        private readonly IMediator _mediator;

        public P1MiddleWare(IMediator mediator)
        {
            _mediator = mediator;
        } 

        public async Task<PortFolioCollection> FirmSummary()
        {
            return await _mediator.Send(new GetListPortFoliosRequest() { FirmId = "Firm1" });
            //var portFolioReport = await _mediator.Send(new GetPortfolioReportRequest());
            //var portFolioSummary = await _mediator.Send(new GetPortfolioSummaryRequest());
        }
    }
}

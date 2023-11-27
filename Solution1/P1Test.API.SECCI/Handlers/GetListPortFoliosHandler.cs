namespace P1Test.API.SECCI.Handlers
{
    using MediatR;
    using P1Test.API.SECCI.Requests;
    using P1Test.Interfaces.API;
    using P1Test.Models.FrontEnd;
    using System.Threading;
    using System.Threading.Tasks;

    public class GetListPortFoliosHandler : IRequestHandler<GetListPortFoliosRequest, PortFolioCollection>
    {

        private readonly IPortfolioDataAPI _portfolioDataAPI;

        public GetListPortFoliosHandler(IPortfolioDataAPI portfolioDataAPI)
        {
            _portfolioDataAPI = portfolioDataAPI;
        }

        public async Task<PortFolioCollection> Handle(GetListPortFoliosRequest request, CancellationToken cancellationToken)
        {
            var portFolios = await _portfolioDataAPI.GetListPortFolios(request.FirmId);

            return new PortFolioCollection()
            {
                PortFolios = portFolios.Select(r => new PortFolioModel()
                {
                    Id = r.Id,
                    FirmId = r.FirmId,
                    Name = r.Name,
                    Status = r.Status,
                    Currency = r.Currency,
                    FirstName = r.Name
                })
            };
        }
    }
}

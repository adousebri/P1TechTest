namespace P1Test.API.SECCI.Requests
{
    using MediatR;
    using P1Test.Models.FrontEnd;

    public class GetListPortFoliosRequest : IRequest<PortFolioCollection>
    {
        public string FirmId { get; set; }
    }
}

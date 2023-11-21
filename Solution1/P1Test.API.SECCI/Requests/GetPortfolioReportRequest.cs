namespace P1Test.API.SECCI.Requests
{
    using MediatR;
    using P1Test.Models.FrontEnd;

    public class GetPortfolioReportRequest : IRequest<PortfolioReportModel>
    {
        public string FirmId { get; set; }

        public DateTime? FromDate { get; set; }

        public DateTime? ToDate { get; set; }


    }
}

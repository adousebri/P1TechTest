namespace P1Test.Interfaces.API
{
    using P1Test.Models.SECCI;
    using System.Collections.Generic;

    public interface IPortfolioDataAPI
    {
        Task<AuthenticationData> Authenticate(string firmId, string id, string password);

        Task<IEnumerable<ListPortFoliosData>> GetListPortFolios(string firmId);

        Task<SummaryData> GetPortfolioSummary(string firmId, string id);

        Task<ReportData> GetPortfolioReport(string firmId, DateTime fromDate, DateTime toDate);
    }
}

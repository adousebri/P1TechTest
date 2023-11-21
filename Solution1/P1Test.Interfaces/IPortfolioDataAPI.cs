namespace P1Test.Interfaces
{
    using P1Test.Models.SECCI;
    using System.Collections.Generic;

    public interface IPortfolioDataAPI
    {
        AuthenticationData Authenticate(string firmId, string id, string password);

        IEnumerable<ListPortFoliosData> GetListPortFolios();

        SummaryData GetPortfolioSummary(string id);

        ReportData GetPortfolioReport(string id);
    }
}

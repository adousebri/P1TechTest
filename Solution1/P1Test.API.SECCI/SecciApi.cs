namespace P1Test.API.SECCI
{
    using P1Test.Interfaces;
    using P1Test.Models.SECCI;
    using System.Collections.Generic;

    public class SecciApi : IPortfolioDataAPI
    {
        public AuthenticationData Authenticate(string firmId, string id, string password)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ListPortFoliosData> GetListPortFolios()
        {
            throw new NotImplementedException();
        }

        public ReportData GetPortfolioReport(string id)
        {
            throw new NotImplementedException();
        }

        public SummaryData GetPortfolioSummary(string id)
        {
            throw new NotImplementedException();
        }
    }
}

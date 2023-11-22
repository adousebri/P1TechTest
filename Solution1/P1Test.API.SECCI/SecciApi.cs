namespace P1Test.API.SECCI
{
    using P1Test.Interfaces.API;
    using P1Test.Models.SECCI;
    using RestSharp;
    using System.Collections.Generic;

    public class SecciApi : IPortfolioDataAPI
    {
        private readonly ISecciClient _secciClient;

        public SecciApi(ISecciClient restClient)
        {
            _secciClient = restClient;
        }

        public async Task<AuthenticationData> Authenticate(string firmId, string id, string password)
        {            
            var request = new RestRequest("/authenticate", Method.Post);
            request.AddHeader("Content-Type", "application/json");
            request.AlwaysMultipartFormData = true;
            request.AddParameter("firmId", "{{firmId}}");
            request.AddParameter("id", "{{userId}}");
            request.AddParameter("password", "{{userPassword}}");
            RestResponse<Root<AuthenticationData>> response = await _secciClient.Client.ExecuteAsync<Root<AuthenticationData>>(request);
            return response.Data.Data;
        }

        public async Task<IEnumerable<ListPortFoliosData>> GetListPortFolios(string firmId)
        {
            var request = new RestRequest("/portfolio/", Method.Get);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("api-token", "");
            request.AddUrlSegment("firmId", firmId);
            RestResponse<Root<List<ListPortFoliosData>>> response = await _secciClient.Client.ExecuteAsync<Root<List<ListPortFoliosData>>>(request);
            return response.Data.Data;
        }

        public async Task<ReportData> GetPortfolioReport(string firmId, DateTime fromDate, DateTime toDate)
        {
            var request = new RestRequest("/portfolio/report/", Method.Get);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("api-token", "");
            request.AddUrlSegment("firmId", firmId);
            request.AddQueryParameter("type", "Report");
            request.AddQueryParameter("fromdate", fromDate);
            request.AddQueryParameter("toDate", toDate);
            RestResponse<Root<ReportData>> response = await _secciClient.Client.ExecuteAsync<Root<ReportData>>(request);
            return response.Data.Data;
        }

        public async Task<SummaryData> GetPortfolioSummary(string firmId, string id)
        {
            var request = new RestRequest("/portfolio/summary", Method.Get);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("api-token", "");
            request.AddUrlSegment("firmId", firmId);
            request.AddUrlSegment("id", id);
            RestResponse<Root<SummaryData>> response = await _secciClient.Client.ExecuteAsync<Root<SummaryData>>(request);
            return response.Data.Data;
        }
    }
}

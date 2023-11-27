namespace P1Test.API.SECCI
{
    using Microsoft.Extensions.Configuration;
    using P1Test.Interfaces.API;
    using RestSharp;

    public class SecciClient : ISecciClient
    {
        public IRestClient Client { get; }

        public SecciClient(IConfiguration configuration)
        {
            Client = new RestClient(configuration["SecciApi:BaseUrl"]);
        }
    }
}

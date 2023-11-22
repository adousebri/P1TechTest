using RestSharp;

namespace P1Test.Interfaces.API
{
    public interface ISecciClient
    {
        IRestClient Client { get; }
    }
}

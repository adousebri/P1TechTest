using P1Test.Models.SECCI;
using RestSharp;
using RestSharp.Authenticators;

namespace P1Test.API.SECCI.Authenticators
{
    public class SecciAuth : IAuthenticator
    {
        public async ValueTask Authenticate(IRestClient client, RestRequest request)
        {
            var authRequest = new RestRequest("/authenticate", Method.Post);
            authRequest.AddHeader("Content-Type", "application/json");
            authRequest.AlwaysMultipartFormData = true;
            authRequest.AddParameter("firmId", "{{firmId}}");
            authRequest.AddParameter("id", "{{userId}}");
            authRequest.AddParameter("password", "{{userPassword}}");
            RestResponse<Root<AuthenticationData>> response = await client.ExecuteAsync<Root<AuthenticationData>>(authRequest);

            request.AddHeader("api-token", response.Data.Data.Token);
        }
    }
}

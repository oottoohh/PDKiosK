using IdentityModel.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PDJaya.WebApp.Helper
{
    public class HelperClientHttp
    {
        public async Task<HttpClient> InitialAsync()
        {
            var Disclient = new DiscoveryClient("http://pdjayaauthapi.azurewebsites.net/");
            Disclient.Policy.RequireHttps = false;
            var disco = await Disclient.GetAsync();
            var tokenClient = new TokenClient(disco.TokenEndpoint, "serviceapp", "4515647407");
            var tokenResponse = await tokenClient.RequestClientCredentialsAsync("transactionapi");
            var Client = new HttpClient();
            Client.SetBearerToken(tokenResponse.AccessToken);
            Client.BaseAddress = new Uri("http://pdjayaservice.azurewebsites.net");
            return Client;
        }
    }
    
}

using RestSharp;

namespace Rest.Advanced.Demo.Services
{
    public abstract class BaseService
    {
        private const string BaseUrl = "https://petstore.swagger.io/v2";
        protected RestClient RestClient
        {
            // TODO implement singleton for rest client
            get
            {
                var restClient = new RestClient(BaseUrl);
                return restClient;
            }
        }
    }
}

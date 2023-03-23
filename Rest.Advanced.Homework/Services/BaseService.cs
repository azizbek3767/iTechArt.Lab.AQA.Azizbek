using RestSharp;

namespace Rest.Advanced.Homework.Services
{
    public abstract class BaseService
    {
        private const string BaseUrl = "https://automationintesting.online";
        protected RestClient RestClient
        {
            get
            {
                var restClient = new RestClient(BaseUrl);
                return restClient;
            }
        }
    }
}

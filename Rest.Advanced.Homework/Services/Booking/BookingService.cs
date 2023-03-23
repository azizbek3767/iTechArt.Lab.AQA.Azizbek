using Bogus.Bson;
using Newtonsoft.Json;
using Rest.Advanced.Demo.Models.Request;
using Rest.Advanced.Homework.Models.Request;
using RestSharp;

namespace Rest.Advanced.Homework.Services.Booking
{
    public class BookingService : BaseService
    {
        private const string BookingResource = "/booking/";
        private const string CheckHealthResource = "/auth/actuator/health";
        private const string LoginResource = "/auth/login";
        private const string ValidateResource = "/auth/validate";
        private const string LogoutResource = "/auth/logout";
        /*public RestResponse<TViewModel> CreateUser<TViewModel>(UserRequestModel userRequestModel)
        {
            var request = new RestRequest(UserResource, Method.Post);
            request.AddParameter(ContentType.Json, userRequestModel, ParameterType.RequestBody);

            var response = RestClient.Execute<TViewModel>(request);

            return response;
        }*/

        public async Task<RestResponse<TViewModel>> CreateBooking<TViewModel>(BookingRequestModel bookingRequestModel)
        {
            var request = new RestRequest(BookingResource, Method.Post);
            var json = JsonConvert.SerializeObject(bookingRequestModel);
            request.AddParameter(ContentType.Json, json, ParameterType.RequestBody);

            var response = await RestClient.ExecuteAsync<TViewModel>(request);

            return response;
        }

        public async Task<RestResponse<TViewModel>> GetBooking<TViewModel>(int id)
        {
            var request = new RestRequest($"/booking/{id}", Method.Get);

            var response = await RestClient.ExecuteAsync<TViewModel>(request);

            return response;
        }

        public async Task<RestResponse> CheckHealth()
        {
            var request = new RestRequest(CheckHealthResource, Method.Get);

            var response = await RestClient.ExecuteAsync(request);

            return response;
        }

        public async Task<RestResponse> Login()
        {
            var body = "{\r\n  \"username\": \"admin\",\r\n  \"password\": \"password\"\r\n}";
            var request = new RestRequest(LoginResource, Method.Post);
            request.AddParameter(ContentType.Json, body, ParameterType.RequestBody);
            var response = await RestClient.ExecuteAsync(request);

            return response;
        }

        public async Task<RestResponse> Validate()
        {
            var body = "{\r\n  \"token\": \"abc123\"\r\n}";
            var request = new RestRequest(ValidateResource, Method.Post);
            request.AddParameter(ContentType.Json, body, ParameterType.RequestBody);
            var response = await RestClient.ExecuteAsync(request);

            return response;
        }

        public async Task<RestResponse> Logout()
        {
            var body = "{\r\n  \"token\": \"abc123\"\r\n}";
            var request = new RestRequest(LogoutResource, Method.Post);
            request.AddParameter(ContentType.Json, body, ParameterType.RequestBody);
            var response = await RestClient.ExecuteAsync(request);

            return response;
        }
    }
}

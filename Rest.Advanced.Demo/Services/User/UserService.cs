using Rest.Advanced.Demo.Models.Request;
using Rest.Advanced.Demo.Models.View;
using RestSharp;

namespace Rest.Advanced.Demo.Services.User
{
    public class UserService : BaseService
    {
        private const string UserResource = "/user";
        /*public RestResponse<TViewModel> CreateUser<TViewModel>(UserRequestModel userRequestModel)
        {
            var request = new RestRequest(UserResource, Method.Post);
            request.AddParameter(ContentType.Json, userRequestModel, ParameterType.RequestBody);

            var response = RestClient.Execute<TViewModel>(request);

            return response;
        }*/

        public async Task<RestResponse<TViewModel>> CreateUser<TViewModel>(UserRequestModel userRequestModel)
        {
            var request = new RestRequest(UserResource, Method.Post);
            request.AddParameter(ContentType.Json, userRequestModel, ParameterType.RequestBody);

            var response = await RestClient.ExecuteAsync<TViewModel>(request);

            return response;
        }
    }
}

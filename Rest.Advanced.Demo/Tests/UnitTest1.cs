using FluentAssertions;
using FluentAssertions.Execution;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using Rest.Advanced.Demo.Entity.Data;
using Rest.Advanced.Demo.Models.Request;
using Rest.Advanced.Demo.Models.View;
using Rest.Advanced.Demo.Services.User;
using RestSharp;
using System.Net;

namespace Rest.Advanced.Demo.Tests
{
    public class UserTestsDemo
    {
        private readonly UserService _userService;

        public UserTestsDemo()
        {
            _userService = new UserService();
        }

        [Fact]
        public async Task CreateUser_ShouldBeOK_Async()
        {
            // Arrange
            UserRequestModel userRequestModel = UserRequestModelFactory.CorrectModel;


            var expectedUserViewModel = new UserViewModel()
            {
                Code = HttpStatusCode.OK,
                Type = "unknown",
                Message = userRequestModel.Id.ToString()
            };

            // Act
            var response = await _userService.CreateUser<UserViewModel>(userRequestModel);
            var userViewModel = response.Data;

            // Assert
            using (new AssertionScope())
            {
                userViewModel.Should().BeEquivalentTo(expectedUserViewModel);
                response.StatusCode.Should().Be(HttpStatusCode.OK);
            }
        }

        [Fact]
        public async Task CreateUser_JsonScheme_And_Response_ShouldBeOK_Async()
        {
            // Arrange
            UserRequestModel userRequestModel = UserRequestModelFactory.CorrectModel;


            var expectedUserViewModel = new UserViewModel()
            {
                Code = HttpStatusCode.OK,
                Type = "unknown",
                Message = userRequestModel.Id.ToString()
            };

            var schemaJson = "{\r\n  \"$schema\": \"http://json-schema.org/draft-04/schema#\",\r\n  \"type\": \"object\",\r\n  \"properties\": {\r\n    \"code\": {\r\n      \"type\": \"integer\"\r\n    },\r\n    \"type\": {\r\n      \"type\": \"string\"\r\n    },\r\n    \"message\": {\r\n      \"type\": \"string\"\r\n    }\r\n  },\r\n  \"required\": [\r\n    \"code\",\r\n    \"type\",\r\n    \"message\"\r\n  ]\r\n}";
            var schema = JSchema.Parse(schemaJson);


            // Act
            var response = await _userService.CreateUser<UserViewModel>(userRequestModel);
            var userViewModel = response.Data;

            var person = JObject.Parse(response.Content);
            bool isValid = person.IsValid(schema, out IList<string> messages);

            // Assert
            using (new AssertionScope())
            {
                isValid.Should().BeTrue();
                userViewModel.Should().BeEquivalentTo(expectedUserViewModel);
                response.StatusCode.Should().Be(HttpStatusCode.OK);
            }
        }

        /*[Fact]
        public void CreateUser_ShouldBeOK()
        {
            // Arrange
            UserRequestModel userRequestModel = UserRequestModelFactory.CorrectModel;


            var expectedUserViewModel = new UserViewModel()
            {
                Code = HttpStatusCode.OK,
                Type = "unknown",
                Message = userRequestModel.Id.ToString()
            };

            // Act
            var response = _userService.CreateUser<UserViewModel>(userRequestModel);
            var userViewModel = response.Data;

            // Assert
            using (new AssertionScope())
            {
                userViewModel.Should().BeEquivalentTo(expectedUserViewModel);
                response.StatusCode.Should().Be(HttpStatusCode.OK);
            }
        }*/

        [Fact]
        public void Test1()
        {
            // Arrange
            var baseUrl = "https://petstore.swagger.io/v2";
            var resource = "/user";
            // var body = "{\r\n  \"id\": 0,\r\n  \"username\": \"string\",\r\n  \"firstName\": \"string\",\r\n  \"lastName\": \"string\",\r\n  \"email\": \"string\",\r\n  \"password\": \"string\",\r\n  \"phone\": \"string\",\r\n  \"userStatus\": 0\r\n}";

            UserRequestModel userRequestModel = UserRequestModelFactory.CorrectModel;


            var expectedUserViewModel = new UserViewModel()
            {
                Code = HttpStatusCode.OK,
                Type = "unknown",
                Message = userRequestModel.Id.ToString()
            };

            var client = new RestClient(baseUrl);
            var request = new RestRequest(resource, Method.Post);
            request.AddParameter(ContentType.Json, userRequestModel, ParameterType.RequestBody);
            //request.AddBody(userRequestModel, ContentType.Json);
            //request.AddJsonBody(userRequestModel);

            // Act
            var response = client.Execute<UserViewModel>(request);
            var userViewModel = response.Data;

            // Assert
           /* Assert.Equal(HttpStatusCode.OK, userViewModel.Code);
            Assert.Equal("unknown", userViewModel.Type);
            Assert.Equal(userRequestModel.Id.ToString(), userViewModel.Message);
            Assert.Equal(expectedUserViewModel, userViewModel);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);*/

            using(new AssertionScope())
            {
                userViewModel.Should().BeEquivalentTo(expectedUserViewModel);
                response.StatusCode.Should().Be(HttpStatusCode.OK);
            }
        }
    }
}
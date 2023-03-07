using RestSharp;
using System.Net;

namespace ApiTests
{
    public class ApiTests
    {
        [Fact]
        public void Onliner_Restsharp_Tests_Demo()
        {
            //Arrange
            var client = new RestClient("https://onliner.by");
            var restRequest = new RestRequest();
            
            //Act
            var response = client.Execute(restRequest);

            //Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.NotEqual(string.Empty, response.Content);
        }

        [Fact]
        public void PetSwagger_Restsharp_Tests_Demo()
        {
            //Arrange
            var client = new RestClient("https://petstore.swagger.io");
            var restRequest = new RestRequest("/v2/user", Method.Post);
            var body = "{\r\n  \"id\": 999,\r\n  \"username\": \"azizbek3767\",\r\n  \"firstName\": \"Azizbek\",\r\n  \"lastName\": \"Nasriddinov\",\r\n  \"email\": \"string\",\r\n  \"password\": \"pass\",\r\n  \"phone\": \"123456789\",\r\n  \"userStatus\": 1\r\n}";
            
            //Act
            restRequest.AddJsonBody(body);
            var response = client.Execute(restRequest);

            //Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.NotEqual(string.Empty, response.Content);
        }
    }
}

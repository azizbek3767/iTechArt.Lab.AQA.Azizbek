using RestSharp;
using System.Collections.Immutable;
using System.Net;
using Xunit.Abstractions;

namespace ApiTests
{
    public class JsonPlaceholderTests
    {
        private ITestOutputHelper _output;

        public JsonPlaceholderTests(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void FirstTest()
        {
            //Arrange
            var client = new RestClient("https://jsonplaceholder.typicode.com");
            var restRequest = new RestRequest("/posts", Method.Get);

            //Act
            var response = client.Execute(restRequest);

            foreach(var item in response.Content)
            {
                _output.WriteLine(item.ToString());
            }

            //Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.NotEqual(string.Empty, response.Content);
        }
    }
}

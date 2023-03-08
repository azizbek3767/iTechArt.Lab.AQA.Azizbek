using ApiTests.Models;
using Newtonsoft.Json;
using RestSharp;
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
        public void TestOne()
        {
            //Arrange
            var client = new RestClient("https://jsonplaceholder.typicode.com");
            var restRequest = new RestRequest("/posts", Method.Get);

            //Act
            var response = client.Execute(restRequest);

            //Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.NotEqual(string.Empty, response.Content);
        }

        [Fact]
        public void TestTwo()
        {
            //Arrange
            var client = new RestClient("https://jsonplaceholder.typicode.com");
            var restRequest = new RestRequest("/posts/{id}", Method.Get);
            restRequest.AddParameter("id", "99", ParameterType.UrlSegment);
            restRequest.AddParameter("application/json", ParameterType.RequestBody);

            //Act
            var response = client.Execute(restRequest);

            //Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.NotEqual(string.Empty, response.Content);
            var obj = JsonConvert.DeserializeObject<dynamic>(response.Content);
            Assert.Equal("10", Convert.ToString(obj.userId));
            Assert.Equal("99", Convert.ToString(obj.id));
        }

        [Fact]
        public void TestThree()
        {
            //Arrange
            var client = new RestClient("https://jsonplaceholder.typicode.com");
            var restRequest = new RestRequest("/posts/{id}", Method.Get);
            restRequest.AddParameter("id", "150", ParameterType.UrlSegment);
            restRequest.AddParameter("application/json", ParameterType.RequestBody);

            //Act
            var response = client.Execute(restRequest);

            //Assert
            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
            Assert.Equal("{}", Convert.ToString(response.Content));
        }

        [Fact]
        public void TestFour()
        {
            //Arrange
            var client = new RestClient("https://jsonplaceholder.typicode.com");
            var restRequest = new RestRequest("/posts", Method.Post);

            var body = "{\n  \"userId\": 1,\n  \"id\": 101,\n  \"title\": \"example title\",\n  \"body\": \"example body\"\n}";
            restRequest.AddJsonBody(body);
           //Act
           var response = client.Execute(restRequest);

            //Assert
            Assert.Equal(HttpStatusCode.Created, response.StatusCode);
            Assert.Equal(body, response.Content);
        }

        [Fact]
        public void TestFiveAndSix()
        {
            //Arrange
            var client = new RestClient("https://jsonplaceholder.typicode.com");
            var restRequest = new RestRequest("/users/{id}", Method.Get);
            restRequest.AddParameter("id", "5", ParameterType.UrlSegment);
            restRequest.AddParameter("application/json", ParameterType.RequestBody);

            //Act
            var response = client.Execute(restRequest);
            var obj = JsonConvert.DeserializeObject<dynamic>(response.Content);

            //Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.NotEqual(string.Empty, response.Content);
            Assert.Equal("Chelsey Dietrich", Convert.ToString(obj.name));
            Assert.Equal("Kamren", Convert.ToString(obj.username));
            Assert.Equal("Lucio_Hettinger@annie.ca", Convert.ToString(obj.email));
            Assert.Equal("Skiles Walks", Convert.ToString(obj.address.street));
            Assert.Equal("Suite 351", Convert.ToString(obj.address.suite));
            Assert.Equal("Roscoeview", Convert.ToString(obj.address.city));
            Assert.Equal("33263", Convert.ToString(obj.address.zipcode));
            Assert.Equal("-31.8129", Convert.ToString(obj.address.geo.lat));
            Assert.Equal("62.5342", Convert.ToString(obj.address.geo.lng));
            Assert.Equal("(254)954-1289", Convert.ToString(obj.phone));
            Assert.Equal("demarco.info", Convert.ToString(obj.website));
            Assert.Equal("Keebler LLC", Convert.ToString(obj.company.name));
            Assert.Equal("User-centric fault-tolerant solution", Convert.ToString(obj.company.catchPhrase));
            Assert.Equal("revolutionize end-to-end systems", Convert.ToString(obj.company.bs));
        }

        [Fact]
        public void TestSeven()
        {
            var users = new List<User>
                          {
                             new User()
                             {
                                 FirstName = "Azizbek",
                                 LastName = "Nasriddinov",
                                 Age = "22",
                                 RecordsAmount = new List<int>(){ 12, 13, 14 },
                                 IsMale = true,
                                 WalletAmount = 12000.00,
                                 FavouriteSongs = new string[]{"song 1", "song 2", "song 3"}
                             },
                             new User()
                             {
                                 FirstName = "Azizbek2",
                                 LastName = "Nasriddinov2",
                                 Age = "23",
                                 RecordsAmount = new List<int>(){ 11, 22, 33 },
                                 IsMale = true,
                                 WalletAmount = 11000.00,
                                 FavouriteSongs = new string[]{"song 1", "song 2", "song 3"}
                             },
                             new User()
                             {
                                 FirstName = "Azizbek3",
                                 LastName = "Nasriddinov3",
                                 Age = "24",
                                 RecordsAmount = new List<int>(){ 44, 55, 66 },
                                 IsMale = true,
                                 WalletAmount = 10000.00,
                                 FavouriteSongs = new string[]{"song 1", "song 2", "song 3"}
                             }
                          };
            var path = Path.Combine(AppContext.BaseDirectory, "Data", "users.json");
            File.WriteAllText(path, JsonConvert.SerializeObject(users));
        }
    }
}

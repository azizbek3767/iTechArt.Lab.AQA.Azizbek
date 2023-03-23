using FluentAssertions;
using FluentAssertions.Execution;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using Rest.Advanced.Homework.Entity.Data;
using Rest.Advanced.Homework.Models;
using Rest.Advanced.Homework.Models.Request;
using Rest.Advanced.Homework.Models.View;
using Rest.Advanced.Homework.Services.Booking;
using RestSharp;
using System.Net;

namespace Rest.Advanced.Homework.Tests
{
    public class TaskOneTests
    {
        private readonly BookingService _bookingService;
        public TaskOneTests()
        {
            _bookingService = new BookingService();
        }

        [Fact]
        public async Task CreateBooking_ShouldBeOK_Async()
        {
            // Arrange
            BookingRequestModel bookingRequestModel = BookingRequestModelFactory.CorrectModel;
            var schemaJson = "{\r\n  \"$schema\": \"http://json-schema.org/draft-04/schema#\",\r\n  \"type\": \"object\",\r\n  \"properties\": {\r\n    \"bookingid\": {\r\n      \"type\": \"integer\"\r\n    },\r\n    \"booking\": {\r\n      \"type\": \"object\",\r\n      \"properties\": {\r\n        \"bookingid\": {\r\n          \"type\": \"integer\"\r\n        },\r\n        \"roomid\": {\r\n          \"type\": \"integer\"\r\n        },\r\n        \"firstname\": {\r\n          \"type\": \"string\"\r\n        },\r\n        \"lastname\": {\r\n          \"type\": \"string\"\r\n        },\r\n        \"depositpaid\": {\r\n          \"type\": \"boolean\"\r\n        },\r\n        \"bookingdates\": {\r\n          \"type\": \"object\",\r\n          \"properties\": {\r\n            \"checkin\": {\r\n              \"type\": \"string\"\r\n            },\r\n            \"checkout\": {\r\n              \"type\": \"string\"\r\n            }\r\n          },\r\n          \"required\": [\r\n            \"checkin\",\r\n            \"checkout\"\r\n          ]\r\n        }\r\n      },\r\n      \"required\": [\r\n        \"bookingid\",\r\n        \"roomid\",\r\n        \"firstname\",\r\n        \"lastname\",\r\n        \"depositpaid\",\r\n        \"bookingdates\"\r\n      ]\r\n    }\r\n  },\r\n  \"required\": [\r\n    \"bookingid\",\r\n    \"booking\"\r\n  ]\r\n}";
            var schema = JSchema.Parse(schemaJson);


            // Act
            
                // Check Health
            var healthResponse = await _bookingService.CheckHealth();
            var healthResponseObj = JsonConvert.DeserializeObject<dynamic>(healthResponse.Content);

                // Login
            var loginResponse = await _bookingService.Login();

                // Validate
            var validateResponse = await _bookingService.Validate();

            var response = await _bookingService.CreateBooking<BookingViewModel>(bookingRequestModel);
            var bookingViewModel = response.Data;
            var obj = JsonConvert.DeserializeObject<dynamic>(response.Content);

            var getResponse = await _bookingService.GetBooking<BookingViewModel>(Convert.ToInt32(obj.bookingid));
            var bookingViewModelToCheck = getResponse.Data;

            var person = JObject.Parse(response.Content);
            bool isValid = person.IsValid(schema, out IList<string> messages);

            var expectedBookingViewModel = new BookingViewModel()
            {
                BookingID = obj.bookingid,
                Booking = new Booking
                {
                    BookingID = obj.bookingid,
                    RoomID = bookingRequestModel.RoomId,
                    FirstName = bookingRequestModel.FirstName,
                    LastName = bookingRequestModel.LastName,
                    DepositPaid = bookingRequestModel.DepositPaid,
                    BookingDates = bookingRequestModel.BookingDates,
                }
            };

            // Assert
            using (new AssertionScope())
            {
                healthResponse.StatusCode.Should().Be(HttpStatusCode.OK);
                
                loginResponse.StatusCode.Should().Be(HttpStatusCode.OK);

                isValid.Should().BeTrue();
                bookingViewModel.Should().BeEquivalentTo(expectedBookingViewModel);
                //bookingViewModelToCheck.Should().BeEquivalentTo(expectedBookingViewModel);
                response.StatusCode.Should().Be(HttpStatusCode.Created);
            }
            await _bookingService.Logout();
        }
       
    }
}

using Bogus;
using Rest.Advanced.Demo.Models.Request;
using Rest.Advanced.Homework.Models;
using Rest.Advanced.Homework.Models.Request;

namespace Rest.Advanced.Homework.Entity.DataFaker
{
    public static class BookingRequestModelFaker
    {
        public static Faker<BookingRequestModel> CorrectBooking()
        {
            var random = new Random();
            /*var bookingDates = new Faker<BookingDates>()
            .RuleFor(u => u.CheckIn, f => f.Date.Past(2020).ToShortDateString())
            .RuleFor(u => u.CheckOut, f => f.Date.Future(2025).ToShortDateString());*/

            
            BookingDates bookingDates = new()
            {
                CheckIn = "2020-02-01",
                CheckOut = "2020-02-05"
            };
            return new Faker<BookingRequestModel>()
                .RuleFor(u => u.RoomId, f => f.Random.Int(1, 200))
                .RuleFor(u => u.FirstName, f => f.Person.FirstName)
                .RuleFor(u => u.LastName, f => f.Person.LastName)
                .RuleFor(u => u.DepositPaid, random.Next(100) < 40)
                .RuleFor(u => u.Email, f => f.Person.Email)
                .RuleFor(u => u.Phone, f => f.Phone.PhoneNumber())
                .RuleFor(u => u.BookingDates, bookingDates);
        }
    }
}

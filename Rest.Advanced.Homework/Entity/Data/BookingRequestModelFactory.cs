using Rest.Advanced.Homework.Entity.DataFaker;
using Rest.Advanced.Homework.Models.Request;

namespace Rest.Advanced.Homework.Entity.Data
{
    public class BookingRequestModelFactory
    {
        public static readonly BookingRequestModel CorrectModel = BookingRequestModelFaker.CorrectBooking();
    }
}

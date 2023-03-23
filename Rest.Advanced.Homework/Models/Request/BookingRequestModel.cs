using Newtonsoft.Json;

namespace Rest.Advanced.Homework.Models.Request
{
    public class BookingRequestModel
    {
        [JsonProperty(PropertyName = "roomid")]
        public int RoomId { get; set; }

        [JsonProperty(PropertyName = "firstname")]
        public string FirstName { get; set; }

        [JsonProperty(PropertyName = "lastname")]
        public string LastName { get; set; }

        [JsonProperty(PropertyName = "depositpaid")]
        public bool DepositPaid { get; set; }

        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        [JsonProperty(PropertyName = "phone")]
        public string Phone { get; set; }

        [JsonProperty(PropertyName = "bookingdates")]
        public BookingDates BookingDates { get; set; }
    }
}

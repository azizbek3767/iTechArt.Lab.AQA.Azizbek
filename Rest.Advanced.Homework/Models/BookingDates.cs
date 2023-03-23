using Newtonsoft.Json;

namespace Rest.Advanced.Homework.Models
{
    public class BookingDates
    {
        [JsonProperty(PropertyName = "checkin")]
        public string CheckIn { get; set; }
        [JsonProperty(PropertyName = "checkout")]
        public string CheckOut { get; set; }
    }
}

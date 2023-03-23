namespace Rest.Advanced.Homework.Models
{
    public class Booking
    {
        public int BookingID { get; set; }
        public int RoomID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool DepositPaid { get; set; }
        public BookingDates BookingDates { get; set; }
    }
}

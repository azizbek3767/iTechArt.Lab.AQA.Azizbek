namespace ApiTests.Models
{
    public class User
    {
        public string FirstName { get; set; }
        public object LastName { get; set; }
        public dynamic Age { get; set; }
        public ICollection<int> RecordsAmount { get; set; }
        public bool IsMale { get; set; }
        public double WalletAmount { get; set; }
        public string[] FavouriteSongs { get; set; }
    }
}

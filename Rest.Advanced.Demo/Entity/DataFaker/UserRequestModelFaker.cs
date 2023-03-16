using Bogus;
using Rest.Advanced.Demo.Models.Request;

namespace Rest.Advanced.Demo.Entity.DataFaker
{
    public static class UserRequestModelFaker
    {
        public static Faker<UserRequestModel> CorrectModel()
        {
            return new Faker<UserRequestModel>()
                .RuleFor(u => u.Id, f => f.Random.Int(0))
                .RuleFor(u => u.UserName, f => f.Person.UserName)
                .RuleFor(u => u.FirstName, f => f.Person.FirstName)
                .RuleFor(u => u.LastName, f => f.Person.LastName)
                .RuleFor(u => u.Email, f => f.Person.Email)
                .RuleFor(u => u.Password, f => f.Database.Collation())
                .RuleFor(u => u.Phone, f => f.Phone.PhoneNumber())
                .RuleFor(u => u.UserStatus, f => f.Random.Int(0));
        }
    }
}

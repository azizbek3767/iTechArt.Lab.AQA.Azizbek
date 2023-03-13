using Saucedemo.Core.Models;

namespace Saucedemo.Core.Builders
{
    public interface IUserBuilder
    {
        void AddUsername();
        void AddPassword();
        User GetUser();
    }
}

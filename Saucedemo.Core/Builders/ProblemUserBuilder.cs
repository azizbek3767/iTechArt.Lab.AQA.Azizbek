using Saucedemo.Core.Models;
using Saucedemo.Core.Utilities;

namespace Saucedemo.Core.Builders
{
    internal class ProblemUserBuilder : IUserBuilder
    {
        private const string LockedOutUserBuilderUsernameKey = "problem_user_username";
        private const string CommonPasswordKey = "common_password";

        private User _user = new User();
        public ProblemUserBuilder()
        {
            Reset();
        }
        public void Reset()
        {
            _user = new User();
        }
        public void AddUsername()
        {
            _user.Username = Configurator.GetConfigurator().GetSection(LockedOutUserBuilderUsernameKey).Value;
        }
        public void AddPassword()
        {
            _user.Password = Configurator.GetConfigurator().GetSection(CommonPasswordKey).Value;
        }
        public User GetUser()
        {
            User result = _user;
            Reset();
            return result;
        }
    }
}

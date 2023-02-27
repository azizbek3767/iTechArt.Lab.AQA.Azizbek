namespace Saucedemo.Core.Builders
{
    public class UserBuilderDirector
    {
        private IUserBuilder _userBuilder;
        public IUserBuilder UserBuilder { 
            set
            {
                _userBuilder = value;
            }
        }
        public void BuildUser()
        {
            _userBuilder.AddUsername();
            _userBuilder.AddPassword();
        }
    }
}

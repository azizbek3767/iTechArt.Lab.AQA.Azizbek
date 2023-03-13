using Saucedemo.Core.Builders;

namespace Saucedemo.Core.Extensions
{
    public static class UserBuilderTypeSelector
    {
        public static IUserBuilder SelectUserBuilderByString(string userType)
        {
            switch(userType)
            {
                case "standard_user":
                    return new StandardUserBuilder();
                    break;
                case "locked_out_user":
                    return new LockedOutUserBuilder();
                    break;
                case "problem_user":
                    return new ProblemUserBuilder();
                    break;
                case "performance_glitch_user":
                    return new PerformanceGlitchUserBuilder();
                    break;
                default:
                    throw new ArgumentException($"User with type {userType} does not exist");
            }
        }
    }
}

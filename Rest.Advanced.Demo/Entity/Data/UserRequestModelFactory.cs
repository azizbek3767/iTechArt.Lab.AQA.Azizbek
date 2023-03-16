using Rest.Advanced.Demo.Entity.DataFaker;
using Rest.Advanced.Demo.Models.Request;

namespace Rest.Advanced.Demo.Entity.Data
{
    public static class UserRequestModelFactory
    {
        public static readonly UserRequestModel CorrectModel = UserRequestModelFaker.CorrectModel();
    }
}

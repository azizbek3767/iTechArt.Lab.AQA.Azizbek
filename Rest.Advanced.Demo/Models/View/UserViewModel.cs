using System.Net;

namespace Rest.Advanced.Demo.Models.View
{
    public class UserViewModel
    {
        public HttpStatusCode Code { get; set; }
        public string Type { get; set; }
        public string Message { get; set; }
    }
}

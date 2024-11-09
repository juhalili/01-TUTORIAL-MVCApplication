using Microsoft.AspNetCore.Mvc;

namespace MVCApplication.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            return "This is the index page";
        }

        public string Hello()
        {
            return "Hello";
        }
    }
}

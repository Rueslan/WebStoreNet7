using Microsoft.AspNetCore.Mvc;

namespace WebStoreNet7.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult Page404() => View();
        public IActionResult Cart() => View();
        public IActionResult Checkout() => View();
        public IActionResult ContactUs() => View();
        public IActionResult Login() => View();
        public IActionResult ProductDetails() => View();
        public IActionResult Shop() => View();

        //public IActionResult Status(string Code) => Content($"Status code - {Code}");

    }
}

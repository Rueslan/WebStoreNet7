using Microsoft.AspNetCore.Mvc;

namespace WebStoreNet7.Controllers
{
    public class HomeController : Controller
    {       
        public IActionResult Index() => View();

    }
}

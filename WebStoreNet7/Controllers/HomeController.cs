using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace WebStoreNet7.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SecondAction(string id)
        {
            return Content($"Second Action with parametr {id}");
        }

        public string NoIndex()
        {
            return "Hello from NoIndex";
        }
    }
}

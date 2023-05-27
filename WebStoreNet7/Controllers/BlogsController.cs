using Microsoft.AspNetCore.Mvc;

namespace WebStoreNet7.Controllers
{
	public class BlogsController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}

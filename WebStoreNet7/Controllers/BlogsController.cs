using Microsoft.AspNetCore.Mvc;

namespace WebStoreNet7.Controllers
{
	public class BlogsController : Controller
	{
		public IActionResult Index() => View();
		public IActionResult WebStoreBlog() => View();
	}
}

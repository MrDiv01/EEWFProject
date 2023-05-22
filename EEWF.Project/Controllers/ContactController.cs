using Microsoft.AspNetCore.Mvc;

namespace EEWF.Project.Controllers
{
	public class ContactController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}

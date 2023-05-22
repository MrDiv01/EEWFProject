using Microsoft.AspNetCore.Mvc;

namespace EEWF.Project.Controllers
{
	public class CoursesController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}

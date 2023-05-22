using EEWF.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EEWF.Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICaruselService _caruselService;
        public HomeController(ICaruselService caruselService)
        {
            _caruselService = caruselService;
        }
        public IActionResult Index()
        {
            var carusel = _caruselService.GetCarusel();
            return View(carusel);
        }
    }
}

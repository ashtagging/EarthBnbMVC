using Microsoft.AspNetCore.Mvc;

namespace EarthBnbMVC.Controllers
{
    public class ListingsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}

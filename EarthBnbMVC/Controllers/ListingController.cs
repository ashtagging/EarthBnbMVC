using EarthBnb.Models;
using Microsoft.AspNetCore.Mvc;

namespace EarthBnbMVC.Controllers
{
    public class ListingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            var listing = new Listing();
            return View(listing);
        }

        public IActionResult CreateListing(Listing listing )
        {
            return View("Index");
        }
    }
}

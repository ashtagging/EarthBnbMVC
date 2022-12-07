using EarthBnbMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace EarthBnbMVC.Controllers
{
    public class ListingController : Controller
    {
        private static List<Listing> listings = new List<Listing>();
        
        public IActionResult Index()
        {
            return View(listings);
        }

        public IActionResult Create()
        {
            var listing = new Listing();
            return View(listing);
        }

        public IActionResult CreateListing(Listing listing)
        {
            listings.Add(listing);
            return RedirectToAction(nameof(Index));
        }
    }
}

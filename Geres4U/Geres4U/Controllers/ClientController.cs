using Microsoft.AspNetCore.Mvc;

namespace Geres4U.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetPointsOfInterest()
        {
            return View();
        }

        public IActionResult GetSpecificPointOfInterest()
        {
            return View();
        }

        public IActionResult AddPointVisited()
        {
            return View();
        }

        public IActionResult GetPointsVisited()
        {
            return View();
        }

        public IActionResult SugestPointOfInterest()
        {
            return View();
        }
    }
}

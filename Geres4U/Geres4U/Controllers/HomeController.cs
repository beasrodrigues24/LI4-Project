using Geres4U.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Geres4U.Data;

namespace Geres4U.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public ActionResult SignUpClient()
        {
            ViewBag.Message = "Client SignUp";
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUpClient(Client c)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index"); // se funcionar vai dar redirect para "Index" TODO: alterar para o sítio correto de redirect
            }

            return View();
        }

        public ActionResult SignUpRev()
        {
            ViewBag.Message = "Reviser SignUp";
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUpRev(Reviser r)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index"); // se funcionar vai dar redirect para "Index" TODO: alterar para o sítio correto de redirect
            }

            return View();
        }
    }
}

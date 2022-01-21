using Geres4U.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Geres4U.Data;
using Geres4U.Data.DataModels;

namespace Geres4U.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IDataAccess _db = new DataAccess();
        public string currentlyLoggedUser { get; set; }

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

        public async Task<bool> SignUpClientToDB(Client c)
        {
            ClientData cd = new ClientData(_db);
            List<ClientDataModel> newclient = await cd.getClient(new ClientDataModel(c.Email, c.Password));
            if (newclient.Count == 0)
            {
                await cd.InsertClient(new ClientDataModel(c.Email, c.Password));
                return true;
            }
            return false;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUpClient(Client c)
        {
            if (ModelState.IsValid)
                if(SignUpClientToDB(c).Result)
                    return RedirectToAction("Index"); // se funcionar vai dar redirect para "Index" TODO: alterar para o sítio correto de redirect

            return View();
        }

        public ActionResult SignIn()
        {
            ViewBag.Message = "SignIn";
            return View();
        }

        public async Task<int> SignInUser(Authentication u)
        {
            ClientData cd = new ClientData(_db);
            ReviserData rd = new ReviserData(_db);
            List<ClientDataModel> client = await cd.getClient(new ClientDataModel(u.Email, u.Password));
            if (client.Count != 0)
            {
                foreach (ClientDataModel c in client)
                {
                    if (c.Password.Equals(u.Password))
                    {
                        currentlyLoggedUser = u.Email;
                        return 1;
                    }
                    return -1;
                }
            }
            else
            {
                List<ReviserDataModel> reviser = await rd.getReviser(new ReviserDataModel(u.Email, u.Password));
                if (reviser.Count != 0)
                {
                    foreach (ReviserDataModel r in reviser)
                    {
                        if (r.Password.Equals(u.Password))
                        {
                            currentlyLoggedUser = u.Email;
                            return 1;
                        }

                        return -1;
                    }
                }
            }

            return 0;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignIn(Authentication a)
        {
            if(ModelState.IsValid)
                if (SignInUser(a).Result == 1)
                {
                    TempData["user"] = currentlyLoggedUser;
                    return RedirectToAction("Index", "Client", new{email = currentlyLoggedUser});
                    // TODO: Mensagens de Erro para -1 -> Password incorreta ou 0 -> utilizador inexistente
                }

            return View();
        }
    }
}

using Geres4U.Data;
using Geres4U.Data.DataModels;
using Geres4U.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Geres4U.Controllers
{
    public class ReviserController : Controller
    {
        private readonly IDataAccess _db = new DataAccess();
        public IActionResult Index()
        {
            return View("Index", (string)TempData.Peek("email"));
        }
        public List<PointOfInterest> GetPointsOfInterestOfDB()
        {
            PointOfInterestData pd = new PointOfInterestData(_db);
            List<PointOfInterestDataModel> points = pd.GetPointsOfInterest().Result;
            List<PointOfInterest> ans = new List<PointOfInterest>();
            if (points.Count > 0)
            {
                PointOfInterestCategoryData pcd = new PointOfInterestCategoryData(_db);
                foreach (PointOfInterestDataModel pdm in points)
                {
                    List<CategoryDataModel> cats = pcd.getCategoriesFromPointOfInterest(pdm.ID);
                    PointOfInterest p = new PointOfInterest(pdm.ID, pdm.Name, pdm.Images, pdm.Lat, pdm.Long, pdm.isSugestion == 1, pdm.Description);
                    if (cats.Count > 0)
                    {
                        List<Category> cat = new List<Category>();
                        foreach (CategoryDataModel cdm in cats)
                        {
                            cat.Add(new Category(cdm.ID, cdm.Name));
                        }

                        foreach (Category c in cat)
                        {
                            p.addCategory(c);
                        }
                    }
                    ans.Add(p);
                }
            }
            return ans;
        }

        public PointOfInterest GetSpecificPointOfInterestDB(int id)
        {
            PointOfInterestData pd = new PointOfInterestData(_db);
            List<PointOfInterestDataModel> points = pd.getPointOfInterest(new PointOfInterestDataModel(id)).Result;
            if (points.Count > 0)
            {
                PointOfInterest ans = new PointOfInterest(); // vai sempre avançar para o for pq count > 0, mas sou obrigado a inicializar aqui senão não dá pra adicionar categorias
                foreach (PointOfInterestDataModel pdm in points)
                {
                    ans = new PointOfInterest(pdm.ID, pdm.Name, pdm.Images, pdm.Lat, pdm.Long, pdm.isSugestion == 1,
                        pdm.Description);
                }
                PointOfInterestCategoryData pcd = new PointOfInterestCategoryData(_db);
                List<CategoryDataModel> cats = pcd.getCategoriesFromPointOfInterest(id);
                foreach (CategoryDataModel c in cats)
                    ans.addCategory(new Category(c.ID, c.Name));
                return ans;
            }

            return null;
        }

        public IActionResult GetSpecificPointOfInterest(int id, string ret)
        {
            PointOfInterest pi = GetSpecificPointOfInterestDB(id);
            ViewBag.returning = ret;
            ViewBag.id = id;
            return View(pi);
        }

        public IActionResult GetPointsOfInterest()
        {
            List<PointOfInterest> ans = GetPointsOfInterestOfDB();

            return View(ans);
        }

        public List<PointOfInterest> GetSugestionsOfDB()
        {
            PointOfInterestData pd = new PointOfInterestData(_db);
            List<PointOfInterestDataModel> points = pd.getSugestionsPointsOfInterest().Result;
            List<PointOfInterest> ans = new List<PointOfInterest>();
            if (points.Count > 0)
            {
                PointOfInterestCategoryData pcd = new PointOfInterestCategoryData(_db);
                foreach (PointOfInterestDataModel pdm in points)
                {
                    List<CategoryDataModel> cats = pcd.getCategoriesFromPointOfInterest(pdm.ID);
                    PointOfInterest p = new PointOfInterest(pdm.ID, pdm.Name, pdm.Images, pdm.Lat, pdm.Long, pdm.isSugestion == 1, pdm.Description);
                    if (cats.Count > 0)
                    {
                        List<Category> cat = new List<Category>();
                        foreach (CategoryDataModel cdm in cats)
                        {
                            cat.Add(new Category(cdm.ID, cdm.Name));
                        }

                        foreach (Category c in cat)
                        {
                            p.addCategory(c);
                        }
                    }
                    ans.Add(p);
                }
            }
            return ans;
        }

        public IActionResult GetSugestions()
        {
            List<PointOfInterest> ans = GetSugestionsOfDB();

            return View(ans);
        }

        public bool AcceptSugestionOnDB(int id)
        {
            PointOfInterestData pd = new PointOfInterestData(_db);
            List<PointOfInterestDataModel> pdm = pd.getPointOfInterest(new PointOfInterestDataModel(id)).Result;
            foreach (PointOfInterestDataModel pidm in pdm)
            {
                PointOfInterestDataModel p = new PointOfInterestDataModel(pidm.ID, pidm.Name, pidm.Images, pidm.Lat,
                    pidm.Long, 0, pidm.Description);
                if (p.Description == null && p.Images == null)
                {
                    pd.UpdatePointOfInterestWithoutImagePathAndDescription(p);
                }
                else if (p.Description != null) pd.UpdatePointOfInterestWithoutImagePath(p);
                else if (p.Images != null) pd.UpdatePointOfInterestWithoutDescription(p);
                else pd.UpdatePointOfInterest(p);
            }
            return true;
        }
        
        public IActionResult AcceptPointOfInterestSugestion(int id)
        {
            bool res = AcceptSugestionOnDB(id);
            ViewBag.result = (res ? "Operação efetuada com sucesso" : "Erro");
            return RedirectToAction("GetSugestions");
        }

        public bool RemovePointOfInterestDB(int id)
        {
            PointOfInterestData pd = new PointOfInterestData(_db);
            PointOfInterestCategoryData pcd = new PointOfInterestCategoryData(_db);
            ClientHistoryData chd = new ClientHistoryData(_db);
            List<PointOfInterestDataModel> pdm = pd.getPointOfInterest(new PointOfInterestDataModel(id)).Result;
            foreach (PointOfInterestDataModel pidm in pdm)
            {
                pcd.removeCategoryOfPoint(new PointOfInterestCategoryDataModel(pidm.ID));
                chd.RemoveHistoryFromPointOfInterest(new ClientHistoryDataModel(pidm.ID));
                pd.RemovePointOfInterest(pidm);
            }
            return true;
        }

        public IActionResult RejectPointOfInterestSugestion(int id)
        {
            bool res = RemovePointOfInterestDB(id);
            ViewBag.result = (res ? "Operação efetuada com sucesso" : "Erro");
            return RedirectToAction("GetSugestions");
        }


        public IActionResult RemovePointOfInterest()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult RemovePointOfInterest(PointOfInterestRemoval p)
        {
            if (ModelState.IsValid)
            {
                bool res = RemovePointOfInterestDB(p.id);
                ViewBag.result = (res ? "Operação efetuada com sucesso" : "Erro");
                return View("Index");

            }

            ViewBag.result = "Opções inválidas.";
            return View("RemovePointOfInterest");
        }

        public bool AddPointOfInterestToDB(PointOfInterestDataModel p, int cat)
        {
            PointOfInterestData pd = new PointOfInterestData(_db);
            PointOfInterestCategoryData picd = new PointOfInterestCategoryData(_db);
            if (p.Description != null && p.Images != null)
            {
                pd.InsertPointOfInterestWithoutDescriptionAndImage(p);
            }
            else if (p.Description != null) pd.InsertPointOfInterestWithDescriptionWithoutImage(p);
            else if (p.Images != null) pd.InsertPointOfInterestSugestionWithoutDescription(p);
            else pd.InsertPointOfInterestWithDescriptionAndImagePath(p);
            // PointOfInterestData pd2 = new PointOfInterestData(_db);
            List<PointOfInterestDataModel> insertedPoint = pd.GetPointOfInterestWithAllFields(p).Result;
            foreach (PointOfInterestDataModel pID in insertedPoint)
            {
                picd.InsertCategory(new PointOfInterestCategoryDataModel(cat, pID.ID));
            }
            return true;
        }

        public IActionResult AddPointOfInterest()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddPointOfInterest(PointOfInterestByReviser p)
        {
            if (ModelState.IsValid)
            {
                Category c = new Category(p.Category);
                PointOfInterestDataModel pidm = new PointOfInterestDataModel(-1, p.Name, p.ImagePath, p.Lat, p.Long, 0, p.Description);
                bool res = AddPointOfInterestToDB(pidm, c.Id);
                ViewBag.result = (res ? "Operação efetuada com sucesso" : "Erro");
                return View("Index");
            }

            ViewBag.result = "Opções inválidas";
            return View("AddPointOfInterest");
            
        }

        public IActionResult UpdatePointOfInterest()
        {
            return View();
        }

        public async Task<bool> UpdatePointOfInterestOnDB(PointOfInterestDataModel p)
        {
            PointOfInterestData pd = new PointOfInterestData(_db);
            List<PointOfInterestDataModel> pdm = pd.getPointOfInterest(p).Result;
            if (pdm != null && pdm.Count > 0)
            {
                await pd.UpdatePointOfInterest(p);
                return true;
            }
            else return false;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdatePointOfInterest(PointOfInterestToUpdate p)
        {
            if (ModelState.IsValid)
            {
                PointOfInterestDataModel pdm =
                    new PointOfInterestDataModel(p.Id, p.Name, p.ImagePath, p.Lat, p.Long, 0, p.Description);
                bool res = UpdatePointOfInterestOnDB(pdm).Result;
                ViewBag.result = (res ? "Operação efetuada com sucesso" : "Erro");
                return View("Index");
            }

            ViewBag.result = "Opções inválidas";
            return View("UpdatePointOfInterest");
        }

        public async Task<bool> AddCategoryToPointOnDB(PointOfInterestCategoryDataModel p)
        {
            PointOfInterestCategoryData pcd = new PointOfInterestCategoryData(_db);
            await pcd.InsertCategory(p);
            return true;
        }

        public IActionResult AddCategoryToPointOfInterest(int pointID, string categoryName)
        {
            bool res;
            Category c = new Category(categoryName);
            if(c.Id == -1) res = false;
            else
            {
                PointOfInterestCategoryDataModel p = new PointOfInterestCategoryDataModel(c.Id, pointID);
                res = AddCategoryToPointOnDB(p).Result;
            }

            return View(res);
        }

        public IActionResult LoggingOut()
        {
            TempData.Remove("email");
            return RedirectToAction("Index", "Home");
        }
    }
}

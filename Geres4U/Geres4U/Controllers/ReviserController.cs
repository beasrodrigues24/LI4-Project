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
            return View();
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
                pd.RemovePointOfInterest(new PointOfInterestDataModel(id));
                PointOfInterestDataModel p = new PointOfInterestDataModel(pidm.ID, pidm.Name, pidm.Images, pidm.Lat,
                    pidm.Long, 0, pidm.Description);
                if (p.Description != null && p.Images != null)
                {
                    pd.InsertPointOfInterestWithoutDescriptionAndImage(p);
                }
                else if (p.Description != null)pd.InsertPointOfInterestWithDescriptionWithoutImage(p);
                else pd.InsertPointOfInterestWithDescriptionAndImagePath(p);
            }
            return true;
        }

        public IActionResult AcceptPointOfInterestSugestion(int id)
        {
            bool res = AcceptSugestionOnDB(id);
            return View(res);
        }

        public bool RemovePointOfInterestDB(int id)
        {
            PointOfInterestData pd = new PointOfInterestData(_db);
            List<PointOfInterestDataModel> pdm = pd.getPointOfInterest(new PointOfInterestDataModel(id)).Result;
            foreach (PointOfInterestDataModel pidm in pdm)
            {
                pd.RemovePointOfInterest(new PointOfInterestDataModel(id));
            }
            return true;
        }

        public IActionResult RejectPointOfInterestSugestion(int id)
        {
            bool res = RemovePointOfInterestDB(id);
            return View(res);
        }

        public IActionResult RemovePointOfInterest(int id)
        {
            bool res = RemovePointOfInterestDB(id);
            return View(res);
        }

        public bool AddPointOfInterestToDB(PointOfInterestDataModel p)
        {
            PointOfInterestData pd = new PointOfInterestData(_db);
            if (p.Description != null && p.Images != null)
            {
                pd.InsertPointOfInterestWithoutDescriptionAndImage(p);
            }
            else if (p.Description != null) pd.InsertPointOfInterestWithDescriptionWithoutImage(p);
            else pd.InsertPointOfInterestWithDescriptionAndImagePath(p);

            return true;
        }

        public IActionResult AddPointOfInterest()
        {
            ViewBag.Message = "AddPointOfInterest";
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddPointOfInterest(PointOfInterestByReviser p)
        {
            PointOfInterestDataModel pidm = new PointOfInterestDataModel(-1, p.Name, p.ImagePath, p.Lat, p.Long, 0, p.Description);
            bool res = AddPointOfInterestToDB(pidm);
            return View(res);
        }

        public IActionResult UpdatePointOfInterest()
        {
            ViewBag.Message = "UpdatePointOfInterest";
            return View();
        }

        public async Task<bool> UpdatePointOfInterestOnDB(PointOfInterestDataModel p)
        {
            PointOfInterestData pd = new PointOfInterestData(_db);
            List<PointOfInterestDataModel> pdm = pd.getPointOfInterest(p).Result;
            if (pdm != null && pdm.Count > 0)
            {
                await pd.RemovePointOfInterest(p);
                AddPointOfInterestToDB(p);
                return true;
            }
            else return false;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdatePointOfInterest(PointOfInterestToUpdate p)
        {
            PointOfInterestDataModel pdm =
                new PointOfInterestDataModel(p.Id, p.Name, p.ImagePath, p.Lat, p.Long, 0, p.Description);
            bool res = UpdatePointOfInterestOnDB(pdm).Result;
            return View(res);
        }

        public IActionResult LoggingOut()
        {
            TempData.Remove("email");
            return RedirectToAction("Index", "Home");
        }
    }
}

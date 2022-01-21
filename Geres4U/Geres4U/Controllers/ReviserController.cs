using System;
using System.Collections.Generic;
using Geres4U.Data;
using Geres4U.Data.DataModels;
using Geres4U.Models;
using Microsoft.AspNetCore.Mvc;

namespace Geres4U.Controllers
{
    public class ReviserController : Controller
    {
        private readonly IDataAccess _db = new DataAccess();
        public string Email { get; set; }
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
                PointOfInterestDataModel p = new PointOfInterestDataModel(pidm.ID, pidm.Name, pidm.Images, pidm.Lat,
                    pidm.Long, pidm.isSugestion, pidm.Description);
                if (p.Description != null && p.Images != null)
                {
                    pd.InsertPointOfInterestWithoutDescriptionAndImage(p);
                }
                else if (p.Description != null) pd.InsertPointOfInterestWithDescriptionWithoutImage(p);
                else pd.InsertPointOfInterestWithDescriptionAndImagePath(p);
            }
            return true;
        }

        public IActionResult AcceptPointOfInterestSugestion(int id)
        {
            bool res = AcceptSugestionOnDB(id);
            return View(res);
        }

        public IActionResult RejectPointOfInterestSugestion(int id)
        {
            return View();
        }

        public IActionResult AddPointOfInterest(PointOfInterestByReviser p)
        {
            return View();
        }

        public IActionResult RemovePointOfInterest(int id)
        {
            return View();
        }
    }
}

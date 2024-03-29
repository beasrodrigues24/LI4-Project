﻿using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using Geres4U.Data;
using Geres4U.Data.DataModels;
using Geres4U.Models;
using Microsoft.AspNetCore.Mvc;

namespace Geres4U.Controllers
{
    public class ClientController : Controller
    {
        private readonly IDataAccess _db = new DataAccess();
        public IActionResult Index(string email)
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
                            p.Category = c.Name;
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
                    ans.Category = c.Name;
                return ans;
            }

            return null;
        }

        public IActionResult GetSpecificPointOfInterest(int id, string ret)
        {
            PointOfInterest pi = GetSpecificPointOfInterestDB(id);
            ViewBag.returning = ret;
            return View(pi);
        }

        public async Task<bool> AddPointVisitedToDB(int id)
        {
            PointOfInterestData pd = new PointOfInterestData(_db);
            List<PointOfInterestDataModel> points = await pd.getPointOfInterest(new PointOfInterestDataModel(id));
            if (points.Count > 0)
            {
                ClientHistoryData chD = new ClientHistoryData(_db);
                await chD.InsertHistory(new ClientHistoryDataModel((string)TempData.Peek("email"), id));
                return true;
            }

            return false;
        }

        public IActionResult AddPointVisited(int id)
        {
            bool resultOfOp = AddPointVisitedToDB(id).Result;

            string resultMessage = (resultOfOp ? "Adicionado com sucesso" : "Erro");
            ViewBag.result = resultMessage;
            return View("GetPointsOfInterest", GetPointsOfInterestOfDB());
        }

        public async Task<bool> removePointVisitedDB(int id)
        {
            bool exists = false;
            ClientHistoryData chD = new ClientHistoryData(_db);
            List<PointOfInterestDataModel> points = chD.getHistoryFromClient((string)TempData.Peek("email"));
            foreach (PointOfInterestDataModel point in points)
                if (point.ID == id)
                {
                    exists = true;
                    break;
                }

            if (exists)
            {
                await chD.RemoveHistory(new ClientHistoryDataModel((string)TempData.Peek("email"), id));
                return true;
            }

            return false;
        }

        public IActionResult RemovePointVisited(int id)
        {
            bool resultOfOp = removePointVisitedDB(id).Result;
            ViewBag.result = (resultOfOp ? "Removido com sucesso" : "Erro");
            return View("GetPointsVisited", GetHistoryFromClient());
        }

        public List<PointOfInterest> GetHistoryFromClient()
        {
            ClientHistoryData chD = new ClientHistoryData(_db);
            List<PointOfInterest> ans = new List<PointOfInterest>();
            List<PointOfInterestDataModel> points = chD.getHistoryFromClient((string)TempData.Peek("email"));
            if (points.Count > 0)
            {
                PointOfInterestCategoryData pcd = new PointOfInterestCategoryData(_db);
                foreach (PointOfInterestDataModel pid in points)
                {
                    PointOfInterest p = new PointOfInterest(pid.ID, pid.Name, pid.Images, pid.Lat, pid.Long,
                        pid.isSugestion == 1, pid.Description);
                    List<CategoryDataModel> cats = pcd.getCategoriesFromPointOfInterest(pid.ID);
                    if(cats.Count > 0)
                        foreach (CategoryDataModel cat in cats)
                        {
                            p.Category = cat.Name;
                        }
                    ans.Add(p);
                }

                return ans;
            }

            return null;
        }

        public IActionResult GetPointsVisited()
        {
            List<PointOfInterest> points = GetHistoryFromClient();
            return View(points);
        }
        public List<PointOfInterest> GetPointsOfInterestFromCategoryDB(string category)
        {
            PointOfInterestCategoryData pcD = new PointOfInterestCategoryData(_db);
            PointOfInterestData pd = new PointOfInterestData(_db);
            Category c = new Category(category);
            List<PointOfInterest> ans = new List<PointOfInterest>();
            List<PointOfInterestDataModel> points = pcD.getPointsWithCategory(c.Id);
            List<PointOfInterestDataModel> confPoints = pd.GetPointsOfInterest().Result;
            if (points.Count > 0)
            {
                PointOfInterestCategoryData pcd = new PointOfInterestCategoryData(_db);
                foreach (PointOfInterestDataModel pid in points)
                {
                    if (confPoints.Contains(pid))
                    {
                        PointOfInterest p = new PointOfInterest(pid.ID, pid.Name, pid.Images, pid.Lat, pid.Long,
                            pid.isSugestion == 1, pid.Description);
                        List<CategoryDataModel> cats = pcd.getCategoriesFromPointOfInterest(pid.ID);
                        if (cats.Count > 0)
                            foreach (CategoryDataModel cat in cats)
                            {
                                p.Category = cat.Name;
                            }

                        ans.Add(p);
                    }
                }

                return ans;
            }
            return null;
        }

        public IActionResult GetPointsOfInterestFromCategory(string category)
        {
            List<PointOfInterest> points = GetPointsOfInterestFromCategoryDB(category);
            return View("GetPointsOfInterest", points);
        }
           
        public IActionResult SuggestPointOfInterest()
        {
            return View();
        }

        public async Task<bool> AddPointOfInterestSugestionToDB(PointOfInterestDataModel pidm, int categoryId)
        {
            PointOfInterestData pid = new PointOfInterestData(_db);
            PointOfInterestCategoryData picd = new PointOfInterestCategoryData(_db);
            if (pidm.Description != null)
                await pid.InsertPointOfInterestSugestion(pidm);
            else await pid.InsertPointOfInterestSugestionWithoutDescription(pidm);
            List<PointOfInterestDataModel> insertedPoint = pid.GetPointOfInterestWithAllFields(pidm).Result;
            foreach (PointOfInterestDataModel pID in insertedPoint)
            {
                await picd.InsertCategory(new PointOfInterestCategoryDataModel(categoryId, pID.ID));
            }
            return true;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SuggestPointOfInterest(PointOfInterestSugestion p)
        {
            if (ModelState.IsValid)
            {
                Category c = new Category(p.Category);
                PointOfInterestDataModel pidm =
                    new PointOfInterestDataModel(-1, p.Name, null, p.Lat, p.Long, 1, p.Description);
                bool b1 = AddPointOfInterestSugestionToDB(pidm, c.Id).Result;
                ViewBag.result = (b1 ? "Submetida com sucesso" : "Erro");
                if (b1) return RedirectToAction("Index");
                else return View();
            }
            ViewBag.result = "Campos inválidos";
            return View();
        }

        public IActionResult LoggingOut()
        {
            TempData.Remove("email");
            return RedirectToAction("Index", "Home");
        }
    }
}

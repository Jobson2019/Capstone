using Pubcrew.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PubCrew.Controllers
{
    public class BeverageController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Beverage
        public ActionResult Index()
        {
            return View();
        }

        // GET: Beverage/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Beverage/Create
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: Beverage/Create
        [HttpPost]
        public ActionResult Create(Beverage beverage)
        {
            try
            {
                Beverage newBeverage = new Beverage();
                newBeverage.beverageId = beverage.beverageId;
                newBeverage.bevProductLineName = beverage.bevProductLineName;
                newBeverage.brandName = beverage.brandName;
                db.Beverages.Add(newBeverage);
                db.SaveChanges();
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Beverage/Edit/5
        public ActionResult Edit(int id)
        {
           
            return View();
        }

        // POST: Beverage/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Beverage/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Beverage/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

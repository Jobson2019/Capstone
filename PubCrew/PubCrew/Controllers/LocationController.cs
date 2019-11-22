using Pubcrew.Models;
using PubCrew.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace PubCrew.Controllers
{
    public class LocationController : Controller
    {
         ApplicationDbContext db;
        public LocationController()
        {
            db = new ApplicationDbContext();
        }

        
        
         
        
        

        
        // GET: Location
        public ActionResult Index()
        {

            return View();
        }

        // GET: Location/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Location/Create
        public ActionResult Create()
        {
            ViewBag.Name = new SelectList(db.Locations.Where(l => !l.locationName.Contains("")).ToList(), "locationName", "LocationId");
            return View();
        }

        // POST: Location/Create
        [HttpPost]
        public ActionResult Create(Location location)
        {
            
            try
            {
                Location newLocation = new Location();
                // TODO: Add insert logic here
                newLocation.locationName = location.locationName;
                newLocation.LocationId = location.LocationId;
                newLocation.BusinessId = location.BusinessId;
                db.Locations.Add(newLocation);
                db.SaveChanges();

                return RedirectToAction("Index","Business");
            }
            catch
            {
                return View();
            }
        }

        // GET: Location/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.Name1 = new SelectList(db.Locations.ToList(), "locationName","LocationId");
            Location location = new Location();
            location = db.Locations.Where(e => e.LocationId == id).SingleOrDefault();
            //addto
            return PartialView();
        }

        // POST: Location/Edit/5
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

        // GET: Location/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Location/Delete/5
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

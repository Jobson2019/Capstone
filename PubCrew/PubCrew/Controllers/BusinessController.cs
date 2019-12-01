using Microsoft.AspNet.Identity;
using Pubcrew.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PubCrew.Controllers
{
    [Authorize]
    public class BusinessController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public AppUser GetLoggedInUser()
        {
            string currentId = User.Identity.GetUserId();
            AppUser appUser = db.AppUsers.FirstOrDefault(l => l.ApplicationId == currentId);
            return (appUser);
        }

        public void LoadBusiness()
        {
            LoadAllLocations();
            LoadAllAppUsers();
        }
        public ActionResult LoadAllAppUsers()
        {
            IList<AppUser> users = db.AppUsers.ToList();
            return PartialView("_CurrentAppUsers", users);
        }
        public ActionResult LoadAllLocations()
        {
            
            IList<Location> locations = db.Locations.ToList();
            return PartialView("_EditLocation", locations);
        }
        // GET: Business
        public ActionResult Index()
        {
            LoadBusiness();
            ViewBag.Name1 = new SelectList(db.Locations.ToList(), "locationName", "LocationId");
            AppUser BizOwner = GetLoggedInUser();
            List<AppUser> appUsers = db.AppUsers.Where(a => a.BusinessId == BizOwner.BusinessId && a.UserId != BizOwner.UserId).ToList();
            return View(appUsers);
        }

        // GET: Business/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Business/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Business/Create
        [HttpPost]
        public ActionResult Create([Bind(Include ="OrganizationId,Organization Name")]Business business)
        {
            try
            {
                db.Businesses.Add(business);
                AppUser appUser = new AppUser();
                appUser.ApplicationId = User.Identity.GetUserId();
                appUser.BusinessId = business.BusinessId;
                db.AppUsers.Add(appUser);
                db.SaveChanges();
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Business/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Business/Edit/5
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

        // GET: Business/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Business/Delete/5
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

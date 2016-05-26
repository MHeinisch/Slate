using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Slate_Reborn.Models;

namespace Slate_Reborn.Controllers
{
    public class BusinessInfoesController : Controller
    {
        private Slate_RebornContext db = new Slate_RebornContext();

        // GET: BusinessInfoes
        public ActionResult Index()
        {
            return View(db.BusinessInfoes.ToList());
        }

        // GET: BusinessInfoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BusinessInfo businessInfo = db.BusinessInfoes.Find(id);
            if (businessInfo == null)
            {
                return HttpNotFound();
            }
            return View(businessInfo);
        }

        // GET: BusinessInfoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BusinessInfoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Name,CompanyName,PhoneNumber,Address,Email,Password,ConfirmPassword,UserId")] BusinessInfo businessInfo)
        {
            if (ModelState.IsValid)
            {
                db.BusinessInfoes.Add(businessInfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(businessInfo);
        }

        // GET: BusinessInfoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BusinessInfo businessInfo = db.BusinessInfoes.Find(id);
            if (businessInfo == null)
            {
                return HttpNotFound();
            }
            return View(businessInfo);
        }

        // POST: BusinessInfoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Name,CompanyName,PhoneNumber,Address,Email,Password,ConfirmPassword,UserId")] BusinessInfo businessInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(businessInfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(businessInfo);
        }

        // GET: BusinessInfoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BusinessInfo businessInfo = db.BusinessInfoes.Find(id);
            if (businessInfo == null)
            {
                return HttpNotFound();
            }
            return View(businessInfo);
        }

        // POST: BusinessInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BusinessInfo businessInfo = db.BusinessInfoes.Find(id);
            db.BusinessInfoes.Remove(businessInfo);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

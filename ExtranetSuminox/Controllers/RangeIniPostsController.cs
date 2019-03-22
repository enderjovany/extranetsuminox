using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ExtranetSuminox.Models;

namespace ExtranetSuminox.Controllers
{
    public class RangeIniPostsController : Controller
    {
        private CertificatesContext db = new CertificatesContext();

        // GET: RangeIniPosts
        public ActionResult Index()
        {
            return View(db.RangeIniPosts.ToList());
        }

        // GET: RangeIniPosts/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RangeIniPost rangeIniPost = db.RangeIniPosts.Find(id);
            if (rangeIniPost == null)
            {
                return HttpNotFound();
            }
            return View(rangeIniPost);
        }

        // GET: RangeIniPosts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RangeIniPosts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdRangeIniPost,RangeIni")] RangeIniPost rangeIniPost)
        {
            if (ModelState.IsValid)
            {
                db.RangeIniPosts.Add(rangeIniPost);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(rangeIniPost);
        }

        // GET: RangeIniPosts/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RangeIniPost rangeIniPost = db.RangeIniPosts.Find(id);
            if (rangeIniPost == null)
            {
                return HttpNotFound();
            }
            return View(rangeIniPost);
        }

        // POST: RangeIniPosts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdRangeIniPost,RangeIni")] RangeIniPost rangeIniPost)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rangeIniPost).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rangeIniPost);
        }

        // GET: RangeIniPosts/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RangeIniPost rangeIniPost = db.RangeIniPosts.Find(id);
            if (rangeIniPost == null)
            {
                return HttpNotFound();
            }
            return View(rangeIniPost);
        }

        // POST: RangeIniPosts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            RangeIniPost rangeIniPost = db.RangeIniPosts.Find(id);
            db.RangeIniPosts.Remove(rangeIniPost);
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

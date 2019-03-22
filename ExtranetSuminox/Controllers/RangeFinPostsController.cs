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
    public class RangeFinPostsController : Controller
    {
        private CertificatesContext db = new CertificatesContext();

        // GET: RangeFinPosts
        public ActionResult Index()
        {
            return View(db.RangeFinPosts.ToList());
        }

        // GET: RangeFinPosts/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RangeFinPost rangeFinPost = db.RangeFinPosts.Find(id);
            if (rangeFinPost == null)
            {
                return HttpNotFound();
            }
            return View(rangeFinPost);
        }

        // GET: RangeFinPosts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RangeFinPosts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdRangeFinPost,RangeFin")] RangeFinPost rangeFinPost)
        {
            if (ModelState.IsValid)
            {
                db.RangeFinPosts.Add(rangeFinPost);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(rangeFinPost);
        }

        // GET: RangeFinPosts/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RangeFinPost rangeFinPost = db.RangeFinPosts.Find(id);
            if (rangeFinPost == null)
            {
                return HttpNotFound();
            }
            return View(rangeFinPost);
        }

        // POST: RangeFinPosts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdRangeFinPost,RangeFin")] RangeFinPost rangeFinPost)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rangeFinPost).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rangeFinPost);
        }

        // GET: RangeFinPosts/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RangeFinPost rangeFinPost = db.RangeFinPosts.Find(id);
            if (rangeFinPost == null)
            {
                return HttpNotFound();
            }
            return View(rangeFinPost);
        }

        // POST: RangeFinPosts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            RangeFinPost rangeFinPost = db.RangeFinPosts.Find(id);
            db.RangeFinPosts.Remove(rangeFinPost);
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

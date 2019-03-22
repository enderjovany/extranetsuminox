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
    public class FinishPostsController : Controller
    {
        private CertificatesContext db = new CertificatesContext();

        // GET: FinishPosts
        public ActionResult Index()
        {
            return View(db.FinishPosts.ToList());
        }

        // GET: FinishPosts/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FinishPost finishPost = db.FinishPosts.Find(id);
            if (finishPost == null)
            {
                return HttpNotFound();
            }
            return View(finishPost);
        }

        // GET: FinishPosts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FinishPosts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdFinishPost,Finish")] FinishPost finishPost)
        {
            if (ModelState.IsValid)
            {
                db.FinishPosts.Add(finishPost);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(finishPost);
        }

        // GET: FinishPosts/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FinishPost finishPost = db.FinishPosts.Find(id);
            if (finishPost == null)
            {
                return HttpNotFound();
            }
            return View(finishPost);
        }

        // POST: FinishPosts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdFinishPost,Finish")] FinishPost finishPost)
        {
            if (ModelState.IsValid)
            {
                db.Entry(finishPost).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(finishPost);
        }

        // GET: FinishPosts/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FinishPost finishPost = db.FinishPosts.Find(id);
            if (finishPost == null)
            {
                return HttpNotFound();
            }
            return View(finishPost);
        }

        // POST: FinishPosts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            FinishPost finishPost = db.FinishPosts.Find(id);
            db.FinishPosts.Remove(finishPost);
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

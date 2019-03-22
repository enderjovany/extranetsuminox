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
    public class ProviderTypePostsController : Controller
    {
        private CertificatesContext db = new CertificatesContext();

        // GET: ProviderTypePosts
        public ActionResult Index()
        {
            return View(db.ProviderTypePosts.ToList());
        }

        // GET: ProviderTypePosts/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProviderTypePost providerTypePost = db.ProviderTypePosts.Find(id);
            if (providerTypePost == null)
            {
                return HttpNotFound();
            }
            return View(providerTypePost);
        }

        // GET: ProviderTypePosts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProviderTypePosts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdProviderTypePost,ProviderType")] ProviderTypePost providerTypePost)
        {
            if (ModelState.IsValid)
            {
                db.ProviderTypePosts.Add(providerTypePost);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(providerTypePost);
        }

        // GET: ProviderTypePosts/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProviderTypePost providerTypePost = db.ProviderTypePosts.Find(id);
            if (providerTypePost == null)
            {
                return HttpNotFound();
            }
            return View(providerTypePost);
        }

        // POST: ProviderTypePosts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdProviderTypePost,ProviderType")] ProviderTypePost providerTypePost)
        {
            if (ModelState.IsValid)
            {
                db.Entry(providerTypePost).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(providerTypePost);
        }

        // GET: ProviderTypePosts/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProviderTypePost providerTypePost = db.ProviderTypePosts.Find(id);
            if (providerTypePost == null)
            {
                return HttpNotFound();
            }
            return View(providerTypePost);
        }

        // POST: ProviderTypePosts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            ProviderTypePost providerTypePost = db.ProviderTypePosts.Find(id);
            db.ProviderTypePosts.Remove(providerTypePost);
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

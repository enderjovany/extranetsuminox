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
    public class MaterialTypePostsController : Controller
    {
        private CertificatesContext db = new CertificatesContext();

        // GET: MaterialTypePosts
        public ActionResult Index()
        {
            return View(db.MaterialTypePosts.ToList());
        }

        // GET: MaterialTypePosts/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MaterialTypePost materialTypePost = db.MaterialTypePosts.Find(id);
            if (materialTypePost == null)
            {
                return HttpNotFound();
            }
            return View(materialTypePost);
        }

        // GET: MaterialTypePosts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MaterialTypePosts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdMaterialTypePost,MaterialType")] MaterialTypePost materialTypePost)
        {
            if (ModelState.IsValid)
            {
                db.MaterialTypePosts.Add(materialTypePost);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(materialTypePost);
        }

        // GET: MaterialTypePosts/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MaterialTypePost materialTypePost = db.MaterialTypePosts.Find(id);
            if (materialTypePost == null)
            {
                return HttpNotFound();
            }
            return View(materialTypePost);
        }

        // POST: MaterialTypePosts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdMaterialTypePost,MaterialType")] MaterialTypePost materialTypePost)
        {
            if (ModelState.IsValid)
            {
                db.Entry(materialTypePost).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(materialTypePost);
        }

        // GET: MaterialTypePosts/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MaterialTypePost materialTypePost = db.MaterialTypePosts.Find(id);
            if (materialTypePost == null)
            {
                return HttpNotFound();
            }
            return View(materialTypePost);
        }

        // POST: MaterialTypePosts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            MaterialTypePost materialTypePost = db.MaterialTypePosts.Find(id);
            db.MaterialTypePosts.Remove(materialTypePost);
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

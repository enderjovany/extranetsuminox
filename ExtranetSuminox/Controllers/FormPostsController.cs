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
    public class FormPostsController : Controller
    {
        private CertificatesContext db = new CertificatesContext();

        // GET: FormPosts
        public ActionResult Index()
        {
            return View(db.FormPosts.ToList());
        }

        // GET: FormPosts/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FormPost formPost = db.FormPosts.Find(id);
            if (formPost == null)
            {
                return HttpNotFound();
            }
            return View(formPost);
        }

        // GET: FormPosts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FormPosts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdFormPost,Form")] FormPost formPost)
        {
            if (ModelState.IsValid)
            {
                db.FormPosts.Add(formPost);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(formPost);
        }

        // GET: FormPosts/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FormPost formPost = db.FormPosts.Find(id);
            if (formPost == null)
            {
                return HttpNotFound();
            }
            return View(formPost);
        }

        // POST: FormPosts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdFormPost,Form")] FormPost formPost)
        {
            if (ModelState.IsValid)
            {
                db.Entry(formPost).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(formPost);
        }

        // GET: FormPosts/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FormPost formPost = db.FormPosts.Find(id);
            if (formPost == null)
            {
                return HttpNotFound();
            }
            return View(formPost);
        }

        // POST: FormPosts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            FormPost formPost = db.FormPosts.Find(id);
            db.FormPosts.Remove(formPost);
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

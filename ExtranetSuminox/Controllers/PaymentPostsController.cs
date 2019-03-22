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
    public class PaymentPostsController : Controller
    {
        private CertificatesContext db = new CertificatesContext();

        // GET: PaymentPosts
        public ActionResult Index()
        {
            return View(db.PaymentPosts.ToList());
        }

        // GET: PaymentPosts/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PaymentPost paymentPost = db.PaymentPosts.Find(id);
            if (paymentPost == null)
            {
                return HttpNotFound();
            }
            return View(paymentPost);
        }

        // GET: PaymentPosts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PaymentPosts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdPaymentPost,Payment")] PaymentPost paymentPost)
        {
            if (ModelState.IsValid)
            {
                db.PaymentPosts.Add(paymentPost);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(paymentPost);
        }

        // GET: PaymentPosts/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PaymentPost paymentPost = db.PaymentPosts.Find(id);
            if (paymentPost == null)
            {
                return HttpNotFound();
            }
            return View(paymentPost);
        }

        // POST: PaymentPosts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdPaymentPost,Payment")] PaymentPost paymentPost)
        {
            if (ModelState.IsValid)
            {
                db.Entry(paymentPost).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(paymentPost);
        }

        // GET: PaymentPosts/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PaymentPost paymentPost = db.PaymentPosts.Find(id);
            if (paymentPost == null)
            {
                return HttpNotFound();
            }
            return View(paymentPost);
        }

        // POST: PaymentPosts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            PaymentPost paymentPost = db.PaymentPosts.Find(id);
            db.PaymentPosts.Remove(paymentPost);
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

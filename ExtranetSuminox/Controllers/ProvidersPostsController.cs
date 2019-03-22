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
    public class ProvidersPostsController : Controller
    {
        private CertificatesContext db = new CertificatesContext();

        // GET: ProvidersPosts
        public ActionResult Index()
        {
            var providersPosts = db.ProvidersPosts.Include(p => p.Finish).Include(p => p.FinPost).Include(p => p.Form).Include(p => p.IniPost).Include(p => p.MaterialType).Include(p => p.Payment).Include(p => p.ProviderType);
            return View(providersPosts.ToList());
        }

        // GET: ProvidersPosts/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProvidersPost providersPost = db.ProvidersPosts.Find(id);
            if (providersPost == null)
            {
                return HttpNotFound();
            }
            return View(providersPost);
        }

        // GET: ProvidersPosts/Create
        public ActionResult Create()
        {
            ViewBag.IdFinishPost = new SelectList(db.FinishPosts, "IdFinishPost", "Finish");
            ViewBag.IdRangeFinPost = new SelectList(db.RangeFinPosts, "IdRangeFinPost", "RangeFin");
            ViewBag.IdFormPost = new SelectList(db.FormPosts, "IdFormPost", "Form");
            ViewBag.IdRangeIniPost = new SelectList(db.RangeIniPosts, "IdRangeIniPost", "RangeIni");
            ViewBag.IdMaterialTypePost = new SelectList(db.MaterialTypePosts, "IdMaterialTypePost", "MaterialType");
            ViewBag.IdPaymentPost = new SelectList(db.PaymentPosts, "IdPaymentPost", "Payment");
            ViewBag.IdProviderTypePost = new SelectList(db.ProviderTypePosts, "IdProviderTypePost", "ProviderType");
            return View();
        }

        // POST: ProvidersPosts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdProvidersPost,ProviderNamePost,IdProviderTypePost,contact,email,phone,origin,plant,certificate,web,IdMaterialTypePost,IdFormPost,IdFinishPost,IdRangeIniPost,IdRangeFinPost,IdPaymentPost")] ProvidersPost providersPost)
        {
            if (ModelState.IsValid)
            {
                db.ProvidersPosts.Add(providersPost);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdFinishPost = new SelectList(db.FinishPosts, "IdFinishPost", "Finish", providersPost.IdFinishPost);
            ViewBag.IdRangeFinPost = new SelectList(db.RangeFinPosts, "IdRangeFinPost", "RangeFin", providersPost.IdRangeFinPost);
            ViewBag.IdFormPost = new SelectList(db.FormPosts, "IdFormPost", "Form", providersPost.IdFormPost);
            ViewBag.IdRangeIniPost = new SelectList(db.RangeIniPosts, "IdRangeIniPost", "RangeIni", providersPost.IdRangeIniPost);
            ViewBag.IdMaterialTypePost = new SelectList(db.MaterialTypePosts, "IdMaterialTypePost", "MaterialType", providersPost.IdMaterialTypePost);
            ViewBag.IdPaymentPost = new SelectList(db.PaymentPosts, "IdPaymentPost", "Payment", providersPost.IdPaymentPost);
            ViewBag.IdProviderTypePost = new SelectList(db.ProviderTypePosts, "IdProviderTypePost", "ProviderType", providersPost.IdProviderTypePost);
            return View(providersPost);
        }

        // GET: ProvidersPosts/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProvidersPost providersPost = db.ProvidersPosts.Find(id);
            if (providersPost == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdFinishPost = new SelectList(db.FinishPosts, "IdFinishPost", "Finish", providersPost.IdFinishPost);
            ViewBag.IdRangeFinPost = new SelectList(db.RangeFinPosts, "IdRangeFinPost", "RangeFin", providersPost.IdRangeFinPost);
            ViewBag.IdFormPost = new SelectList(db.FormPosts, "IdFormPost", "Form", providersPost.IdFormPost);
            ViewBag.IdRangeIniPost = new SelectList(db.RangeIniPosts, "IdRangeIniPost", "RangeIni", providersPost.IdRangeIniPost);
            ViewBag.IdMaterialTypePost = new SelectList(db.MaterialTypePosts, "IdMaterialTypePost", "MaterialType", providersPost.IdMaterialTypePost);
            ViewBag.IdPaymentPost = new SelectList(db.PaymentPosts, "IdPaymentPost", "Payment", providersPost.IdPaymentPost);
            ViewBag.IdProviderTypePost = new SelectList(db.ProviderTypePosts, "IdProviderTypePost", "ProviderType", providersPost.IdProviderTypePost);
            return View(providersPost);
        }

        // POST: ProvidersPosts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdProvidersPost,ProviderNamePost,IdProviderTypePost,contact,email,phone,origin,plant,certificate,web,IdMaterialTypePost,IdFormPost,IdFinishPost,IdRangeIniPost,IdRangeFinPost,IdPaymentPost")] ProvidersPost providersPost)
        {
            if (ModelState.IsValid)
            {
                db.Entry(providersPost).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdFinishPost = new SelectList(db.FinishPosts, "IdFinishPost", "Finish", providersPost.IdFinishPost);
            ViewBag.IdRangeFinPost = new SelectList(db.RangeFinPosts, "IdRangeFinPost", "RangeFin", providersPost.IdRangeFinPost);
            ViewBag.IdFormPost = new SelectList(db.FormPosts, "IdFormPost", "Form", providersPost.IdFormPost);
            ViewBag.IdRangeIniPost = new SelectList(db.RangeIniPosts, "IdRangeIniPost", "RangeIni", providersPost.IdRangeIniPost);
            ViewBag.IdMaterialTypePost = new SelectList(db.MaterialTypePosts, "IdMaterialTypePost", "MaterialType", providersPost.IdMaterialTypePost);
            ViewBag.IdPaymentPost = new SelectList(db.PaymentPosts, "IdPaymentPost", "Payment", providersPost.IdPaymentPost);
            ViewBag.IdProviderTypePost = new SelectList(db.ProviderTypePosts, "IdProviderTypePost", "ProviderType", providersPost.IdProviderTypePost);
            return View(providersPost);
        }

        // GET: ProvidersPosts/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProvidersPost providersPost = db.ProvidersPosts.Find(id);
            if (providersPost == null)
            {
                return HttpNotFound();
            }
            return View(providersPost);
        }

        // POST: ProvidersPosts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            ProvidersPost providersPost = db.ProvidersPosts.Find(id);
            db.ProvidersPosts.Remove(providersPost);
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

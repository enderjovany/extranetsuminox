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
    public class CertificatesPostsController : Controller
    {
        private CertificatesContext db = new CertificatesContext();

        // GET: CertificatesPosts
        public ActionResult Index()
        {
            var certificatesPosts = db.CertificatesPosts.Include(c => c.Country).Include(c => c.ProviderNamePost);
            return View(certificatesPosts.ToList());
        }

        // GET: CertificatesPosts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CertificatesPost certificatesPost = db.CertificatesPosts.Find(id);
            if (certificatesPost == null)
            {
                return HttpNotFound();
            }
            return View(certificatesPost);
        }

        // GET: CertificatesPosts/Create
        public ActionResult Create()
        {
            ViewBag.IdPais = new SelectList(db.Paises, "IdPais", "Country");
            ViewBag.IdProvidersPost = new SelectList(db.ProvidersPosts, "IdProvidersPost", "ProviderNamePost");
            return View();
        }

        // POST: CertificatesPosts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IdProvidersPost,Factura,Oc,Colada,Calidad,IdPais,Publicacion,Certificado")] CertificatesPost certificatesPost)
        {
            if (ModelState.IsValid)
            {
                db.CertificatesPosts.Add(certificatesPost);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdPais = new SelectList(db.Paises, "IdPais", "Country", certificatesPost.IdPais);
            ViewBag.IdProvidersPost = new SelectList(db.ProvidersPosts, "IdProvidersPost", "ProviderNamePost", certificatesPost.IdProvidersPost);
            return View(certificatesPost);
        }

        // GET: CertificatesPosts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CertificatesPost certificatesPost = db.CertificatesPosts.Find(id);
            if (certificatesPost == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdPais = new SelectList(db.Paises, "IdPais", "Country", certificatesPost.IdPais);
            ViewBag.IdProvidersPost = new SelectList(db.ProvidersPosts, "IdProvidersPost", "ProviderNamePost", certificatesPost.IdProvidersPost);
            return View(certificatesPost);
        }

        // POST: CertificatesPosts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IdProvidersPost,Factura,Oc,Colada,Calidad,IdPais,Publicacion,Certificado")] CertificatesPost certificatesPost)
        {
            if (ModelState.IsValid)
            {
                db.Entry(certificatesPost).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdPais = new SelectList(db.Paises, "IdPais", "Country", certificatesPost.IdPais);
            ViewBag.IdProvidersPost = new SelectList(db.ProvidersPosts, "IdProvidersPost", "ProviderNamePost", certificatesPost.IdProvidersPost);
            return View(certificatesPost);
        }

        // GET: CertificatesPosts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CertificatesPost certificatesPost = db.CertificatesPosts.Find(id);
            if (certificatesPost == null)
            {
                return HttpNotFound();
            }
            return View(certificatesPost);
        }

        // POST: CertificatesPosts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CertificatesPost certificatesPost = db.CertificatesPosts.Find(id);
            db.CertificatesPosts.Remove(certificatesPost);
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

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Merlin_web_Application.Models;

namespace Merlin_web_Application.Controllers
{
    public class ProductsController : Controller
    {
        private Merlin_DataEntities db = new Merlin_DataEntities();

        // GET: Products
        public ActionResult Index()
        {
            var product = db.Product.Include(p => p.Colour).Include(p => p.Feature).Include(p => p.NeckFinish).Include(p => p.ProductGroup).Include(p => p.Size).Include(p => p.Supplier).Include(p => p.weight);
            return View(product.ToList());
        }

        // GET: Products/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Product.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            ViewBag.ColourID = new SelectList(db.Colour, "ColourID", "ColourName");
            ViewBag.FeatureID = new SelectList(db.Feature, "FeatureID", "FeatureName");
            ViewBag.NeckFinishID = new SelectList(db.NeckFinish, "NeckFinishID", "NeckFinishName");
            ViewBag.ProductGroupID = new SelectList(db.ProductGroup, "ProductGroupID", "StockTypeID");
            ViewBag.SizeID = new SelectList(db.Size, "SizeID", "SizeDescription");
            ViewBag.SupplierID = new SelectList(db.Supplier, "SupplierID", "SupplierName");
            ViewBag.WeightID = new SelectList(db.weight, "WeightID", "WeightDescription");
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProductID,SupplierCode,ProductGroupID,SupplierID,SizeID,NeckFinishID,FeatureID,AECID,ProductName,ProductDescription,PriceUnit,PerPallet,PalletID,Inactive,InactiveNotes,DateCreated,WeightID,ColourID,CostPrice")] Product product)
        {
            if (ModelState.IsValid)
            {
                db.Product.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ColourID = new SelectList(db.Colour, "ColourID", "ColourName", product.ColourID);
            ViewBag.FeatureID = new SelectList(db.Feature, "FeatureID", "FeatureName", product.FeatureID);
            ViewBag.NeckFinishID = new SelectList(db.NeckFinish, "NeckFinishID", "NeckFinishName", product.NeckFinishID);
            ViewBag.ProductGroupID = new SelectList(db.ProductGroup, "ProductGroupID", "StockTypeID", product.ProductGroupID);
            ViewBag.SizeID = new SelectList(db.Size, "SizeID", "SizeDescription", product.SizeID);
            ViewBag.SupplierID = new SelectList(db.Supplier, "SupplierID", "SupplierName", product.SupplierID);
            ViewBag.WeightID = new SelectList(db.weight, "WeightID", "WeightDescription", product.WeightID);
            return View(product);
        }

        // GET: Products/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Product.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            ViewBag.ColourID = new SelectList(db.Colour, "ColourID", "ColourName", product.ColourID);
            ViewBag.FeatureID = new SelectList(db.Feature, "FeatureID", "FeatureName", product.FeatureID);
            ViewBag.NeckFinishID = new SelectList(db.NeckFinish, "NeckFinishID", "NeckFinishName", product.NeckFinishID);
            ViewBag.ProductGroupID = new SelectList(db.ProductGroup, "ProductGroupID", "StockTypeID", product.ProductGroupID);
            ViewBag.SizeID = new SelectList(db.Size, "SizeID", "SizeDescription", product.SizeID);
            ViewBag.SupplierID = new SelectList(db.Supplier, "SupplierID", "SupplierName", product.SupplierID);
            ViewBag.WeightID = new SelectList(db.weight, "WeightID", "WeightDescription", product.WeightID);
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProductID,SupplierCode,ProductGroupID,SupplierID,SizeID,NeckFinishID,FeatureID,AECID,ProductName,ProductDescription,PriceUnit,PerPallet,PalletID,Inactive,InactiveNotes,DateCreated,WeightID,ColourID,CostPrice")] Product product)
        {
            if (ModelState.IsValid)
            {
                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ColourID = new SelectList(db.Colour, "ColourID", "ColourName", product.ColourID);
            ViewBag.FeatureID = new SelectList(db.Feature, "FeatureID", "FeatureName", product.FeatureID);
            ViewBag.NeckFinishID = new SelectList(db.NeckFinish, "NeckFinishID", "NeckFinishName", product.NeckFinishID);
            ViewBag.ProductGroupID = new SelectList(db.ProductGroup, "ProductGroupID", "StockTypeID", product.ProductGroupID);
            ViewBag.SizeID = new SelectList(db.Size, "SizeID", "SizeDescription", product.SizeID);
            ViewBag.SupplierID = new SelectList(db.Supplier, "SupplierID", "SupplierName", product.SupplierID);
            ViewBag.WeightID = new SelectList(db.weight, "WeightID", "WeightDescription", product.WeightID);
            return View(product);
        }

        // GET: Products/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Product.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Product product = db.Product.Find(id);
            db.Product.Remove(product);
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

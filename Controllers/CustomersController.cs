using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Merlin_web_Application.Models;

namespace Merlin_web_Application.Controllers
{
    public class CustomersController : Controller
    {
        private Merlin_DataEntities db = new Merlin_DataEntities();

        // GET: Customers
        public async Task<ActionResult> Index()
        {
            
            return View(await db.Customer.ToListAsync());
        }

        // GET: Customers/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = await db.Customer.FindAsync(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // GET: Customers/Create
        public ActionResult Create()
        {
            ViewBag.CollectionPoint = new SelectList(db.SupplierDepot, "SupplierDepotID", "SupplierName");
            ViewBag.CustomerID = new SelectList(db.Customer, "CustomerID", "CustomerRef");
            ViewBag.CustomerID = new SelectList(db.Customer, "CustomerID", "CustomerRef");
            ViewBag.CustomerID = new SelectList(db.Customer, "CustomerID", "CustomerRef");
            ViewBag.CustomerID = new SelectList(db.Customer, "CustomerID", "CustomerRef");
            ViewBag.CustomerGroupID = new SelectList(db.CustomerGroup, "CustomerGroupID", "CustomerGroupName");
            ViewBag.CustomerTypeID = new SelectList(db.CustomerType, "CustomerTypeID", "CustomerTypeName");
            ViewBag.DealTypeID = new SelectList(db.DealType, "DealTypeID", "DealTypeName");
            ViewBag.PaymentMethodID = new SelectList(db.PaymentMethod, "PaymentMethodID", "PaymentMethodName");
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "CustomerID,CustomerRef,CustomerTypeID,StandardPriceList,DealTypeID,Collection,PaymentMethodID,CustomerNotes,CustomerComments,CustomerName,CustomerVATNumber,ContactName,ContactTelephone,ContactEmail,OnHold,DateonHold,OnHoldReason,TermsDiscountPercentage,Active,CustomerGroupID,CollectionPoint")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                db.Customer.Add(customer);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.CollectionPoint = new SelectList(db.SupplierDepot, "SupplierDepotID", "SupplierName", customer.CollectionPoint);
            ViewBag.CustomerID = new SelectList(db.Customer, "CustomerID", "CustomerRef", customer.CustomerID);
            ViewBag.CustomerID = new SelectList(db.Customer, "CustomerID", "CustomerRef", customer.CustomerID);
            ViewBag.CustomerID = new SelectList(db.Customer, "CustomerID", "CustomerRef", customer.CustomerID);
            ViewBag.CustomerID = new SelectList(db.Customer, "CustomerID", "CustomerRef", customer.CustomerID);
            ViewBag.CustomerGroupID = new SelectList(db.CustomerGroup, "CustomerGroupID", "CustomerGroupName", customer.CustomerGroupID);
            ViewBag.CustomerTypeID = new SelectList(db.CustomerType, "CustomerTypeID", "CustomerTypeName", customer.CustomerTypeID);
            ViewBag.DealTypeID = new SelectList(db.DealType, "DealTypeID", "DealTypeName", customer.DealTypeID);
            ViewBag.PaymentMethodID = new SelectList(db.PaymentMethod, "PaymentMethodID", "PaymentMethodName", customer.PaymentMethodID);
            return View(customer);
        }

        // GET: Customers/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = await db.Customer.FindAsync(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            ViewBag.CollectionPoint = new SelectList(db.SupplierDepot, "SupplierDepotID", "SupplierName", customer.CollectionPoint);
            ViewBag.CustomerID = new SelectList(db.Customer, "CustomerID", "CustomerRef", customer.CustomerID);
            ViewBag.CustomerID = new SelectList(db.Customer, "CustomerID", "CustomerRef", customer.CustomerID);
            ViewBag.CustomerID = new SelectList(db.Customer, "CustomerID", "CustomerRef", customer.CustomerID);
            ViewBag.CustomerID = new SelectList(db.Customer, "CustomerID", "CustomerRef", customer.CustomerID);
            ViewBag.CustomerGroupID = new SelectList(db.CustomerGroup, "CustomerGroupID", "CustomerGroupName", customer.CustomerGroupID);
            ViewBag.CustomerTypeID = new SelectList(db.CustomerType, "CustomerTypeID", "CustomerTypeName", customer.CustomerTypeID);
            ViewBag.DealTypeID = new SelectList(db.DealType, "DealTypeID", "DealTypeName", customer.DealTypeID);
            ViewBag.PaymentMethodID = new SelectList(db.PaymentMethod, "PaymentMethodID", "PaymentMethodName", customer.PaymentMethodID);
            return View(customer);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "CustomerID,CustomerRef,CustomerTypeID,StandardPriceList,DealTypeID,Collection,PaymentMethodID,CustomerNotes,CustomerComments,CustomerName,CustomerVATNumber,ContactName,ContactTelephone,ContactEmail,OnHold,DateonHold,OnHoldReason,TermsDiscountPercentage,Active,CustomerGroupID,CollectionPoint")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customer).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.CollectionPoint = new SelectList(db.SupplierDepot, "SupplierDepotID", "SupplierName", customer.CollectionPoint);
            ViewBag.CustomerID = new SelectList(db.Customer, "CustomerID", "CustomerRef", customer.CustomerID);
            ViewBag.CustomerID = new SelectList(db.Customer, "CustomerID", "CustomerRef", customer.CustomerID);
            ViewBag.CustomerID = new SelectList(db.Customer, "CustomerID", "CustomerRef", customer.CustomerID);
            ViewBag.CustomerID = new SelectList(db.Customer, "CustomerID", "CustomerRef", customer.CustomerID);
            ViewBag.CustomerGroupID = new SelectList(db.CustomerGroup, "CustomerGroupID", "CustomerGroupName", customer.CustomerGroupID);
            ViewBag.CustomerTypeID = new SelectList(db.CustomerType, "CustomerTypeID", "CustomerTypeName", customer.CustomerTypeID);
            ViewBag.DealTypeID = new SelectList(db.DealType, "DealTypeID", "DealTypeName", customer.DealTypeID);
            ViewBag.PaymentMethodID = new SelectList(db.PaymentMethod, "PaymentMethodID", "PaymentMethodName", customer.PaymentMethodID);
            return View(customer);
        }

        // GET: Customers/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = await db.Customer.FindAsync(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Customer customer = await db.Customer.FindAsync(id);
            db.Customer.Remove(customer);
            await db.SaveChangesAsync();
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

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Assignment_2_ASP_MVC_Restaurant.Models;

namespace Assignment_2_ASP_MVC_Restaurant.Controllers
{
    public class DessertsController : Controller
    {
        private RestaurantModel db = new RestaurantModel();

        // GET: Desserts
        public async Task<ActionResult> Index()
        {
            return View(await db.Desserts.ToListAsync());
        }

        // GET: Desserts/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Desserts desserts = await db.Desserts.FindAsync(id);
            if (desserts == null)
            {
                return HttpNotFound();
            }
            return View(desserts);
        }

        // GET: Desserts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Desserts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "DessertsID,DessertsName,DessertsShortDesc,DessertsLongDesc,Price,ThumbUrl,LargeUrl")] Desserts desserts)
        {
            if (ModelState.IsValid)
            {
                db.Desserts.Add(desserts);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(desserts);
        }

        // GET: Desserts/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Desserts desserts = await db.Desserts.FindAsync(id);
            if (desserts == null)
            {
                return HttpNotFound();
            }
            return View(desserts);
        }

        // POST: Desserts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "DessertsID,DessertsName,DessertsShortDesc,DessertsLongDesc,Price,ThumbUrl,LargeUrl")] Desserts desserts)
        {
            if (ModelState.IsValid)
            {
                db.Entry(desserts).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(desserts);
        }

        // GET: Desserts/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Desserts desserts = await db.Desserts.FindAsync(id);
            if (desserts == null)
            {
                return HttpNotFound();
            }
            return View(desserts);
        }

        // POST: Desserts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Desserts desserts = await db.Desserts.FindAsync(id);
            db.Desserts.Remove(desserts);
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

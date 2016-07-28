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
    public class BeveragesController : Controller
    {
        private RestaurantModel db = new RestaurantModel();

        // GET: Beverages
        public async Task<ActionResult> Index()
        {
            return View(await db.Beverages.ToListAsync());
        }

        // GET: Beverages/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Beverages beverages = await db.Beverages.FindAsync(id);
            if (beverages == null)
            {
                return HttpNotFound();
            }
            return View(beverages);
        }

        // GET: Beverages/Create
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Beverages/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "BeveragesID,BeveragesName,BeveragesShortDesc,BeveragesLongDesc,Price,ThumbUrl,LargeUrl")] Beverages beverages)
        {
            if (ModelState.IsValid)
            {
                db.Beverages.Add(beverages);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(beverages);
        }

        // GET: Beverages/Edit/5
        [Authorize]
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Beverages beverages = await db.Beverages.FindAsync(id);
            if (beverages == null)
            {
                return HttpNotFound();
            }
            return View(beverages);
        }

        // POST: Beverages/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "BeveragesID,BeveragesName,BeveragesShortDesc,BeveragesLongDesc,Price,ThumbUrl,LargeUrl")] Beverages beverages)
        {
            if (ModelState.IsValid)
            {
                db.Entry(beverages).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(beverages);
        }

        // GET: Beverages/Delete/5
        [Authorize]
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Beverages beverages = await db.Beverages.FindAsync(id);
            if (beverages == null)
            {
                return HttpNotFound();
            }
            return View(beverages);
        }

        // POST: Beverages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Beverages beverages = await db.Beverages.FindAsync(id);
            db.Beverages.Remove(beverages);
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

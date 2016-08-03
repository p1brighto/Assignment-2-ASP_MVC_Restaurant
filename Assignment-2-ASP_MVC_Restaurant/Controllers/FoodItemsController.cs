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
    [Authorize]
    public class FoodItemsController : Controller
    {
        private FoodModel db = new FoodModel();

        // GET: FoodItems
        public async Task<ActionResult> Index(string type=null)
        {
   
            if (type != null)
            {
              var   foodItems = from a in db.FoodItems
                                where a.FoodType == type
                                select a;
                return View(await foodItems.ToListAsync());
            }
            else
            {
               var foodItems = db.FoodItems.Include(f => f.Food);

                return View(await foodItems.ToListAsync());
            }

        }

        // GET: FoodItems/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FoodItem foodItem = await db.FoodItems.FindAsync(id);
            if (foodItem == null)
            {
                return HttpNotFound();
            }
            return View(foodItem);
        }

        // GET: FoodItems/Create
        public ActionResult Create()
        {
            ViewBag.FoodType = new SelectList(db.Foods, "FoodType", "FoodType");
            return View();
        }

        // POST: FoodItems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "FoodItemID,FoodItemName,FoodType,ShortDesc,LongDesc,Price,ImageUrl")] FoodItem foodItem)
        {
            if (ModelState.IsValid)
            {
                db.FoodItems.Add(foodItem);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.FoodType = new SelectList(db.Foods, "FoodType", "FoodType", foodItem.FoodType);
            return View(foodItem);
        }

        // GET: FoodItems/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FoodItem foodItem = await db.FoodItems.FindAsync(id);
            if (foodItem == null)
            {
                return HttpNotFound();
            }
            ViewBag.FoodType = new SelectList(db.Foods, "FoodType", "FoodType", foodItem.FoodType);
            return View(foodItem);
        }

        // POST: FoodItems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "FoodItemID,FoodItemName,FoodType,ShortDesc,LongDesc,Price,ImageUrl")] FoodItem foodItem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(foodItem).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.FoodType = new SelectList(db.Foods, "FoodType", "FoodType", foodItem.FoodType);
            return View(foodItem);
        }

        // GET: FoodItems/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FoodItem foodItem = await db.FoodItems.FindAsync(id);
            if (foodItem == null)
            {
                return HttpNotFound();
            }
            return View(foodItem);
        }

        // POST: FoodItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            FoodItem foodItem = await db.FoodItems.FindAsync(id);
            db.FoodItems.Remove(foodItem);
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

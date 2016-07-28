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
    public class Main_CourseController : Controller
    {
        private RestaurantModel db = new RestaurantModel();

        // GET: Main_Course
        public async Task<ActionResult> Index()
        {
            return View(await db.Main_Course.ToListAsync());
        }

        // GET: Main_Course/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Main_Course main_Course = await db.Main_Course.FindAsync(id);
            if (main_Course == null)
            {
                return HttpNotFound();
            }
            return View(main_Course);
        }

        // GET: Main_Course/Create
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Main_Course/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Main_CourseID,Main_CourseName,Main_CourseShortDesc,Main_CourseLongDesc,Price,ImageUrl")] Main_Course main_Course)
        {
            if (ModelState.IsValid)
            {
                db.Main_Course.Add(main_Course);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(main_Course);
        }

        // GET: Main_Course/Edit/5
        [Authorize]
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Main_Course main_Course = await db.Main_Course.FindAsync(id);
            if (main_Course == null)
            {
                return HttpNotFound();
            }
            return View(main_Course);
        }

        // POST: Main_Course/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Main_CourseID,Main_CourseName,Main_CourseShortDesc,Main_CourseLongDesc,Price,ImageUrl")] Main_Course main_Course)
        {
            if (ModelState.IsValid)
            {
                db.Entry(main_Course).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(main_Course);
        }

        // GET: Main_Course/Delete/5
        [Authorize]
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Main_Course main_Course = await db.Main_Course.FindAsync(id);
            if (main_Course == null)
            {
                return HttpNotFound();
            }
            return View(main_Course);
        }

        // POST: Main_Course/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Main_Course main_Course = await db.Main_Course.FindAsync(id);
            db.Main_Course.Remove(main_Course);
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

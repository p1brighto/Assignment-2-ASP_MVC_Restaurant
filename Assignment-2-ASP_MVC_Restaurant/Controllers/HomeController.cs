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

/**
 * @author: Brighto Paul,Kuldeepsingh Jeewoololl
 * @date: July 27, 2016
 * version:1.0
 * Description:
 */


namespace Assignment_2_ASP_MVC_Restaurant.Controllers
{
    public class HomeController : Controller
    {
       FoodModel db = new FoodModel();

        // GET: Index
        public ActionResult Index()
        {
            List<Food> foods = db.Foods.ToList();

            return View(foods);
        }
        // GET: FoodItems
        public async Task<ActionResult> Browse(string type = "Appetizers")
        {
            var foodItems = from a in db.FoodItems
                            where a.FoodType == type
                            select a;
            ViewBag.Title = type;
            return View(await foodItems.ToListAsync());
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

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
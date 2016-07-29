using Assignment_2_ASP_MVC_Restaurant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment_2_ASP_MVC_Restaurant.Controllers
{
    public class FoodController : Controller
    {
        RestaurantModel storeDB = new RestaurantModel();
        //
        // GET: /Store/
        public ActionResult Index()
        {
            List<Food> food = storeDB.Foods.ToList();

            return View(food);
        }
        //
        // GET: /Store/Browse?genre=Disco
        public ActionResult Browse(string type = "Appetizer")
        {
            // Retrieve Genre and its Associated Albums from database
            Food foodModel = storeDB.Foods.Include("FoodItems").Single(g => g.FoodType == type);

            return View(foodModel);
        }
        //
        // GET: /Store/Details/5
        public ActionResult Details(int id = 1)
        {
            FoodItem item = storeDB.FoodItems.Find(id);

            return View(item);
        }
    }
}
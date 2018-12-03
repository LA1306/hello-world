using L5_Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace L5_Data.Controllers
{
    public class HomeController : Controller
    {
        OdeToFoodDb _db = new OdeToFoodDb();

        public ActionResult Index(string searchTerm = null)
        {
            // var model = _db.Restaurants.ToList();

            //var model = from r in _db.Restaurants
            //            orderby r.Id descending
            //            select new RestaurantListView
            //            {
            //                Name = r.Name,
            //                City = r.City,
            //                Country = r.Country
            //            };

            var model = _db.Restaurants
                            //.OrderByDescending(r => r.Id)
                            .Where(r => searchTerm == null || r.Name.StartsWith(searchTerm))
                            .Take(10)
                            .Select(r => new RestaurantListView
                                {
                                    Name = r.Name,
                                    City = r.City,
                                    Country = r.Country
                                }
                            );

            return View(model);
            //return View(_db.Restaurants);
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

        protected override void Dispose(bool disposing)
        {
            if (_db != null)
            {
                _db.Dispose();      // clean ??
            }
            base.Dispose(disposing);
        }
    }
}
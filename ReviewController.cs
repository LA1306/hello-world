using L5_Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace L5_Data.Controllers
{
    public class ReviewController : Controller
    {
        OdeToFoodDb db = new OdeToFoodDb();

        // GET: Review
        public ActionResult Index(int id)
        {
            Restaurant restaurant = db.Restaurants.Find(id);
            if (restaurant == null)
            {
                return HttpNotFound();
            }
            return View(restaurant);
        }

        public ActionResult Create(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(RestaurantReview review)
        {
            if (ModelState.IsValid)
            {
                db.Reviews.Add(review);
                db.SaveChanges();
                return RedirectToAction("Index", new { id = review.RestaurantId });
            }

            return View(review);
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

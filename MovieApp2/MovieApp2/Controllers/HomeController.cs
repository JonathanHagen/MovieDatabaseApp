using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc.Ajax;
using System.Web.Mvc;
using MovieApp2.Models;
using System.Dynamic;

namespace MovieApp2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        private MoviesDBEntities _db = new MoviesDBEntities();
        public ActionResult Index()
        {
            return View(_db.Movies1.ToList());
        }

        // GET: Reviews
        private MoviesDBEntities _db2 = new MoviesDBEntities();
        public ActionResult ReviewsPage()
        {
            return View(_db2.Reviews.ToList());
        }

        // GET: Home/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Create([Bind(Exclude = "Id")] Movie movieToCreate)

        {

            if (!ModelState.IsValid)

                return View();

            _db.Movies1.Add(movieToCreate);

            _db.SaveChanges();

            return RedirectToAction("Index");
        }

        // GET: Home/CreateReview
        public ActionResult CreateReview()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult CreateReview([Bind(Exclude = "Id")] Review reviewToCreate)

        {

            if (!ModelState.IsValid)

                return View();

            _db.Reviews.Add(reviewToCreate);

            _db.SaveChanges();

            return RedirectToAction("ReviewsPage");
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Home/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Home/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

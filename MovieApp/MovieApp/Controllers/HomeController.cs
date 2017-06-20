using MovieApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace MovieApp.Controllers
{
    public class HomeController : Controller
    {
        private MoviesDBEntities _entities = new MoviesDBEntities();

        // GET: Home
        public ActionResult Index()
        {
            return View(_entities.Movies1.ToList());
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

            _entities.Movies1.Add(movieToCreate);

            _entities.SaveChanges();

            return View();
        
        }

        // GET: /Home/Edit/5 

        public ActionResult Edit(int id)

        {

            var movieToEdit = (from m in _entities.Movies1

                               where m.Id == id

                               select m).First();

            return View(movieToEdit);

        }

        //

        // POST: /Home/Edit/5 

        [AcceptVerbs(HttpVerbs.Post)]

        public ActionResult Edit(Movie movieToEdit)

        {

            var originalMovie = (from m in _entities.Movies1

                                 where m.Id == movieToEdit.Id

                                 select m).First();

            if (!ModelState.IsValid)

                return View(originalMovie);

//              _entities.ApplyPropertyChanges(originalMovie.EntityKey.EntitySetName, movieToEdit);
//            originalMovie. = movieToEdit.__;
//            _entities.ApplyPropertyChanges(originalMovie.EntityKey.EntitySetName, movieToEdit);

            _entities.SaveChanges();

            return RedirectToAction("Index");

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
        
        // GET: Home/Reviews
        public ActionResult Reviews()
        {
            return View();              // I need this to change visibility of Rating and Comment
        }

        // POST: Home/Reviews
        [HttpPost]
        public ActionResult Reviews([Bind(Exclude = "Id")] Movie movieToCreate)
        {
            if (!ModelState.IsValid)

                return View();

            _entities.Movies1.Add(movieToCreate);

            _entities.SaveChanges();

            return View();

        }
    }
}

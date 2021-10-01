using Microsoft.AspNetCore.Mvc;
using MovieClassLibrary;
using MovieDataAccessLayer;

namespace MovieWebsite.Controllers
{
    public class MovieController : Controller
    {
        public IMovieDataAccess DataAccess { get; set; }

        public MovieController(IMovieDataAccess dataAccess)
        {
            DataAccess = dataAccess;
        }

        // GET: MovieController
        public ActionResult Index()
        {
            return View(DataAccess.GetAll());
        }

        // GET: MovieController/Details/5
        public ActionResult Details(int id)
        {
            return View(DataAccess.GetMovieById(id));
        }

        // GET: MovieController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MovieController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Movie movie)
        {
            try
            {
                DataAccess.AddMovie(movie);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MovieController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(DataAccess.GetMovieById(id));
        }

        // POST: MovieController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Movie movie)
        {
            try
            {
                DataAccess.UpdateMovie(movie);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MovieController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(DataAccess.GetMovieById(id));
        }

        // POST: MovieController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Movie movie)
        {
            try
            {
                DataAccess.DeleteMovie(movie.Id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

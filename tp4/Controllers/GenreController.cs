using Microsoft.AspNetCore.Mvc;
using tp4.Models;
using tp4.Services.ServiceContracts;

namespace tp4.Controllers
{
    [Route("Genre")]
    public class GenresController : Controller
    {
        private readonly IGenreService _genreService;

        public GenresController(IGenreService genreService)
        {
            _genreService = genreService;
        }

        // GET: Genres
        [HttpGet("")]
        public IActionResult Index()
        {
            var genres = _genreService.GetAllGenres();
            return View(genres);
        }

        [HttpGet("{id}")]
        public IActionResult Details(Guid id)
        {
            var genre = _genreService.GetGenreById(id);
            if (genre == null)
            {
                return NotFound();
            }
            return View(genre);
        }

        [HttpGet("Create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("Create")]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Genre genre)
        {
            if (ModelState.IsValid)
            {
                _genreService.AddGenre(genre);
                return RedirectToAction("Index");
            }
            return View(genre);
        }

        [HttpGet("Edit/{id}")]
        public IActionResult Edit(Guid id)
        {
            var genre = _genreService.GetGenreById(id);
            if (genre == null)
            {
                return NotFound();
            }
            return View(genre);
        }

        [HttpPost("Edit/{id}")]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Guid id, Genre genre)
        {
            if (id != genre.Id)
            {
                return BadRequest("Genre ID mismatch.");
            }

            if (ModelState.IsValid)
            {
                _genreService.UpdateGenre(genre);
                return RedirectToAction("Index");
            }
            return View(genre);
        }

        [HttpGet("Delete/{id}")]
        public IActionResult Delete(Guid id)
        {
            var genre = _genreService.GetGenreById(id);
            if (genre == null)
            {
                return NotFound();
            }
            return View(genre);
        }

        [HttpPost("Delete/{id}")]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Guid id)
        {
            _genreService.DeleteGenre(id);
            return RedirectToAction("Index");
        }
    }
}

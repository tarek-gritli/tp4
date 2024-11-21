using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using tp4.Models;
using tp4.Services.ServiceContracts;

namespace tp4.Controllers
{
    [Route("Movie")]
    public class MoviesController
    {
        private readonly IMovieService _movieService;

        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        public IActionResult Index()
        {
            var movies = _movieService.GetAllMovies();

            return View(movies);
        }



    }
}

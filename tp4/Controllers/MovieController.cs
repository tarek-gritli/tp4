using Microsoft.AspNetCore.Mvc;
using tp4.Services.ServiceContracts;

namespace tp4.Controllers
{
    [Route("Movies")]
    public class MovieController : Controller
    {
        private readonly IMovieService _movieService;

        public MovieController(IMovieService movieService)

        {
            _movieService = movieService
        ;
        }

        public IActionResult Index()
        {
            var customers = _movieService.GetAllMovies();

            return View(customers);
        }



    }
}

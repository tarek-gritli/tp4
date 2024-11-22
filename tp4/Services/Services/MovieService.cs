using tp4.Models;
using tp4.Repositories;
using tp4.Services.ServiceContracts;
using System.Linq;


namespace tp4.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;

        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public IEnumerable<Movie> GetAllMovies()
        {
            return _movieRepository.GetAll();
        }

        public IEnumerable<Movie> GetAllMoviesSorted()
        {
            return _movieRepository.GetAll().OrderBy(m => m.Name).ToList();
        }

        public IEnumerable<Movie> GetMoviesByGenre(Guid genreId)
        {
            return _movieRepository.GetMoviesByGenre(genreId);
        }

        public Movie GetMovieById(int id)
        {
            return _movieRepository.GetById(id);
        }

        public void AddMovie(Movie movie)
        {
            _movieRepository.Add(movie);
        }

        public void UpdateMovie(Movie movie)
        {
            _movieRepository.Update(movie);
        }

        public void DeleteMovie(int id)
        {
            _movieRepository.Delete(id);
        }
    }
}

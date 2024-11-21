using tp4.Models;
using tp4.Repositories;
using tp4.Services.ServiceContracts;

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

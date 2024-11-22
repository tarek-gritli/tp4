using tp4.Models;
using tp4.Repositories;

namespace tp4.Services.ServiceContracts
{
    public class GenreService : IGenreService
    {
        private readonly IGenericRepository<Genre> _genreRepository;

        public GenreService(IGenericRepository<Genre> genreRepository)
        {
            _genreRepository = genreRepository;
        }

        public IEnumerable<Genre> GetAllGenres()
        {
            return _genreRepository.GetAll();
        }

        public Genre GetGenreById(Guid id)
        {
            return _genreRepository.GetById(id);

        }

        public void AddGenre(Genre genre)
        {
            if (string.IsNullOrEmpty(genre.Name))
            {
                throw new ArgumentException("Genre name cannot be null or empty.");
            }

            _genreRepository.Add(genre);
        }

        public void UpdateGenre(Genre genre)
        {
            if (genre.Id == Guid.Empty)
            {
                throw new ArgumentException("Genre ID cannot be empty.");
            }

            _genreRepository.Update(genre);
        }

        public void DeleteGenre(Guid id)
        {
            var existingGenre = _genreRepository.GetById(id);
            if (existingGenre != null)
            {
                _genreRepository.Delete(id);
            }

        }
    }
}

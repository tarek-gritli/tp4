using tp4.Models;

namespace tp4.Services.ServiceContracts
{
    public interface IGenreService
    {
        IEnumerable<Genre> GetAllGenres();
        Genre GetGenreById(Guid id);
        void AddGenre(Genre genre);
        void UpdateGenre(Genre genre);
        void DeleteGenre(Guid id);
    }
}

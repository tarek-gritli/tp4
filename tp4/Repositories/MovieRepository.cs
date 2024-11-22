using tp4.Models;

namespace tp4.Repositories
{

    public interface IMovieRepository : IGenericRepository<Movie>
    {
        Movie GetById(int id);

        IEnumerable<Movie> GetMoviesByGenre(Guid genreId);
        void Delete(int id);
    }
    public class MovieRepository : GenericRepository<Movie>, IMovieRepository
    {
        private readonly ApplicationDbContext _db;
        public MovieRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _db = dbContext;
        }

        public Movie GetById(int id)
        {

            return _db.Movies.Find(id);
        }

        public void Delete(int id)
        {
            var movie = _db.Movies.Find(id);
            if (movie != null)
            {
                _db.Movies.Remove(movie);
                _db.SaveChanges();
            }
        }

        public IEnumerable<Movie> GetMoviesByGenre(Guid genreId)
        {
            return _db.Movies.Where(m => m.GenreId == genreId).ToList();
        }
    }
}

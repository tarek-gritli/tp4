using tp4.Models;

namespace tp4.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly ApplicationDbContext _db;
        public MovieRepository(ApplicationDbContext dbContext)
        {
            _db = dbContext;
        }

        public IEnumerable<Movie> GetAll()
        {
            return _db.Movies.ToList();
        }

        public Movie GetById(int id)
        {

            return _db.Movies.Find(id);
        }

        public void Add(Movie movie)
        {
            _db.Movies.Add(movie);
            _db.SaveChanges();
        }

        public void Update(Movie movie)
        {
            _db.Movies.Update(movie);
            _db.SaveChanges();
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
    }
}

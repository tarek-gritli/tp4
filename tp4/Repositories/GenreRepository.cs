using tp4.Models;

namespace tp4.Repositories
{

    public class GenreRepository : GenericRepository<Genre>
    {
        private readonly ApplicationDbContext _db;
        public GenreRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _db = dbContext;
        }

    }
}



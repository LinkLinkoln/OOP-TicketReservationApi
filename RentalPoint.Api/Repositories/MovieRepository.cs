using Microsoft.EntityFrameworkCore;
using TicketBookingApplication.Api.Interfaces.Repositories;
using TicketBookingApplication.Api.Models;

namespace TicketBookingApplication.Api.Repositories
{
    public class MovieRepository : GenericRepository<Movie> , IMovieRepository
    {
        public MovieRepository(ApplicationDbContext context) : base(context)
        {

        }

        public async override Task<Movie?> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            return await _dbSet
               .Include(m => m.Genre)
               .AsNoTracking()
               .FirstOrDefaultAsync(m => m.Id == id, cancellationToken);
        }

        public async override Task<List<Movie>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await _dbSet
               .Include(m => m.Genre)
               .AsNoTracking()
               .ToListAsync(cancellationToken);
        }
    }
}

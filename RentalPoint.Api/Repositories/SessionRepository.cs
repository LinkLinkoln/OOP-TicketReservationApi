using Microsoft.EntityFrameworkCore;
using TicketBookingApplication.Api.Interfaces.Repositories;
using TicketBookingApplication.Api.Models;

namespace TicketBookingApplication.Api.Repositories
{
    public class SessionRepository : GenericRepository<Session> , ISessionRepository
    {
        public SessionRepository(ApplicationDbContext context) : base(context)
        {

        }

        public async override Task<Session?> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            return await _dbSet
                .Include(r => r.Movie)
                .ThenInclude(s => s!.Genre)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.Id == id, cancellationToken);
        }

        public async override Task<List<Session>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await _dbSet
                .Include(s => s.Movie)
                .ThenInclude(m => m!.Genre)
                .AsNoTracking()
                .ToListAsync(cancellationToken);
        }
    }
}

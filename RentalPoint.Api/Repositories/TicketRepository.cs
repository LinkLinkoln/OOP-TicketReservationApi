using Microsoft.EntityFrameworkCore;
using TicketBookingApplication.Api.Interfaces.Repositories;
using TicketBookingApplication.Api.Models;

namespace TicketBookingApplication.Api.Repositories
{
    public class TicketRepository : GenericRepository<Ticket> , ITicketRepository
    {
        public TicketRepository(ApplicationDbContext context) : base(context)
        {

        }

        public override async Task<Ticket?> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            return await _dbSet
                .Include(r => r.Session)
                .ThenInclude(s => s!.Movie)
                .ThenInclude(s => s!.Genre)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.Id == id, cancellationToken);
        }

        public override async Task<List<Ticket>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await _dbSet
                .Include(r => r.Session)
                .ThenInclude(s => s!.Movie)
                .ThenInclude(s => s!.Genre)
                .AsNoTracking()
                .ToListAsync(cancellationToken);
        }

        public async Task<int> CountTicketInSessionAsync(Guid sessionId, CancellationToken cancellationToken)
        {
            return await _dbSet
                .Where(t => t.SessionId == sessionId)
                .CountAsync(cancellationToken);
        }
    }
}

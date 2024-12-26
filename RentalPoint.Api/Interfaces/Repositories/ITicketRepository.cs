using TicketBookingApplication.Api.Models;

namespace TicketBookingApplication.Api.Interfaces.Repositories
{
    public interface ITicketRepository : IGenericRepository<Ticket>
    {
        Task<int> CountTicketInSessionAsync(Guid sessionId, CancellationToken cancellationToken);
    }
}

using TicketBookingApplication.Api.Models;

namespace TicketBookingApplication.Api.Interfaces.Repositories
{
    public interface IClientRepository : IGenericRepository<Client>
    {
        Task<bool> EmailExistsAsync(string email, CancellationToken cancellationToken = default);
    }
}

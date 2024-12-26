using TicketBookingApplication.Api.Interfaces.Repositories;
using TicketBookingApplication.Api.Models;

namespace TicketBookingApplication.Api.Repositories
{
    using Microsoft.EntityFrameworkCore;

    namespace TicketBookingApplication.Api.Repositories
    {
        public class ClientRepository : GenericRepository<Client>, IClientRepository
        {
            public ClientRepository(ApplicationDbContext context) : base(context)
            {
            }

            public async Task<bool> EmailExistsAsync(string email, CancellationToken cancellationToken = default)
            {
                return await _context.Clients
                    .AnyAsync(client => client.Email == email, cancellationToken);
            }


            public async Task<bool> PhoneNumberExistsAsync(string phoneNumber, CancellationToken cancellationToken = default)
            {
                return await _context.Clients
                    .AnyAsync(client => client.PhoneNumber == phoneNumber, cancellationToken);
            }
        }
    }

}

using TicketBookingApplication.Api.Exceptions;
using TicketBookingApplication.Api.Interfaces.Repositories;
using TicketBookingApplication.Api.Interfaces.Services;
using TicketBookingApplication.Api.Models;

namespace TicketBookingApplication.Api.Services
{
    public class ClientService : GenericService<Client>, IClientService
    {
        private new readonly IClientRepository _repository;

        public ClientService(IClientRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public new async Task CreateAsync(Client client, CancellationToken cancellationToken = default)
        {
            if (await _repository.EmailExistsAsync(client.Email, cancellationToken))
            {
                throw new BadRequestException("Email already exists.");
            }
            await _repository.AddAsync(client, cancellationToken);
        }
    }
}

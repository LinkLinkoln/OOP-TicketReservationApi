using TicketBookingApplication.Api.Exceptions;
using TicketBookingApplication.Api.Interfaces.Repositories;
using TicketBookingApplication.Api.Interfaces.Services;
using TicketBookingApplication.Api.Models;
using TicketBookingApplication.Api.Repositories;

namespace TicketBookingApplication.Api.Services
{
    public class TicketService : GenericService<Ticket>, ITicketService
    {
        private readonly IClientRepository _clientRepository;
        private readonly ISessionRepository _sessionRepository;
        private readonly ITicketRepository _ticketRepository;

        public TicketService(
            ITicketRepository repository,
            IClientRepository clientRepository,
            ISessionRepository sessionRepository) : base(repository)
        {
            _clientRepository = clientRepository;
            _sessionRepository = sessionRepository;
            _ticketRepository = repository;
        }

        public override async Task CreateAsync(Ticket model, CancellationToken cancellationToken)
        {
            var session = await _sessionRepository.GetByIdAsync(model.SessionId, cancellationToken)
                ?? throw new NotFoundException("Session with such id doesnt exist");

            var ticketsCount = await _ticketRepository.CountTicketInSessionAsync(model.SessionId, cancellationToken);

            if(session.AvailableQuantity <= ticketsCount)
            {
                throw new BadRequestException("There are no free places");
            }

            _ = await _clientRepository.GetByIdAsync(model.ClientId, cancellationToken)
                ?? throw new NotFoundException("Client with such id doesnt exist");

            await base.CreateAsync(model, cancellationToken);
        }

        public async override Task DeleteAsync(Guid id, CancellationToken cancellationToken)
        {
            _ = await _repository.GetByIdAsync(id, cancellationToken)
                ?? throw new NotFoundException("Ticket with such id doesnt exist");

            await base.DeleteAsync(id, cancellationToken);   
        }
    }
}

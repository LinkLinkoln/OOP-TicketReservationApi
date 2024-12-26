using TicketBookingApplication.Api.Exceptions;
using TicketBookingApplication.Api.Interfaces.Repositories;
using TicketBookingApplication.Api.Interfaces.Services;
using TicketBookingApplication.Api.Models;

namespace TicketBookingApplication.Api.Services
{
    public class SessionService : GenericService<Session>, ISessionService
    {
        private readonly IMovieRepository _movieRepository;

        public SessionService(
            ISessionRepository repository,
            IMovieRepository movieRepository) : base(repository)
        {
            _movieRepository = movieRepository;
        }

        public async override Task CreateAsync(Session model, CancellationToken cancellationToken)
        {
            _ = await _movieRepository.GetByIdAsync(model.MovieId, cancellationToken)
                ?? throw new NotFoundException("Movie with such id doesnt exist");

            await base.CreateAsync(model, cancellationToken);
        }
    }
}

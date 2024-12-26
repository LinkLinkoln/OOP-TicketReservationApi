using TicketBookingApplication.Api.Exceptions;
using TicketBookingApplication.Api.Interfaces.Repositories;
using TicketBookingApplication.Api.Interfaces.Services;
using TicketBookingApplication.Api.Models;

namespace TicketBookingApplication.Api.Services
{
    public class MovieService : GenericService<Movie>, IMovieService
    {
        private readonly IGenreRepository _genreRepository;

        public MovieService(
            IMovieRepository repository,
            IGenreRepository genreRepository) : base(repository)
        {
            _genreRepository = genreRepository;
        }

        public override async Task CreateAsync(Movie model, CancellationToken cancellationToken)
        {
            _ = await _genreRepository.GetByIdAsync(model.GenreId, cancellationToken)
                ?? throw new NotFoundException("Genre with such id doesnt exist");

            await base.CreateAsync(model, cancellationToken);
        }
    }
}

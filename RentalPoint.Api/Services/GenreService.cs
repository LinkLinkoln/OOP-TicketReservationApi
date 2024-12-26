using TicketBookingApplication.Api.Interfaces.Repositories;
using TicketBookingApplication.Api.Interfaces.Services;
using TicketBookingApplication.Api.Models;

namespace TicketBookingApplication.Api.Services
{
    public class GenreService : GenericService<Genre>, IGenreService
    {
        public GenreService(IGenreRepository repository) : base(repository)
        {

        }
    }
}

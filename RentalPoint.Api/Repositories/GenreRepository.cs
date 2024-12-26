using TicketBookingApplication.Api.Interfaces.Repositories;
using TicketBookingApplication.Api.Models;

namespace TicketBookingApplication.Api.Repositories
{
    public class GenreRepository : GenericRepository<Genre> , IGenreRepository
    {
        public GenreRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}

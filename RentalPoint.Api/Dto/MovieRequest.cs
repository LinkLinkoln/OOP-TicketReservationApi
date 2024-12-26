using TicketBookingApplication.Api.Models;

namespace TicketBookingApplication.Api.Dto
{
    public record MovieRequest(
        string Name,
        string Description,
        Guid GenreId);
}

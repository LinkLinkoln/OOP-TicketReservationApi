using TicketBookingApplication.Api.Models;

namespace TicketBookingApplication.Api.Dto
{
    public record SessionResponse(
        Guid Id,
        int Price,
        int AvailableQuantity,
        MovieResponse Movie,
        DateTime StartAt);
}

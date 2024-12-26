using TicketBookingApplication.Api.Models;

namespace TicketBookingApplication.Api.Dto
{
    public record TicketResponse(
        Guid Id,
        SessionResponse Session,
        Guid ClientId);
}

namespace TicketBookingApplication.Api.Dto
{
    public record TicketRequest(
         Guid ClientId,
         Guid SessionId);
}

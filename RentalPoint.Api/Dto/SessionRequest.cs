namespace TicketBookingApplication.Api.Dto
{
    public record SessionRequest(
        int Price,
        int AvailableQuantity,
        Guid MovieId,
        DateTime StartAt);
}

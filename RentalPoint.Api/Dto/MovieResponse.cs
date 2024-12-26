namespace TicketBookingApplication.Api.Dto
{
    public record MovieResponse(
        Guid Id,
        string Name,
        string Description,
        GenreResponse Genre);
}

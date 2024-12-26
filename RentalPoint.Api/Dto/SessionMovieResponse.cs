namespace TicketBookingApplication.Api.Dto
{
    public record SessionMovieResponse(
        Guid Id,
        int Price,
        MovieResponse Movie,
        DateTime StartAt);
}

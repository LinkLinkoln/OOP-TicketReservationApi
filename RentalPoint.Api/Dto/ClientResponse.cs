namespace TicketBookingApplication.Api.Dto
{
    public record ClientResponse(
        Guid Id,
        string FirstName,
        string LastName,
        string Email,
        string PhoneNumber);
}

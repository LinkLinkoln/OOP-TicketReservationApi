using TicketBookingApplication.Api.Abstracts;

namespace TicketBookingApplication.Api.Models
{
    public class Client : BaseModel
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public ICollection<Ticket>? Tickets { get; set; }
    }
}

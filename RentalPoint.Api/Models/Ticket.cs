using TicketBookingApplication.Api.Abstracts;

namespace TicketBookingApplication.Api.Models
{
    public class Ticket : BaseModel
    {
        public Guid ClientId { get; set; }
        public Guid SessionId { get; set; }
        public Client? Client { get; set; }
        public Session? Session { get; set; }
    }
}

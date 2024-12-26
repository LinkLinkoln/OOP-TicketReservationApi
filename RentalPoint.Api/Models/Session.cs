using TicketBookingApplication.Api.Abstracts;

namespace TicketBookingApplication.Api.Models
{
    public class Session : BaseModel
    {
        public DateTime StartAt { get; set; }
        public decimal Price { get; set; }
        public int AvailableQuantity { get; set; }
        public Guid MovieId { get; set; }
        public Movie? Movie { get; set; }
        public List<Ticket> Tickets { get; set; } = [];
    }
}

using TicketBookingApplication.Api.Abstracts;

namespace TicketBookingApplication.Api.Models
{
    public class Genre : BaseModel
    {
        public string Name { get; set; } = string.Empty;
    }
}

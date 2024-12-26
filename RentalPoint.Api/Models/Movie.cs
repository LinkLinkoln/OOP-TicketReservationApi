using TicketBookingApplication.Api.Abstracts;

namespace TicketBookingApplication.Api.Models
{
    public class Movie : BaseModel
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
       
        public Guid GenreId { get; set; }
        public Genre? Genre { get; set; }
        public List<Session> Sessions { get; set; } = [];
    }
}

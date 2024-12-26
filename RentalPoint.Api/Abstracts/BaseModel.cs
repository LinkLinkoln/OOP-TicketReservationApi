using TicketBookingApplication.Api.Interfaces.Entity;

namespace TicketBookingApplication.Api.Abstracts
{
    public class BaseModel : IBaseModel
    {
        public Guid Id { get; set; }
    }
}

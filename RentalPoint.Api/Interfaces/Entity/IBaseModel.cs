namespace TicketBookingApplication.Api.Interfaces.Entity
{
    public interface IBaseModel
    {
        public interface IEntity
        {
            Guid Id { get; set; }
        }
    }
}

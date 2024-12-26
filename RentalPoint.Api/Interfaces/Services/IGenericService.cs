using TicketBookingApplication.Api.Interfaces.Entity;

namespace TicketBookingApplication.Api.Interfaces.Services
{
    public interface IGenericService<TModel>
        where TModel : IBaseModel
    {
        Task CreateAsync(TModel model, CancellationToken cancellationToken);
        Task<TModel> GetByIdAsync(Guid id, CancellationToken cancellationToken);
        Task<List<TModel>> GetAllAsync(CancellationToken cancellationToken);
        Task UpdateAsync(Guid id, TModel model, CancellationToken cancellationToken);
        Task DeleteAsync(Guid id, CancellationToken cancellationToken);
    }
}

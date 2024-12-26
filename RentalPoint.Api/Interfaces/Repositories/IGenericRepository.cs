using TicketBookingApplication.Api.Interfaces.Entity;

namespace TicketBookingApplication.Api.Interfaces.Repositories
{
    public interface IGenericRepository<TEntity>
       where TEntity : IBaseModel
    {
        Task<List<TEntity>> GetAllAsync(CancellationToken cancellationToken);
        Task<TEntity?> GetByIdAsync(Guid id, CancellationToken cancellationToken);
        Task AddAsync(TEntity model, CancellationToken cancellationToken);
        Task UpdateAsync(TEntity model, CancellationToken cancellationToken);
        Task DeleteAsync(TEntity model, CancellationToken cancellationToken);
    }
}

using TicketBookingApplication.Api.Abstracts;
using TicketBookingApplication.Api.Exceptions;
using TicketBookingApplication.Api.Interfaces.Repositories;
using TicketBookingApplication.Api.Interfaces.Services;

namespace TicketBookingApplication.Api.Services
{
    public class GenericService<TModel> : IGenericService<TModel>
        where TModel : BaseModel
    {
        protected IGenericRepository<TModel> _repository;

        public GenericService(IGenericRepository<TModel> repository)
        {
            _repository = repository;
        }

        public virtual async Task CreateAsync(TModel model, CancellationToken cancellationToken)
        {
            await _repository.AddAsync(model, cancellationToken);
        }

        public virtual async Task DeleteAsync(Guid id, CancellationToken cancellationToken)
        {
            var model = await _repository.GetByIdAsync(id, cancellationToken) 
                ?? throw new NotFoundException("Entity with this id doesn't exis");

            await _repository.DeleteAsync(model, cancellationToken);
        }

        public virtual async Task<List<TModel>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await _repository.GetAllAsync(cancellationToken);
        }

        public virtual async Task<TModel> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            return await _repository
                .GetByIdAsync(id, cancellationToken) 
                ?? throw new NotFoundException("Entity with this id doesn't exis");
        }

        public virtual async Task UpdateAsync(Guid id, TModel model, CancellationToken cancellationToken)
        {
            _ = await _repository.GetByIdAsync(id, cancellationToken) 
                ?? throw new NotFoundException("Entity with this id doesn't exist");

            model.Id = id;

            await _repository.UpdateAsync(model, cancellationToken);
        }
    }
}


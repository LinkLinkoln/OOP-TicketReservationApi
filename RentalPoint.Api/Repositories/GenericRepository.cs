using Microsoft.EntityFrameworkCore;
using TicketBookingApplication.Api.Abstracts;
using TicketBookingApplication.Api.Interfaces.Repositories;

namespace TicketBookingApplication.Api.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity>
        where TEntity : BaseModel
    {
        protected readonly ApplicationDbContext _context;
        protected readonly DbSet<TEntity> _dbSet;

        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        public virtual async Task AddAsync(TEntity model, CancellationToken cancellationToken)
        {
            await _dbSet.AddAsync(model, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public virtual async Task DeleteAsync(TEntity model, CancellationToken cancellationToken)
        {
            _dbSet.Remove(model);

            await _context.SaveChangesAsync(cancellationToken);
        }   

        public virtual async Task<List<TEntity>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await _dbSet
                .AsNoTracking()
                .ToListAsync(cancellationToken);
        }

        public virtual async Task<TEntity?> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            return await _dbSet
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.Id == id, cancellationToken);

        }

        public virtual async Task UpdateAsync(TEntity model, CancellationToken cancellationToken)
        {
            _context.Attach(model);
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}

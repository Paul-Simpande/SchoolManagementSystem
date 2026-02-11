using Microsoft.EntityFrameworkCore;
using Sms.Infrastructure.Context;

namespace Sms.Infrastructure.Repositories.StatusBased;



public abstract class BaseStatusRepository<TEntity>
    where TEntity : class
{
    protected readonly SchoolDbContext _context;
    protected readonly DbSet<TEntity> _dbSet;

    protected BaseStatusRepository(SchoolDbContext context)
    {
        _context = context;
        _dbSet = context.Set<TEntity>();
    }

    public virtual async Task<TEntity?> GetByIdAsync(int id)
        => await _dbSet.FindAsync(id);

    public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
        => await _dbSet.ToListAsync();

    public virtual Task AddAsync(TEntity entity)
    {
        _dbSet.Add(entity);
        return _context.SaveChangesAsync();
    }

    public virtual Task UpdateAsync(TEntity entity)
    {
        _dbSet.Update(entity);
        return _context.SaveChangesAsync();
    }

    public virtual Task DeleteAsync(TEntity entity)
    {
        _dbSet.Remove(entity);
        return _context.SaveChangesAsync();
    }
}

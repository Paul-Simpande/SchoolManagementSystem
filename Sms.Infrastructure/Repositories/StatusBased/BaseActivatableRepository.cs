using Sms.Infrastructure.Context;

namespace Sms.Infrastructure.Repositories.StatusBased;

public abstract class BaseActivatableRepository<TEntity>
    : BaseStatusRepository<TEntity>
    where TEntity : class
{
    protected BaseActivatableRepository(SchoolDbContext context)
        : base(context) { }

    public async Task<bool> ActivateAsync(int id)
    {
        var entity = await _dbSet.FindAsync(id);
        if (entity == null) return false;

        var prop = typeof(TEntity).GetProperty("IsActive");
        if (prop == null) return false;

        if ((bool)prop.GetValue(entity)! == false)
        {
            prop.SetValue(entity, true);
            await _context.SaveChangesAsync();
            return true;
        }

        return false;
    }

    public async Task<bool> DeactivateAsync(int id)
    {
        var entity = await _dbSet.FindAsync(id);
        if (entity == null) return false;

        var prop = typeof(TEntity).GetProperty("IsActive");
        if (prop == null) return false;

        if ((bool)prop.GetValue(entity)! == true)
        {
            prop.SetValue(entity, false);
            await _context.SaveChangesAsync();
            return true;
        }

        return false;
    }
}

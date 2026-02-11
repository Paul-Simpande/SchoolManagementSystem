using Sms.Core.Entities;

namespace Sms.Services.Common;

using Sms.Services;
using Sms.Services.CoreTenant;

public abstract class BaseActivatableService<TEntity>
    where TEntity : class
{
    protected readonly dynamic _repo;
    protected readonly AuditLogService _audit;

    protected BaseActivatableService(dynamic repo, AuditLogService audit)
    {
        _repo = repo;
        _audit = audit;
    }

    // CREATE
    public virtual async Task<TEntity> CreateAsync(TEntity entity, int? userId, string name)
    {
        await _repo.AddAsync(entity);
        await _audit.LogAsync(userId, $"Created {typeof(TEntity).Name} '{name}'");
        return entity;
    }

    // READ ALL
    public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
        => await _repo.GetAllAsync();

    // READ SINGLE
    public virtual async Task<TEntity> GetByIdAsync(int id)
        => await _repo.GetByIdAsync(id);

    // UPDATE
    public virtual async Task<TEntity> UpdateAsync(TEntity entity, int? userId, string name)
    {
        await _repo.UpdateAsync(entity);
        await _audit.LogAsync(userId, $"Updated {typeof(TEntity).Name} '{name}'");
        return entity;
    }

    // DELETE
    public virtual async Task<bool> DeleteAsync(int id, int? userId)
    {
        var entity = await _repo.GetByIdAsync(id);
        if (entity == null) return false;

        await _repo.DeleteAsync(entity);
        await _audit.LogAsync(userId, $"Deleted {typeof(TEntity).Name} (ID:{id})");
        return true;
    }

    // ACTIVATE
    public virtual async Task<bool> ActivateAsync(int id, int? userId)
    {
        var changed = await _repo.ActivateAsync(id);
        if (changed)
            await _audit.LogAsync(userId, $"Activated {typeof(TEntity).Name} (ID:{id})");

        return changed;
    }

    // DEACTIVATE
    public virtual async Task<bool> DeactivateAsync(int id, int? userId)
    {
        var changed = await _repo.DeactivateAsync(id);
        if (changed)
            await _audit.LogAsync(userId, $"Deactivated {typeof(TEntity).Name} (ID:{id})");

        return changed;
    }
}

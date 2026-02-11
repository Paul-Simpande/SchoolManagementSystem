namespace Sms.Services.Common;

public abstract class BaseCrudService<TEntity>
{
    protected readonly dynamic _repo;
    protected readonly AuditLogService _audit;

    protected BaseCrudService(dynamic repo, AuditLogService audit)
    {
        _repo = repo;
        _audit = audit;
    }

    public async Task<TEntity> CreateAsync(TEntity entity, int? userId, string name)
    {
        await _repo.AddAsync(entity);
        await _audit.LogAsync(userId, $"Created {typeof(TEntity).Name} '{name}'");
        return entity;
    }

    public async Task<IEnumerable<TEntity>> GetAllAsync()
        => await _repo.GetAllAsync();

    public async Task<bool> DeleteAsync(int id, int? userId)
    {
        var entity = await _repo.GetByIdAsync(id);
        if (entity == null) return false;

        await _repo.DeleteAsync(entity);
        await _audit.LogAsync(userId, $"Deleted {typeof(TEntity).Name} (ID:{id})");
        return true;
    }
}

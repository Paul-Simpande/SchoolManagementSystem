namespace Sms.Core.Interfaces.StatusBased;

public interface IBaseStatusRepository<T>
{
    Task<T?> GetByIdAsync(int id);
    Task<IEnumerable<T>> GetAllAsync();
    Task AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);
    Task<bool> ActivateAsync(int id);
    Task<bool> DeactivateAsync(int id);
}
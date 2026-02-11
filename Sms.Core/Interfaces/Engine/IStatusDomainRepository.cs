using Sms.Core.Entities;

namespace Sms.Core.Interfaces.Engine;

public interface IStatusDomainRepository
{
    Task<StatusDomain?> GetByIdAsync(int id);
    Task<IEnumerable<StatusDomain>> GetAllAsync();
    Task AddAsync(StatusDomain domain);
    Task UpdateAsync(StatusDomain domain);
    Task DeleteAsync(StatusDomain domain);
    Task<bool> ActivateAsync(int id);
    Task<bool> DeactivateAsync(int id);
}

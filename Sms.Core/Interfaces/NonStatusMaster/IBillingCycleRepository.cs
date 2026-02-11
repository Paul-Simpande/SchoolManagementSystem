using Sms.Core.Entities;

namespace Sms.Core.Interfaces.NonStatusMaster;

public interface IBillingCycleRepository
{
    Task<BillingCycle?> GetByIdAsync(int id);
    Task<IEnumerable<BillingCycle>> GetAllAsync();
    Task AddAsync(BillingCycle cycle);
    Task UpdateAsync(BillingCycle cycle);
    Task DeleteAsync(BillingCycle cycle);
    Task<bool> ActivateAsync(int id);
    Task<bool> DeactivateAsync(int id);
}

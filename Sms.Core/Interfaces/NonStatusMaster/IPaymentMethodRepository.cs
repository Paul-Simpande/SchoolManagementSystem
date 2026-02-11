using Sms.Core.Entities;

namespace Sms.Core.Interfaces.NonStatusMaster;

public interface IPaymentMethodRepository
{
    Task<PaymentMethod?> GetByIdAsync(int id);
    Task<IEnumerable<PaymentMethod>> GetAllAsync();
    Task AddAsync(PaymentMethod method);
    Task UpdateAsync(PaymentMethod method);
    Task DeleteAsync(PaymentMethod method);
    Task<bool> ActivateAsync(int id);
    Task<bool> DeactivateAsync(int id);
}

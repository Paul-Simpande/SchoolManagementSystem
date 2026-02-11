using Sms.Core.Entities;

namespace Sms.Core.Interfaces.NonStatusMaster;

public interface ISupplierTypeRepository
{
    Task<SupplierType?> GetByIdAsync(int id);
    Task<IEnumerable<SupplierType>> GetAllAsync();
    Task AddAsync(SupplierType type);
    Task UpdateAsync(SupplierType type);
    Task DeleteAsync(SupplierType type);
}

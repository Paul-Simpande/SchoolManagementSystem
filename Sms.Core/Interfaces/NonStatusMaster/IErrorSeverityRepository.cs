using Sms.Core.Entities;

namespace Sms.Core.Interfaces.NonStatusMaster;

public interface IErrorSeverityRepository
{
    Task<ErrorSeverity?> GetByIdAsync(int id);
    Task<IEnumerable<ErrorSeverity>> GetAllAsync();
    Task AddAsync(ErrorSeverity severity);
    Task UpdateAsync(ErrorSeverity severity);
    Task DeleteAsync(ErrorSeverity severity);
    Task<bool> ActivateAsync(int id);
    Task<bool> DeactivateAsync(int id);
}

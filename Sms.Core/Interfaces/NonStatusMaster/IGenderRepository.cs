using Sms.Core.Entities;

namespace Sms.Core.Interfaces.NonStatusMaster;

public interface IGenderRepository
{
    Task<Gender?> GetByIdAsync(int id);
    Task<IEnumerable<Gender>> GetAllAsync();
    Task AddAsync(Gender gender);
    Task UpdateAsync(Gender gender);
    Task DeleteAsync(Gender gender);
}
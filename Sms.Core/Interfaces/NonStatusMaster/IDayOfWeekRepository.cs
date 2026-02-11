using Sms.Core.Entities;

namespace Sms.Core.Interfaces.NonStatusMaster;

public interface IDayOfWeekRepository
{
    Task<DayOfWeeks?> GetByIdAsync(int id);
    Task<List<DayOfWeeks>> GetAllAsync();
    Task AddAsync(DayOfWeeks day);
    Task UpdateAsync(DayOfWeeks day);
    Task DeleteAsync(DayOfWeeks day);
}

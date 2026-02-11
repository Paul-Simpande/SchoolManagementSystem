using Sms.Core.Entities;

namespace Sms.Core.Interfaces.CoreTenant;



public interface ISchoolRepository
{
    Task<School?> GetByIdAsync(int id);
    Task<IEnumerable<School>> GetAllAsync();
    Task AddAsync(School school);
    Task UpdateAsync(School school);
    Task DeleteAsync(School school);
}
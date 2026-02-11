using Sms.Core.Entities;

namespace Sms.Core.Interfaces.CoreTenant;

public interface ISchoolContactRepository
{
    Task<SchoolContact?> GetByIsAsync(int id);
    Task<IEnumerable<SchoolContact>> GetBySchoolAsync(int schoolId);
    Task AddAsync(SchoolContact schoolContact);
    Task UpdateAsync(SchoolContact schoolContact);
    Task DeleteAsync(SchoolContact schoolContact);
}
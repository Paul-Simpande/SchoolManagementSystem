using Sms.Core.Entities;

namespace Sms.Core.Interfaces.CoreTenant;

public interface IAcademicYearRepository
{
    Task<AcademicYear?> GetByIdAsync(int id);
    Task<IEnumerable<AcademicYear>> GetBySchoolAsync(int schoolId);
    Task AddAsync(AcademicYear year);
    Task UpdateAsync(AcademicYear year);
    Task DeleteAsync(AcademicYear year);
    Task<bool> DeactivateAsync(int id);
    Task<bool> ActivateAsync(int id);
}

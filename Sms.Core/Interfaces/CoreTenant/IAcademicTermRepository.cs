using Sms.Core.Entities;

namespace Sms.Core.Interfaces.CoreTenant;

public interface IAcademicTermRepository
{
    Task<AcademicTerm?> GetByIdAsync(int id);
    Task<IEnumerable<AcademicTerm>> GetByAcademicYearAsync(int academicYearId);
    Task AddAsync(AcademicTerm term);
    Task UpdateAsync(AcademicTerm term);
    Task DeleteAsync(AcademicTerm term);
    Task<bool> ActivateAsync(int id);
    Task<bool> DeactivateAsync(int id);
}

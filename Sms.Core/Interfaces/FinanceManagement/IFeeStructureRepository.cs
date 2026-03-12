using Sms.Core.Entities;

namespace Sms.Core.Interfaces.FinanceManagement;

public interface IFeeStructureRepository
{
    Task AddAsync(FeeStructure feeStructure);

    Task UpdateAsync(FeeStructure feeStructure);

    Task<FeeStructure?> GetById(int feeStructureId);

    Task<IEnumerable<FeeStructure>> GetBySchool(int schoolId);

    Task<IEnumerable<FeeStructure>> GetByAcademicYear(int academicYearId);

    Task DeleteAsync(FeeStructure feeStructure);
}
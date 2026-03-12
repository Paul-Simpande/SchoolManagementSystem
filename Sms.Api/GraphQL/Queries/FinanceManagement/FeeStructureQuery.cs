using Sms.Core.Entities;
using Sms.Services.FinanceManagement;

namespace Sms.Api.GraphQL.Queries.FinanceManagement;

[ExtendObjectType("Query")]
public class FeeStructureQuery
{
    // READ BY SCHOOL
    public Task<IEnumerable<FeeStructure>> FeeStructures(
        int schoolId,
        [Service] FeeStructureService service)
        => service.GetBySchool(schoolId);

    // READ BY ACADEMIC YEAR
    public Task<IEnumerable<FeeStructure>> FeeStructuresByYear(
        int academicYearId,
        [Service] FeeStructureService service)
        => service.GetByAcademicYear(academicYearId);
}
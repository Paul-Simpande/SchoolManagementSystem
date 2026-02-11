using Sms.Services.CoreTenant;

namespace Sms.Api.GraphQL.Queries.CoreTenant;

[ExtendObjectType("Query")]
public class AcademicYearQuery
{
    public Task<IEnumerable<Core.Entities.AcademicYear>> AcademicYears(int id, [Service] AcademicYearService service)
        => service.GetBySchool(id);
    
    public Task<Core.Entities.AcademicYear?> AcademicYear(int id, [Service] AcademicYearService service)
        => service.GetById(id);
}


using Sms.Core.Entities;
using Sms.Services.CoreTenant;

namespace Sms.Api.GraphQL.Queries.CoreTenant;

[ExtendObjectType("Query")]
public class AcademicTermQuery
{
    public Task<IEnumerable<AcademicTerm>> GetAcademicTerms(int id, [Service] AcademicTermService service)
    {
        return service.GetByYear(id);
    }
    
    public Task<AcademicTerm?> GetAcademicTerm(int id, [Service] AcademicTermService service)
    {
        return service.GetById(id);
    }
}
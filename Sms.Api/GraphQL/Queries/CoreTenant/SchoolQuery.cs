using Sms.Services.CoreTenant;
using Sms.Core.Entities;
using HotChocolate;

namespace Sms.Api.GraphQL.Queries.CoreTenant;

[ExtendObjectType("Query")]
public class SchoolQuery
{
    // Get all schools
    public Task<IEnumerable<School>> Schools([Service] SchoolService service)
        => service.GetSchools();

    // Get a single school by ID
    public Task<School?> School(int id, [Service] SchoolService service)
        => service.GetSchool(id);
}
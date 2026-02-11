using Sms.Core.Entities;
using Sms.Services.StatusBased;

namespace Sms.Api.GraphQL.Queries.StatusBased;

[ExtendObjectType("Query")]
public class StudentStatusQuery
{
    public Task<IEnumerable<StudentStatus>> GetStudentStatuses([Service] StudentStatusService service)
    {
        return service.GetAllAsync();
    }
    
    public Task<StudentStatus> GetStudentStatus(int id, [Service] StudentStatusService service)
    {
        return service.GetByIdAsync(id);
    }
}
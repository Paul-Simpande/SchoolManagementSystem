using Sms.Core.Entities;
using Sms.Services.StatusBased;

namespace Sms.Api.GraphQL.Queries.StatusBased;

[ExtendObjectType("Query")]
public class AttendanceStatusQuery
{
    public Task<IEnumerable<AttendanceStatus>> GetAttendanceStatuses([Service] AttendanceStatusService service)
    {
        return service.GetAllAsync();
    }

    public Task<AttendanceStatus> GetAttendanceStatus(int id, [Service] AttendanceStatusService service)
    {
        return service.GetByIdAsync(id);
    }
}
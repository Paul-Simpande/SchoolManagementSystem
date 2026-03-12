using Sms.Core.Entities;
using Sms.Services.AttendanceManagement;

namespace Sms.Api.GraphQL.Queries.AttendanceManagement;

[ExtendObjectType("Query")]
public class AttendanceCorrectionQuery
{
    // GET PENDING CORRECTION REQUESTS
    public Task<IEnumerable<AttendanceCorrection>> PendingAttendanceCorrections(
        [Service] AttendanceCorrectionService service)
        => service.GetPendingRequests();
}
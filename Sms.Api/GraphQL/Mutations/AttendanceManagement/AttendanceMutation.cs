using Sms.Core.Entities;
using Sms.Services.AttendanceManagement;

namespace Sms.Api.GraphQL.Mutations.AttendanceManagement;

[ExtendObjectType("Mutation")]
public class AttendanceMutation
{
    // MARK SINGLE ATTENDANCE
    public Task<Attendance> MarkAttendance(
        Attendance attendance,
        int? createdByUserId,
        [Service] AttendanceService service)
        => service.MarkAttendance(attendance, createdByUserId);

    // MARK BULK ATTENDANCE
    public Task<IEnumerable<Attendance>> MarkBulkAttendance(
        IEnumerable<Attendance> attendanceList,
        int? createdByUserId,
        [Service] AttendanceService service)
        => service.MarkBulkAttendance(attendanceList, createdByUserId);

    // UPDATE
    public Task<Attendance?> UpdateAttendance(
        int id,
        Attendance attendance,
        int? updatedByUserId,
        [Service] AttendanceService service)
        => service.UpdateAttendance(id, attendance, updatedByUserId);
}
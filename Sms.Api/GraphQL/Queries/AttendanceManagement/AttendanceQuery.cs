using Sms.Core.Entities;
using Sms.Services.AttendanceManagement;

namespace Sms.Api.GraphQL.Queries.AttendanceManagement;

[ExtendObjectType("Query")]
public class AttendanceQuery
{
    // GET STUDENT ATTENDANCE
    public Task<IEnumerable<Attendance>> StudentAttendance(
        int studentId,
        [Service] AttendanceService service)
        => service.GetStudentAttendance(studentId);

    // GET CLASSROOM ATTENDANCE
    public Task<IEnumerable<Attendance>> ClassroomAttendance(
        int classroomId,
        [Service] AttendanceService service)
        => service.GetClassroomAttendance(classroomId);

    // GET ATTENDANCE BY DATE
    public Task<IEnumerable<Attendance>> AttendanceByDate(
        DateTime date,
        [Service] AttendanceService service)
        => service.GetAttendanceByDate(date);
}
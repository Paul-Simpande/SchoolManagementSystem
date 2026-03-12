using Sms.Core.Entities;
using Sms.Core.Interfaces.AttendanceManagement;

namespace Sms.Services.AttendanceManagement;

public class AttendanceService
{
    private readonly IAttendanceRepository _repo;
    private readonly AuditLogService _audit;

    public AttendanceService(
        IAttendanceRepository repo,
        AuditLogService audit)
    {
        _repo = repo;
        _audit = audit;
    }

    // MARK SINGLE ATTENDANCE
    public async Task<Attendance> MarkAttendance(
        Attendance attendance,
        int? createdByUserId)
    {
        await _repo.AddAsync(attendance);

        await _audit.LogAsync(
            createdByUserId,
            $"Marked attendance for StudentId {attendance.StudentId}");

        return attendance;
    }

    // MARK BULK ATTENDANCE
    public async Task<IEnumerable<Attendance>> MarkBulkAttendance(
        IEnumerable<Attendance> attendanceList,
        int? createdByUserId)
    {
        await _repo.AddBulkAsync(attendanceList);

        await _audit.LogAsync(
            createdByUserId,
            $"Marked bulk attendance for {attendanceList.Count()} students");

        return attendanceList;
    }

    // READ
    public Task<IEnumerable<Attendance>> GetStudentAttendance(int studentId)
        => _repo.GetByStudent(studentId);

    public Task<IEnumerable<Attendance>> GetClassroomAttendance(int classroomId)
        => _repo.GetByClassroom(classroomId);

    public Task<IEnumerable<Attendance>> GetAttendanceByDate(DateTime date)
        => _repo.GetByDate(date);

    // UPDATE
    public async Task<Attendance?> UpdateAttendance(
        int attendanceId,
        Attendance updated,
        int? updatedByUserId)
    {
        var attendance = await _repo.GetById(attendanceId);
        if (attendance == null) return null;

        attendance.StatusId = updated.StatusId;
        attendance.Remarks = updated.Remarks;

        await _repo.UpdateAsync(attendance);

        await _audit.LogAsync(
            updatedByUserId,
            $"Updated attendance {attendanceId}");

        return attendance;
    }

}
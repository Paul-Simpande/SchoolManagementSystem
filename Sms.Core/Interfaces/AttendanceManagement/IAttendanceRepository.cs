using Sms.Core.Entities;

namespace Sms.Core.Interfaces.AttendanceManagement;

public interface IAttendanceRepository
{
    Task AddAsync(Attendance attendance);

    Task AddBulkAsync(IEnumerable<Attendance> attendanceList);

    Task UpdateAsync(Attendance attendance);

    Task<Attendance?> GetById(int attendanceId);

    Task<IEnumerable<Attendance>> GetByStudent(int studentId);

    Task<IEnumerable<Attendance>> GetByClassroom(int classroomId);

    Task<IEnumerable<Attendance>> GetByDate(DateTime date);

    Task<IEnumerable<Attendance>> GetByStudentAndYear(int studentId, int academicYearId);
}
using Sms.Core.Entities;

namespace Sms.Core.Interfaces.AttendanceManagement;

public interface IAttendanceCorrectionRepository
{
    Task AddAsync(AttendanceCorrection correction);

    Task UpdateAsync(AttendanceCorrection correction);

    Task<AttendanceCorrection?> GetById(int correctionId);

    Task<IEnumerable<AttendanceCorrection>> GetByAttendance(int attendanceId);

    Task<IEnumerable<AttendanceCorrection>> GetPendingRequests();
}
namespace Sms.Core.DTOs.inputs.AttendanceManagement;

public class BulkAttendanceInput
{
    public int TimetableSlotId { get; set; }

    public int AcademicYearId { get; set; }

    public DateTime AttendanceDate { get; set; }

    public List<StudentAttendanceItem> Students { get; set; } = new();
}
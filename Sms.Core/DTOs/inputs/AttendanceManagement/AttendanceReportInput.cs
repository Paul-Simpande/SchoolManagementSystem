namespace Sms.Core.DTOs.inputs.AttendanceManagement;

public class AttendanceReportInput
{
    public int ClassroomId { get; set; }

    public int AcademicYearId { get; set; }

    public int Month { get; set; }

    public int Year { get; set; }
}
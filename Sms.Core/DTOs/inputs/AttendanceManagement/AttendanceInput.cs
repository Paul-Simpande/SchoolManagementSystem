namespace Sms.Core.DTOs.inputs.AttendanceManagement;

public class AttendanceInput
{
    public int StudentId { get; set; }

    public int TimetableSlotId { get; set; }

    public int AcademicYearId { get; set; }

    public int StatusId { get; set; }

    public DateTime AttendanceDate { get; set; }
    public string? Remarks { get; set; }
}
namespace Sms.Core.DTOs.inputs.AttendanceManagement;

public class AttendanceCorrectionInput
{
    public int AttendanceId { get; set; }

    public int AcademicYearId { get; set; }

    public int RequestedBy { get; set; }

    public int StatusId { get; set; }
    public string? Remarks { get; set; }
}
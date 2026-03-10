namespace Sms.Core.DTOs.inputs.PupilsAdmissionManagement;

public class ClassroomInputs
{
    public int SchoolId { get; set; }
    public int AcademicYearId { get; set; }
    public string? ClassroomName { get; set; }
    public int Capacity { get; set; }
}
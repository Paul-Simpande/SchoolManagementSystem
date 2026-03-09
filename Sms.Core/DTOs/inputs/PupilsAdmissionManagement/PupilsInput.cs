namespace Sms.Core.DTOs.inputs.PupilsAdmissionManagement;

public class PupilsInput
{
    public int SchoolId { get; set; }
    public int GenderId { get; set; }
    public int StatusId { get; set; }
    
    public string? AdmissionNumber { get; set; }
    public string? SchoolAssignedNumber { get; set; }
    public string? EczExamNumber { get; set; }
    
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public DateOnly DateOfBirth { get; set; }
}
namespace Sms.Core.DTOs.DTO.CoreTenant;

public class AcademicTermDto
{
    public int AcademicYearId { get; set; }
    public string? TermName { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public bool IsActive { get; set; }
    public int TermId { get; set; }
}
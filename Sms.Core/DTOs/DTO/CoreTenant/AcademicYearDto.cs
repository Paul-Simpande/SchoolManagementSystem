namespace Sms.Core.DTOs.DTO.CoreTenant;

public class AcademicYearDto
{
    public int AcademicYearId { get; set; }
    public int SchoolId { get; set; }
    public string YearName { get; set; } = null!;
    public DateTime StartDate { get; set; } // return DateTime
    public DateTime EndDate { get; set; }   // return DateTime
    public bool? IsActive { get; set; }
}

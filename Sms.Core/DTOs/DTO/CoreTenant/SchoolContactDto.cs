namespace Sms.Core.DTOs.DTO.CoreTenant;

public class SchoolContactDto
{
    public int ContactId { get; set; }
    public int SchoolId { get; set; }
    public string? ContactType { get; set; }
    public string? ContactValue { get; set; }
}
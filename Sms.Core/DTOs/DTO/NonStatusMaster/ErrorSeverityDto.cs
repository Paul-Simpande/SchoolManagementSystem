namespace Sms.Core.DTOs.DTO.NonStatusMaster;

public class ErrorSeverityDto
{
    public int SeverityId { get; set; }
    public string? SeverityName { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool IsActive { get; set; }
}

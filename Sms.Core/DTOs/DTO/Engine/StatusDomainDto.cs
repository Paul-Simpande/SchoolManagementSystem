namespace Sms.Core.DTOs.DTO.Engine;

public class StatusDomainDto
{
    public int DomainId { get; set; }
    public string? DomainName { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool IsActive { get; set; }
}

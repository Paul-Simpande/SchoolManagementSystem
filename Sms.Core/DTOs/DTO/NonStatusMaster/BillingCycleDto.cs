namespace Sms.Core.DTOs.DTO.NonStatusMaster;

public class BillingCycleDto
{
    public int CycleId { get; set; }
    public string? CycleName { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool IsActive { get; set; }
}

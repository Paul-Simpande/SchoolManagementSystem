namespace Sms.Core.DTOs.DTO.StatusBased;

public class PaymentStatusDto
{
    public int StatusId { get; set; }
    public string? StatusName { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool IsActive { get; set; }
}


namespace Sms.Core.DTOs.DTO.NonStatusMaster;

public class PaymentMethodDto
{
    public int PaymentMethodId { get; set; }
    public string? MethodName { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool IsActive { get; set; }
}

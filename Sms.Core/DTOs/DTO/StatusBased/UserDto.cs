namespace Sms.Core.DTOs.DTO.StatusBased;

public class UserStatusDto
{
    public int StatusId { get; set; }
    public string? StatusName { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool IsActive { get; set; }
}

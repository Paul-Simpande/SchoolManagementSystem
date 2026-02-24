namespace Sms.Core.DTOs.DTO.UserAccountManagement;

public class AppUserDto
{
    public int UserId { get; set; }
    public int SchoolId { get; set; }
    public int StatusId { get; set; }

    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string Email { get; set; } = string.Empty;
    public string? Phone { get; set; }
    public int GenderId { get; set; }

    public DateTime CreatedAt { get; set; }
}
namespace Sms.Core.DTOs.inputs.UserAccountManagement;

public class AppUserInput
{
    public int SchoolId { get; set; }
    public int StatusId { get; set; }

    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    
    public int GenderId { get; set; }

    public string Email { get; set; } = string.Empty;
    public string? Phone { get; set; }
}
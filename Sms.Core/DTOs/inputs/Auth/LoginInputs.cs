namespace Sms.Core.DTOs.inputs.Auth;

public class LoginInputs
{
    public string Email { get; set; } = default!;
    public string Password { get; set; } = default!;
}
namespace Sms.Core.DTOs.inputs.StatusBased;

public record CreateUserStatusInput(
    string StatusName,
    bool IsActive
);
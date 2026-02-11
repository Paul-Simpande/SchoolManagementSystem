namespace Sms.Core.DTOs.inputs.StatusBased;

public record CreateRequestStatusInput(
    string StatusName,
    bool IsActive
);

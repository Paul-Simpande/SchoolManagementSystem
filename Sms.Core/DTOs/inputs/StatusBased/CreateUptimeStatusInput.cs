namespace Sms.Core.DTOs.inputs.StatusBased;

public record CreateUptimeStatusInput(
    string StatusName,
    bool IsActive
);

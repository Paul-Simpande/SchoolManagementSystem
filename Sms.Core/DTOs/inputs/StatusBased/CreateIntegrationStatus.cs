namespace Sms.Core.DTOs.inputs.StatusBased;

public record CreateIntegrationStatusInput(
    string StatusName,
    bool IsActive
);

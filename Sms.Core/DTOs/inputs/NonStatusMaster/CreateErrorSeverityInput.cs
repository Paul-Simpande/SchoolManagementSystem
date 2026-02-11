namespace Sms.Core.DTOs.inputs.NonStatusMaster;

public record CreateErrorSeverityInput(
    string SeverityName,
    bool IsActive
);
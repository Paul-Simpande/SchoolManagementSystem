namespace Sms.Core.DTOs.inputs.StatusBased;

public record CreateCorrectionStatusInput(
    string StatusName,
    bool IsActive
);

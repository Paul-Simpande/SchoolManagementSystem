namespace Sms.Core.DTOs.inputs.StatusBased;

public record CreateAdmissionStatusInput(
    string StatusName,
    bool IsActive
);

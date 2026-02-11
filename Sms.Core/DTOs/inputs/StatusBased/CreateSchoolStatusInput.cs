namespace Sms.Core.DTOs.inputs.StatusBased;

public record CreateSchoolStatusInput(
    string StatusName,
    bool IsActive
);

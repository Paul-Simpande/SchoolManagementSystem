namespace Sms.Core.DTOs.inputs.StatusBased;

public record CreateStudentStatusInput(
    string StatusName,
    bool IsActive
);
namespace Sms.Core.DTOs.inputs.StatusBased;

public record CreateBackupStatusInput(
    string StatusName,
    bool IsActive
);
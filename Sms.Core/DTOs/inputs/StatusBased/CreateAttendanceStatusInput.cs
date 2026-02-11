namespace Sms.Core.DTOs.inputs.StatusBased;

public record CreateAttendanceStatusInput(
    string StatusName,
    bool IsActive
);
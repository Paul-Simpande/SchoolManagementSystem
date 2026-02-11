namespace Sms.Core.DTOs.inputs.StatusBased;

public record CreateTicketStatusInput(
    string StatusName,
    bool IsActive
);

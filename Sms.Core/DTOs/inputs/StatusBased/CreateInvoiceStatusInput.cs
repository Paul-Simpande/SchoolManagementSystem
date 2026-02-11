namespace Sms.Core.DTOs.inputs.StatusBased;

public record CreateInvoiceStatusInput(
    string StatusName,
    bool IsActive
);
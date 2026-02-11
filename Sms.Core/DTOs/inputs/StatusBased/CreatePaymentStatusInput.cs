namespace Sms.Core.DTOs.inputs.StatusBased;

public record CreatePaymentStatusInput(
    string StatusName,
    bool IsActive
);

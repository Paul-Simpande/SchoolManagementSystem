namespace Sms.Core.DTOs.inputs.StatusBased;

public record CreatePurchaseOrderStatusInput(
    string StatusName,
    bool IsActive
);

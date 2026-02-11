namespace Sms.Core.DTOs.inputs.StatusBased;

public record CreateSupplierStatusInput(
    string StatusName,
    bool IsActive
);

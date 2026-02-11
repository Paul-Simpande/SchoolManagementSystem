namespace Sms.Core.DTOs.inputs.StatusBased;

public record CreateBudgetStatusInput(
    string StatusName,
    bool IsActive
);

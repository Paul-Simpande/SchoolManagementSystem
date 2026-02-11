namespace Sms.Core.DTOs.inputs.NonStatusMaster;

public record CreateBillingCycleInput(
    string CycleName,
    bool IsActive
);

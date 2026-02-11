namespace Sms.Core.DTOs.inputs.NonStatusMaster;

public record CreatePaymentMethodInput(
    string MethodName,
    bool IsActive
);

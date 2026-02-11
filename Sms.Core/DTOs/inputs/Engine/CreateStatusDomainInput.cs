namespace Sms.Core.DTOs.inputs.Engine;

public record CreateStatusDomainInput(
    string DomainName,
    bool IsActive
);
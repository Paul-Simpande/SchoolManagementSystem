namespace Sms.Core.DTOs.inputs.Engine;

public record CreateStatusTransitionInput(
    int DomainId,
    int FromStatusId,
    int ToStatusId,
    bool RequiresApproval,
    bool IsTerminal
);

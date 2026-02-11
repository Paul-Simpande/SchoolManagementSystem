namespace Sms.Core.DTOs.inputs.Engine;

public record CreateApprovalDecisionInput(
    string DecisionName,
    bool IsActive
);

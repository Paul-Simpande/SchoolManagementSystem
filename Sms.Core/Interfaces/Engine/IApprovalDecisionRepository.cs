using Sms.Core.Entities;

namespace Sms.Core.Interfaces.Engine;

public interface IApprovalDecisionRepository
{
    Task<ApprovalDecision?> GetByIdAsync(int id);
    Task<IEnumerable<ApprovalDecision>> GetAllAsync();
    Task AddAsync(ApprovalDecision decision);
    Task UpdateAsync(ApprovalDecision decision);
    Task DeleteAsync(ApprovalDecision decision);
    Task<bool> ActivateAsync(int id);
    Task<bool> DeactivateAsync(int id);
}
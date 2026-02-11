using Sms.Core.Entities;

namespace Sms.Core.Interfaces.Engine;

public interface IStatusTransitionRepository
{
    Task<StatusTransition?> GetByIdAsync(int id);
    Task<IEnumerable<StatusTransition>> GetByDomainAsync(int domainId);
    Task AddAsync(StatusTransition transition);
    Task DeleteAsync(StatusTransition transition);
}

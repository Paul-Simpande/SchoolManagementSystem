using Sms.Core.Entities;

namespace Sms.Core.Interfaces.UserAccountManagement;

public interface IRoleRepository
{
    Task AddAsync(Role role);
    Task<IEnumerable<Role>> GetAllAsync();
    Task<Role?> GetByRoleIdAsync(int id);
    Task UpdateAsync(Role role);
    Task DeleteAsync(Role role);
    Task<bool> RoleExistsAsync(string inputRole);
}
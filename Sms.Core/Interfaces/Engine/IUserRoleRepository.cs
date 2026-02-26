using Sms.Core.Entities;

namespace Sms.Core.Interfaces.Engine;

public interface IUserRoleRepository
{
    Task<UserRole?> GetByIdAsync(int id);
    Task<IEnumerable<UserRole>> GetAllAsync();
    Task<IEnumerable<UserRole>> GetByUserIdAsync(int userId);
    Task<IEnumerable<UserRole>> GetByRoleIdAsync(int roleId);

    Task<bool> AssignRoleAsync(int userId, int roleId);
    Task<bool> RemoveRoleAsync(int userId, int roleId);

    Task<bool> UserHasRoleAsync(int userId, int roleId);
}
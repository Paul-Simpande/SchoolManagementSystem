using Sms.Core.Entities;
using Sms.Core.Interfaces.Engine;
using Sms.Core.Interfaces.UserAccountManagement;

namespace Sms.Services.Engine;

public class UserRoleService
{
    private readonly IUserRoleRepository _repo;
    private readonly IAppUserRepository _userRepo;
    private readonly IRoleRepository _roleRepo;
    private readonly AuditLogService _auditLogService;

    public UserRoleService(
        IUserRoleRepository repo,
        IAppUserRepository userRepo,
        IRoleRepository roleRepo,
        AuditLogService auditLogService)
    {
        _repo = repo;
        _userRepo = userRepo;
        _roleRepo = roleRepo;
        _auditLogService = auditLogService;
    }

    // ASSIGN ROLE
    public async Task<bool> AssignRole(int userId, int roleId, int? performedByUserId)
    {
        var user = await _userRepo.GetByIdAsync(userId);
        if (user == null)
            throw new Exception("User not found");

        var role = await _roleRepo.GetByRoleIdAsync(roleId);
        if (role == null)
            throw new Exception("Role not found");

        // Multi-tenant safety (Optional but recommended)
        // If roles are school-based, validate here

        var assigned = await _repo.AssignRoleAsync(userId, roleId);

        if (!assigned)
            throw new Exception("User already has this role");

        await _auditLogService.LogAsync(
            performedByUserId,
            $"Assigned Role '{role.RoleName}' to User '{user.Email}'"
        );

        return true;
    }

    // REMOVE ROLE
    public async Task<bool> RemoveRole(int userId, int roleId, int? performedByUserId)
    {
        var user = await _userRepo.GetByIdAsync(userId);
        if (user == null)
            throw new Exception("User not found");

        var role = await _roleRepo.GetByRoleIdAsync(roleId);
        if (role == null)
            throw new Exception("Role not found");

        var removed = await _repo.RemoveRoleAsync(userId, roleId);

        if (!removed)
            throw new Exception("User does not have this role");

        await _auditLogService.LogAsync(
            performedByUserId,
            $"Removed Role '{role.RoleName}' from User '{user.Email}'"
        );

        return true;
    }

    // GET USER ROLES
    public Task<IEnumerable<UserRole>> GetUserRoles(int userId)
        => _repo.GetByUserIdAsync(userId);

    // GET USERS BY ROLE
    public Task<IEnumerable<UserRole>> GetUsersByRole(int roleId)
        => _repo.GetByRoleIdAsync(roleId);

    // CHECK IF USER HAS ROLE
    public Task<bool> UserHasRole(int userId, int roleId)
        => _repo.UserHasRoleAsync(userId, roleId);
}
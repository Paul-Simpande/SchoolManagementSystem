using Sms.Core.Entities;

namespace Sms.Core.Interfaces.UserAccountManagement;


public interface IAppUserRepository
{
    Task AddAsync(AppUser user);
    Task<IEnumerable<AppUser>> GetAllAsync();
    Task<IEnumerable<AppUser>> GetAllBySchool(int schoolId);
    Task<AppUser?> GetByIdAsync(int id);
    Task<AppUser?> GetByEmailAsync(string email);
    Task UpdateAsync(AppUser user);
    Task DeleteAsync(AppUser user);
    Task<bool> EmailExistsAsync(string inputEmail);
}
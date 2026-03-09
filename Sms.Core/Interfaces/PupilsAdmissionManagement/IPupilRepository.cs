using Sms.Core.Entities;

namespace Sms.Core.Interfaces.PupilsAdmissionManagement;

public interface IPupilRepository
{
    Task AddAsync(Student pupil);
    Task<IEnumerable<Student>> GetAllBySchool(int schoolId);
    Task<Student?> GetByUser(int userId);
    Task UpdateAsync(Student pupil);
    Task DeleteAsync(Student pupil);
}
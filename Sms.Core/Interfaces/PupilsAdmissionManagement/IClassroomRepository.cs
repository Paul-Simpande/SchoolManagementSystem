using Sms.Core.Entities;

namespace Sms.Core.Interfaces.PupilsAdmissionManagement;

public interface IClassroomRepository
{
    Task AddAsync (Classroom classroom);
    Task UpdateAsync (Classroom classroom);
    Task<IEnumerable<Classroom>> GetAllBySchoolAsync(int schoolId);
    Task<Classroom?> GetById(int classroomId);
    Task DeleteAsync(Classroom classroom);
}
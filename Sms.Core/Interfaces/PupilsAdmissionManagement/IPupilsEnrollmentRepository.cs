using Sms.Core.Entities;

namespace Sms.Core.Interfaces.PupilsAdmissionManagement;

public interface IPupilsEnrollmentRepository
{
    Task AddAsync(StudentEnrollment enrollment);

    Task UpdateAsync(StudentEnrollment enrollment);

    Task<StudentEnrollment?> GetById(int enrollmentId);

    Task<IEnumerable<StudentEnrollment>> GetByStudent(int studentId);

    Task<IEnumerable<StudentEnrollment>> GetByClassroom(int classroomId);

    Task<StudentEnrollment?> GetByStudentAndYear(int studentId, int academicYearId);

    Task DeleteAsync(StudentEnrollment enrollment);
}
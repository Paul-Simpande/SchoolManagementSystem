using Sms.Core.DTOs.inputs.PupilsAdmissionManagement;
using Sms.Core.Entities;
using Sms.Core.Interfaces.PupilsAdmissionManagement;

namespace Sms.Services.PupilAdmissionManagement;

public class PupilsEnrollmentService
{
    private readonly IPupilsEnrollmentRepository _repo;
    private readonly AuditLogService _audit;

    public PupilsEnrollmentService(IPupilsEnrollmentRepository repo, AuditLogService audit)
    {
        _repo = repo;
        _audit = audit;
    }

    // ENROLL STUDENT
    public async Task<StudentEnrollment?> EnrollStudent(
        PupilsEnrollmentInputs input,
        int? approvedByUserId)
    {
        // Prevent duplicate enrollment in same academic year
        var existing = await _repo.GetByStudentAndYear(
            input.StudentId,
            input.AcademicYearId);

        if (existing != null)
            return null;

        var enrollment = new StudentEnrollment
        {
            StudentId = input.StudentId,
            ClassroomId = input.ClassroomId,
            AcademicYearId = input.AcademicYearId,
            ApprovedBy = approvedByUserId,
            CreatedAt = DateTime.UtcNow
        };

        await _repo.AddAsync(enrollment);

        await _audit.LogAsync(
            approvedByUserId,
            $"Enrolled Student '{input.StudentId}' into Classroom '{input.ClassroomId}'");

        return enrollment;
    }

    // GET STUDENT ENROLLMENT HISTORY
    public Task<IEnumerable<StudentEnrollment>> GetStudentHistory(int studentId)
        => _repo.GetByStudent(studentId);

    // GET STUDENTS IN CLASS
    public Task<IEnumerable<StudentEnrollment>> GetStudentsInClass(int classroomId)
        => _repo.GetByClassroom(classroomId);

    // TRANSFER STUDENT
    public async Task<StudentEnrollment?> TransferStudent(
        int enrollmentId,
        int newClassroomId,
        int? approvedByUserId)
    {
        var enrollment = await _repo.GetById(enrollmentId);

        if (enrollment == null)
            return null;

        enrollment.ClassroomId = newClassroomId;

        await _repo.UpdateAsync(enrollment);

        await _audit.LogAsync(
            approvedByUserId,
            $"Transferred Student '{enrollment.StudentId}' to Classroom '{newClassroomId}'");

        return enrollment;
    }

    // REMOVE ENROLLMENT
    public async Task<bool> RemoveEnrollment(
        int enrollmentId,
        int? deletedByUserId)
    {
        var enrollment = await _repo.GetById(enrollmentId);

        if (enrollment == null)
            return false;

        await _repo.DeleteAsync(enrollment);

        await _audit.LogAsync(
            deletedByUserId,
            $"Removed Student '{enrollment.StudentId}' from Classroom '{enrollment.ClassroomId}'");

        return true;
    }
}
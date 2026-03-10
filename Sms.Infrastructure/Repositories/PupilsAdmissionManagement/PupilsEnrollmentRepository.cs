using Microsoft.EntityFrameworkCore;
using Sms.Core.Entities;
using Sms.Core.Interfaces.PupilsAdmissionManagement;
using Sms.Infrastructure.Context;

namespace Sms.Infrastructure.Repositories.PupilsAdmissionManagement;

public class PupilsEnrollmentRepository : IPupilsEnrollmentRepository
{
    private readonly SchoolDbContext _context;

    public PupilsEnrollmentRepository(SchoolDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(StudentEnrollment enrollment)
    {
        _context.StudentEnrollments.Add(enrollment);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(StudentEnrollment enrollment)
    {
        _context.StudentEnrollments.Update(enrollment);
        await _context.SaveChangesAsync();
    }

    public async Task<StudentEnrollment?> GetById(int enrollmentId)
        => await _context.StudentEnrollments
            .FirstOrDefaultAsync(e => e.EnrollmentId == enrollmentId);

    public async Task<IEnumerable<StudentEnrollment>> GetByStudent(int studentId)
        => await _context.StudentEnrollments
            .Where(e => e.StudentId == studentId)
            .ToListAsync();

    public async Task<IEnumerable<StudentEnrollment>> GetByClassroom(int classroomId)
        => await _context.StudentEnrollments
            .Where(e => e.ClassroomId == classroomId)
            .ToListAsync();

    public async Task<StudentEnrollment?> GetByStudentAndYear(int studentId, int academicYearId)
        => await _context.StudentEnrollments
            .FirstOrDefaultAsync(e =>
                e.StudentId == studentId &&
                e.AcademicYearId == academicYearId);

    public async Task DeleteAsync(StudentEnrollment enrollment)
    {
        _context.StudentEnrollments.Remove(enrollment);
        await _context.SaveChangesAsync();
    }
}
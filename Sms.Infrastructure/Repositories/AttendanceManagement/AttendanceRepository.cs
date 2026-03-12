using Microsoft.EntityFrameworkCore;
using Sms.Core.Entities;
using Sms.Core.Interfaces.AttendanceManagement;
using Sms.Infrastructure.Context;

namespace Sms.Infrastructure.Repositories.AttendanceManagement;

public class AttendanceRepository : IAttendanceRepository
{
    private readonly SchoolDbContext _context;

    public AttendanceRepository(SchoolDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Attendance attendance)
    {
        _context.Attendances.Add(attendance);
        await _context.SaveChangesAsync();
    }

    public async Task AddBulkAsync(IEnumerable<Attendance> attendanceList)
    {
        _context.Attendances.AddRange(attendanceList);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Attendance attendance)
    {
        _context.Attendances.Update(attendance);
        await _context.SaveChangesAsync();
    }

    public async Task<Attendance?> GetById(int attendanceId)
        => await _context.Attendances.FindAsync(attendanceId);

    public async Task<IEnumerable<Attendance>> GetByStudent(int studentId)
        => await _context.Attendances
            .Where(a => a.StudentId == studentId)
            .ToListAsync();

    public async Task<IEnumerable<Attendance>> GetByClassroom(int classroomId)
        => await _context.Attendances
            .Where(a => a.TimetableSlot.ClassroomId == classroomId)
            .ToListAsync();

    public async Task<IEnumerable<Attendance>> GetByDate(DateTime date)
        => await _context.Attendances
            .Where(a => a.AttendanceDate == DateOnly.FromDateTime(date))
            .ToListAsync();

    public async Task<IEnumerable<Attendance>> GetByStudentAndYear(int studentId, int academicYearId)
        => await _context.Attendances
            .Where(a => a.StudentId == studentId && a.AcademicYearId == academicYearId)
            .ToListAsync();
}
using Microsoft.EntityFrameworkCore;
using Sms.Core.Entities;
using Sms.Core.Interfaces.PupilsAdmissionManagement;
using Sms.Infrastructure.Context;

namespace Sms.Infrastructure.Repositories.PupilsAdmissionManagement;

public class ClassroomRepository : IClassroomRepository
{
    private readonly SchoolDbContext _context;

    public ClassroomRepository(SchoolDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Classroom classroom)
    {
        _context.Classrooms.Add(classroom);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Classroom classroom)
    {
        _context.Classrooms.Update(classroom);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<Classroom>> GetAllBySchoolAsync(int schoolId)
        => await _context.Classrooms
            .Where(c => c.SchoolId == schoolId)
            .ToListAsync();

    public async Task<Classroom?> GetById(int classroomId)
        => await _context.Classrooms.FindAsync(classroomId);

    public async Task DeleteAsync(Classroom classroom)
    {
        classroom.IsDeleted = true;
        classroom.DeletedAt = DateTime.UtcNow;
        await _context.SaveChangesAsync();
    }
}
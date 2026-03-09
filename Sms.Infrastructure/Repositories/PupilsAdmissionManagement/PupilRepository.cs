using Microsoft.EntityFrameworkCore;
using Sms.Core.Entities;
using Sms.Core.Interfaces.PupilsAdmissionManagement;
using Sms.Infrastructure.Context;

namespace Sms.Infrastructure.Repositories.PupilsAdmissionManagement;

public class PupilRepository : IPupilRepository
{
    private readonly SchoolDbContext _context;

    public PupilRepository(SchoolDbContext context)
    {
        _context = context;
    }
    public async Task AddAsync(Student pupil)
    {
        _context.Students.Add(pupil);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<Student>> GetAllBySchool(int schoolId)
        => await _context.Students
            .Where(s => s.SchoolId == schoolId)
            .ToListAsync();

    public async Task<Student?> GetByUser(int id)
        => await _context.Students.FindAsync(id);
    
    public async Task UpdateAsync(Student pupil)
    {
        _context.Students.Update(pupil);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Student pupil)
    {
        pupil.IsDeleted = true;
        pupil.DeletedAt = DateTime.Now;
        await _context.SaveChangesAsync();
    }
}
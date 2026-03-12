using Microsoft.EntityFrameworkCore;
using Sms.Core.Entities;
using Sms.Core.Interfaces.AttendanceManagement;
using Sms.Infrastructure.Context;

namespace Sms.Infrastructure.Repositories.AttendanceManagement;

public class AttendanceCorrectionRepository : IAttendanceCorrectionRepository
{
    private readonly SchoolDbContext _context;

    public AttendanceCorrectionRepository(SchoolDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(AttendanceCorrection correction)
    {
        _context.AttendanceCorrections.Add(correction);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(AttendanceCorrection correction)
    {
        _context.AttendanceCorrections.Update(correction);
        await _context.SaveChangesAsync();
    }

    public async Task<AttendanceCorrection?> GetById(int correctionId)
        => await _context.AttendanceCorrections.FindAsync(correctionId);

    public async Task<IEnumerable<AttendanceCorrection>> GetByAttendance(int attendanceId)
        => await _context.AttendanceCorrections
            .Where(c => c.AttendanceId == attendanceId)
            .ToListAsync();

    public async Task<IEnumerable<AttendanceCorrection>> GetPendingRequests()
        => await _context.AttendanceCorrections
            .Where(c => c.StatusId == 1) // example: Pending
            .ToListAsync();
}
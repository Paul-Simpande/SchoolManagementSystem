using Sms.Core.Entities;
using Sms.Core.Interfaces.AttendanceManagement;

namespace Sms.Services.AttendanceManagement;

public class AttendanceCorrectionService
{
    private readonly IAttendanceCorrectionRepository _repo;
    private readonly AuditLogService _audit;

    public AttendanceCorrectionService(
        IAttendanceCorrectionRepository repo,
        AuditLogService audit)
    {
        _repo = repo;
        _audit = audit;
    }

    // CREATE REQUEST
    public async Task<AttendanceCorrection> RequestCorrection(
        AttendanceCorrection correction,
        int? createdByUserId)
    {
        await _repo.AddAsync(correction);

        await _audit.LogAsync(
            createdByUserId,
            $"Requested attendance correction for AttendanceId {correction.AttendanceId}");

        return correction;
    }

    // GET PENDING REQUESTS
    public Task<IEnumerable<AttendanceCorrection>> GetPendingRequests()
        => _repo.GetPendingRequests();

    // APPROVE / REJECT
    public async Task<AttendanceCorrection?> UpdateCorrectionStatus(
        int id,
        int statusId,
        int? updatedByUserId)
    {
        var correction = await _repo.GetById(id);
        if (correction == null) return null;

        correction.StatusId = statusId;

        await _repo.UpdateAsync(correction);

        await _audit.LogAsync(
            updatedByUserId,
            $"Updated correction request {id}");

        return correction;
    }
}
using Sms.Core.Entities;
using Sms.Services.AttendanceManagement;

namespace Sms.Api.GraphQL.Mutations.AttendanceManagement;

[ExtendObjectType("Mutation")]
public class AttendanceCorrectionMutation
{
    // REQUEST CORRECTION
    public Task<AttendanceCorrection> RequestAttendanceCorrection(
        AttendanceCorrection correction,
        int? createdByUserId,
        [Service] AttendanceCorrectionService service)
        => service.RequestCorrection(correction, createdByUserId);

    // UPDATE STATUS (APPROVE / REJECT)
    public Task<AttendanceCorrection?> UpdateAttendanceCorrectionStatus(
        int id,
        int statusId,
        int? updatedByUserId,
        [Service] AttendanceCorrectionService service)
        => service.UpdateCorrectionStatus(id, statusId, updatedByUserId);
}
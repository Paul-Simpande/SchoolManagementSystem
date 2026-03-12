using Sms.Core.DTOs.inputs.FinanceManagement;
using Sms.Core.Entities;
using Sms.Core.Interfaces.FinanceManagement;

namespace Sms.Services.FinanceManagement;

public class FeeStructureService
{
    private readonly IFeeStructureRepository _repo;
    private readonly AuditLogService _audit;

    public FeeStructureService(IFeeStructureRepository repo, AuditLogService audit)
    {
        _repo = repo;
        _audit = audit;
    }

    // CREATE
    public async Task<FeeStructure> CreateFeeStructure(FeeStructureInputs input, int? createdByUserId)
    {
        var fee = new FeeStructure
        {
            SchoolId = input.SchoolId,
            AcademicYearId = input.AcademicYearId,
            FeeType = input.FeeType,
            Amount = input.Amount,
            CreatedAt = DateTime.UtcNow
        };

        await _repo.AddAsync(fee);

        await _audit.LogAsync(
            createdByUserId,
            $"Created Fee Structure '{fee.FeeType}'");

        return fee;
    }

    // READ ALL BY SCHOOL
    public Task<IEnumerable<FeeStructure>> GetBySchool(int schoolId)
        => _repo.GetBySchool(schoolId);

    // READ BY YEAR
    public Task<IEnumerable<FeeStructure>> GetByAcademicYear(int academicYearId)
        => _repo.GetByAcademicYear(academicYearId);

    // UPDATE
    public async Task<FeeStructure?> UpdateFeeStructure(int id, FeeStructureInputs input, int? updatedByUserId)
    {
        var fee = await _repo.GetById(id);
        if (fee == null) return null;

        fee.SchoolId = input.SchoolId;
        fee.AcademicYearId = input.AcademicYearId;
        fee.FeeType = input.FeeType;
        fee.Amount = input.Amount;

        await _repo.UpdateAsync(fee);

        await _audit.LogAsync(
            updatedByUserId,
            $"Updated Fee Structure '{fee.FeeType}'");

        return fee;
    }

    // DELETE
    public async Task<bool> DeleteFeeStructure(int id, int? deletedByUserId)
    {
        var fee = await _repo.GetById(id);
        if (fee == null) return false;

        await _repo.DeleteAsync(fee);

        await _audit.LogAsync(
            deletedByUserId,
            $"Deleted Fee Structure '{fee.FeeType}'");

        return true;
    }
}
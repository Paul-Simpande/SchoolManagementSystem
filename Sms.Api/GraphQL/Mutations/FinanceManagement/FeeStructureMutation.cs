using Sms.Core.DTOs.inputs.FinanceManagement;
using Sms.Core.Entities;
using Sms.Services.FinanceManagement;

namespace Sms.Api.GraphQL.Mutations.FinanceManagement;

[ExtendObjectType("Mutation")]
public class FeeStructureMutation
{
    // CREATE
    public Task<FeeStructure> CreateFeeStructure(
        FeeStructureInputs input,
        int? createdByUserId,
        [Service] FeeStructureService service)
        => service.CreateFeeStructure(input, createdByUserId);

    // UPDATE
    public Task<FeeStructure?> UpdateFeeStructure(
        int id,
        FeeStructureInputs input,
        int? updatedByUserId,
        [Service] FeeStructureService service)
        => service.UpdateFeeStructure(id, input, updatedByUserId);

    // DELETE
    public Task<bool> DeleteFeeStructure(
        int id,
        int? deletedByUserId,
        [Service] FeeStructureService service)
        => service.DeleteFeeStructure(id, deletedByUserId);
}
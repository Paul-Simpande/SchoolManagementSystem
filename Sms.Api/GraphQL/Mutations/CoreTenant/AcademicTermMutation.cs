using Sms.Core.DTOs.DTO.CoreTenant;
using Sms.Core.DTOs.inputs.CoreTenant;
using Sms.Core.Entities;
using Sms.Services.CoreTenant;

namespace Sms.Api.GraphQL.Mutations.CoreTenant;

[ExtendObjectType("Mutation")]
public class AcademicTermMutation
{
    public async Task<AcademicTermDto> CreateAcademicTerm(CreateAcademicTermInput input, int? userId,
        [Service] AcademicTermService service)
    {
        var entity = new AcademicTerm
        {
            AcademicYearId = input.AcademicYearId,
            TermName = input.TermName,
            StartDate = input.StartDate,
            EndDate = input.EndDate,
            IsActive = input.IsActive
        };
        
        var saved = await service.CreateAcademicTerm(entity, userId);
        return new AcademicTermDto()
        {
            TermId = saved.TermId,
            AcademicYearId = saved.AcademicYearId,
            TermName = saved.TermName,
            StartDate = saved.StartDate.ToDateTime(TimeOnly.MinValue), // DateOnly -> DateTime for DTO
            EndDate = saved.EndDate.ToDateTime(TimeOnly.MinValue),     // DateOnly -> DateTime for DTO
            IsActive = saved.IsActive
        };
    }
    
    public Task<AcademicTerm> UpdateAcademicTerm(int id, CreateAcademicTermInput input, int? userId,
        [Service] AcademicTermService service)
    {
        var entity = new AcademicTerm
        {
            AcademicYearId = input.AcademicYearId,
            TermName = input.TermName,
            StartDate = input.StartDate,
            EndDate = input.EndDate,
            IsActive = input.IsActive
        };
        return service.UpdateAcademicTerm(id, entity, userId);
    }

    public Task<bool> DeleteAcademicTerm(int id, int? userId,
        [Service] AcademicTermService service)
    {
        return service.DeleteAcademicTerm(id, userId);
    }
    
    public Task<bool> DeactivateAcademicTerm(
        int id,
        int? userId,
        [Service] AcademicTermService service)
    {
        return service.DeactivateAcademicTerm(id, userId);
    }
    
    
    public Task<bool> ActivateAcademicTerm(
        int id,
        int? userId,
        [Service] AcademicTermService service)
    {
        return service.ActivateAcademicTerm(id, userId);
    }
}

using Sms.Core.DTOs.DTO.CoreTenant;
using Sms.Core.DTOs.inputs.CoreTenant;
using Sms.Core.Entities;
using Sms.Services.CoreTenant;

namespace Sms.Api.GraphQL.Mutations.CoreTenant;

[ExtendObjectType("Mutation")]
public class AcademicYearMutation
{
    public async Task<AcademicYearDto> CreateAcademicYear(CreateAcademicYearInput input, int? userId, 
        [Service] AcademicYearService service)
    {
        var entity = new AcademicYear
        {
            SchoolId = input.SchoolId,
            YearName = input.YearName,
            StartDate = input.StartDate,  // already DateOnly
            EndDate = input.EndDate,      // already DateOnly
            IsActive = input.IsActive,
        };

        var saved = await service.CreateAcademicYear(entity, userId);

        return new AcademicYearDto
        {
            AcademicYearId = saved.AcademicYearId,
            SchoolId = saved.SchoolId,
            YearName = saved.YearName,
            StartDate = saved.StartDate.ToDateTime(TimeOnly.MinValue), // DateOnly -> DateTime for DTO
            EndDate = saved.EndDate.ToDateTime(TimeOnly.MinValue),     // DateOnly -> DateTime for DTO
            IsActive = saved.IsActive
        };
    }


    
    public Task<AcademicYear?> UpdateAcademicYear(
        int id,
        int? userId,
        CreateAcademicYearInput input,
        [Service] AcademicYearService service)
    {
        var year = new AcademicYear
        {
            SchoolId = input.SchoolId,
            YearName = input.YearName,
            StartDate = input.StartDate,  // already DateOnly
            EndDate = input.EndDate,      // already DateOnly
            IsActive = input.IsActive,
        };

        return service.UpdateAcademicYear(id, year, userId);
    }


    
    public Task<bool> DeleteAcademicYear(
        int id,
        int? userId,
        [Service] AcademicYearService service)
    {
        return service.DeleteAcademicYear(id, userId);
    }
    
    
    public Task<bool> DeactivateAcademicYear(
        int id,
        int? userId,
        [Service] AcademicYearService service)
    {
        return service.DeactivateAcademicYear(id, userId);
    }
    
    
    
    public Task<bool> ActivateAcademicYear(
        int id,
        int? userId,
        [Service] AcademicYearService service)
    {
        return service.ActivateAcademicYear(id, userId);
    }
    
}

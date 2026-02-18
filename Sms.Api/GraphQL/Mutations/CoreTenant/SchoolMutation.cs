using Sms.Core.DTOs.inputs.CoreTenant;
using Sms.Core.Entities;
using Sms.Services.CoreTenant;

namespace Sms.Api.GraphQL.Mutations.CoreTenant;

[ExtendObjectType("Mutation")]
public class SchoolMutation
{
    // CREATE
    public Task<School> CreateSchool(
        CreateSchoolInput input,
        int? userId,
        [Service] SchoolService service)
    {
        var school = new School
        {
            SchoolName = input.SchoolName,
            EmisNumber = input.EmisNumber,
            EczCenterNumber = input.EczCenterNumber,
            SchoolType = input.SchoolType,
            Address = input.Address,
            District = input.District,
            Province = input.Province,
            Country = input.Country,
            LogoPath = input.LogoPath,
            Website = input.Website,
            StatusId = input.StatusId
        };
        return service.CreateSchool(school, userId);
    }

    // UPDATE
    public Task<School?> UpdateSchool(
        int id,
        int? userId,
        CreateSchoolInput input,
        [Service] SchoolService service)
    {
        var updatedSchool = new School
        {
            SchoolName = input.SchoolName,
            EmisNumber = input.EmisNumber,
            EczCenterNumber = input.EczCenterNumber,
            SchoolType = input.SchoolType,
            Address = input.Address,
            District = input.District,
            Province = input.Province,
            Country = input.Country,
            LogoPath = input.LogoPath,
            Website = input.Website,
            StatusId = input.StatusId
        };
        return service.UpdateSchool(id, updatedSchool, userId);
    }

    // DELETE
    public Task<bool> DeleteSchool(
        int id,
        int? userId,
        [Service] SchoolService service)
        => service.DeleteSchool(id, userId);
}



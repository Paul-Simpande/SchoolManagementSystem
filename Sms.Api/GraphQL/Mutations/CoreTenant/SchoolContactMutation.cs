using Sms.Core.DTOs.DTO.CoreTenant;
using Sms.Core.DTOs.inputs.CoreTenant;
using Sms.Core.Entities;
using Sms.Services.CoreTenant;

namespace Sms.Api.GraphQL.Mutations.CoreTenant;

[ExtendObjectType("Mutation")]
public class SchoolContactMutation
{
    public async Task<SchoolContactDto> CreateSchoolContact(CreateSchoolContactInput input, int? userId,
        [Service] SchoolContactsService service)
    {
        var entity = new SchoolContact
        {
            SchoolId = input.SchoolId,
            ContactType = input.ContactType,
            ContactValue = input.ContactValue
        };
        
        var saved = await service.CreateSchoolService(entity, userId);

        return new SchoolContactDto
        {
            ContactId = saved.ContactId,
            SchoolId = saved.SchoolId,
            ContactType = saved.ContactType,
            ContactValue = saved.ContactValue
        };
    }


    public Task<SchoolContact?> UpdatedSchoolContact(int schoolId, int? userId,
        CreateSchoolContactInput input,
        [Service] SchoolContactsService service)
    {
        var contact = new SchoolContact
        {
            ContactType = input.ContactType,
            ContactValue = input.ContactValue
        };
        
        return service.UpdateSchoolContact(schoolId, contact, userId);
    }

    public Task<bool> DeleteSchoolContact(int schoolId, int? userId,
        [Service] SchoolContactsService service)
    {
        return service.DeleteSchoolContact(schoolId, userId);

    }

}
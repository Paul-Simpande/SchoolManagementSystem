namespace Sms.Core.DTOs.inputs.CoreTenant;

public record CreateSchoolContactInput(
    int SchoolId, 
    string ContactType, 
    string ContactValue
    );
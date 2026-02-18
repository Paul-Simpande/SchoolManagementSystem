namespace Sms.Core.DTOs.inputs.CoreTenant;

public record CreateSchoolInput(
    string SchoolName,
    string EmisNumber,
    string EczCenterNumber,
    string SchoolType,
    string Address,
    string District,
    string Province,
    string Country,
    string LogoPath,
    string Website,
    int StatusId
);

namespace Sms.Core.DTOs.inputs.CoreTenant;

public record CreateAcademicYearInput(
    int SchoolId,
    string YearName,
    DateOnly StartDate,
    DateOnly EndDate,
    bool IsActive
);

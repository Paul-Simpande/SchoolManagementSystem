namespace Sms.Core.DTOs.inputs.CoreTenant;

public record CreateAcademicTermInput(
    int AcademicYearId,
    string TermName,
    DateOnly StartDate,
    DateOnly EndDate,
    bool IsActive
);
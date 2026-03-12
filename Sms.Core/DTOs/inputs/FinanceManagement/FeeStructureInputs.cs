namespace Sms.Core.DTOs.inputs.FinanceManagement;

public class FeeStructureInputs
{
    public int SchoolId { get; set; }

    public int AcademicYearId { get; set; }

    public string? FeeType { get; set; }

    public decimal Amount { get; set; }
}
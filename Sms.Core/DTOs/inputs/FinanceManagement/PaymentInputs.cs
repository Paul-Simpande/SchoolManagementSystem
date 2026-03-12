namespace Sms.Core.DTOs.inputs.FinanceManagement;

public class PaymentInputs
{
    public int InvoiceId { get; set; }

    public int AcademicYearId { get; set; }

    public int PaymentMethodId { get; set; }

    public decimal Amount { get; set; }
}
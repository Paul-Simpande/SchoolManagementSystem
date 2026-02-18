using Sms.Core.Entities;
using Sms.Core.Interfaces.StatusBased;
using Sms.Services.Common;

namespace Sms.Services.StatusBased;

public class PaymentStatusService :
    BaseActivatableService<PaymentStatus>
{
    public PaymentStatusService(
        IPaymentStatusRepository repo,
        AuditLogService audit)
        : base(repo, audit){}
}
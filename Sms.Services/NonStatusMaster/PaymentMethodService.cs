using Sms.Core.Entities;
using Sms.Core.Interfaces.NonStatusMaster;
using Sms.Services.Common;

namespace Sms.Services.NonStatusMaster;

public class PaymentMethodService : BaseActivatableService<PaymentMethod>
{
    public PaymentMethodService(
        IPaymentMethodRepository repo,
        AuditLogService audit)
        : base(repo, audit){}
}
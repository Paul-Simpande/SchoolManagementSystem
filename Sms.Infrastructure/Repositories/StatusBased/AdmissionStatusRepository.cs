using Sms.Core.Entities;
using Sms.Core.Interfaces.StatusBased;
using Sms.Infrastructure.Context;

namespace Sms.Infrastructure.Repositories.StatusBased;

public class AdmissionStatusRepository :
    BaseActivatableRepository<AdmissionStatus>,
    IAdmissionStatusRepository
{
    public AdmissionStatusRepository(SchoolDbContext context)
        : base(context){}
}
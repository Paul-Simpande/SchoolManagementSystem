using Sms.Core.Entities;
using Sms.Services.NonStatusMaster;

namespace Sms.Api.GraphQL.Queries.NonStatusMaster;

[ExtendObjectType("Query")]
public class DayOfWeekQuery
{
    public Task<IEnumerable<DayOfWeeks>> GetDayOfWeeks([Service] DayOfWeeksService service)
    {
        return service.GetAllAsync();
    }

    public Task<DayOfWeeks> GetDayOfWeek(int id, [Service] DayOfWeeksService service)
    {
        return service.GetByIdAsync(id);
    }
}
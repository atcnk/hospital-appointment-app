using Core.Persistence;
using Domain.Entities;

namespace Application.Repositories
{
    public interface IDoctorScheduleRepository : IRepository<DoctorSchedule>, IAsyncRepository<DoctorSchedule>
    {
    }
}

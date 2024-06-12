using Core.Persistence;
using Domain.Entities;

namespace Application.Repositories
{
    public interface IDoctorRepository : IRepository<Doctor>, IAsyncRepository<Doctor>
    {
    }
}

using Core.Persistence;
using Domain.Entities;

namespace Application.Repositories
{
    public interface IDepartmentRepository : IAsyncRepository<Department>, IRepository<Department>
    {
    }
}
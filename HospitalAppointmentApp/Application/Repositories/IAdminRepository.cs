using Core.Persistence;
using Domain.Entities;

namespace Application.Repositories
{
    public interface IAdminRepository : IRepository<Admin>, IAsyncRepository<Admin>
    {
    }
}

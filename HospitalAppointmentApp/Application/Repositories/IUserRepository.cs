using Core.Persistence;
using Domain.Entities;

namespace Application.Repositories
{
    public interface IUserRepository : IRepository<User>, IAsyncRepository<User>
    {
    }
}

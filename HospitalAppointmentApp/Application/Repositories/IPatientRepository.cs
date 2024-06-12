using Core.Persistence;
using Domain.Entities;

namespace Application.Repositories
{
    public interface IPatientRepository : IRepository<Patient>, IAsyncRepository<Patient>
    {
    }
}

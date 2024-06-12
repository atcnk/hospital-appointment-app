using Application.Repositories;
using Core.Persistence;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class UserRepository : EfRepositoryBase<User, HospitalAppointmentDbContext>, IUserRepository
    {
        public UserRepository(HospitalAppointmentDbContext context) : base(context)
        {
        }
    }
}

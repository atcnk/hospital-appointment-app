using Application.Repositories;
using Core.Persistence;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class AdminRepository : EfRepositoryBase<Admin, HospitalAppointmentDbContext>, IAdminRepository
    {
        public AdminRepository(HospitalAppointmentDbContext context) : base(context)
        {
        }
    }
}
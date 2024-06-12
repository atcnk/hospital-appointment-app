using Application.Repositories;
using Core.Persistence;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class AdminActionRepository : EfRepositoryBase<AdminAction, HospitalAppointmentDbContext>, IAdminActionRepository
    {
        public AdminActionRepository(HospitalAppointmentDbContext context) : base(context)
        {
        }
    }
}

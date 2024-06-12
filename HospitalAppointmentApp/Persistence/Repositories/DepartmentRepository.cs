using Application.Repositories;
using Core.Persistence;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class DepartmentRepository : EfRepositoryBase<Department, HospitalAppointmentDbContext>, IDepartmentRepository
    {
        public DepartmentRepository(HospitalAppointmentDbContext context) : base(context)
        {
        }
    }
}

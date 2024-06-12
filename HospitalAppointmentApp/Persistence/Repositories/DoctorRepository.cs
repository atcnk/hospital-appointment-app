using Application.Repositories;
using Core.Persistence;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class DoctorRepository : EfRepositoryBase<Doctor, HospitalAppointmentDbContext>, IDoctorRepository
    {
        public DoctorRepository(HospitalAppointmentDbContext context) : base(context)
        {
        }
    }
}

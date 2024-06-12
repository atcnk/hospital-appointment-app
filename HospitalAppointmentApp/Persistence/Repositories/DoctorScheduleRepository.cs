using Application.Repositories;
using Core.Persistence;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class DoctorScheduleRepository : EfRepositoryBase<DoctorSchedule, HospitalAppointmentDbContext>, IDoctorScheduleRepository
    {
        public DoctorScheduleRepository(HospitalAppointmentDbContext context) : base(context)
        {
        }
    }
}

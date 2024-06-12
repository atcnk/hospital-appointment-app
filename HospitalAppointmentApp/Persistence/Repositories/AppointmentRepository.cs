using Application.Repositories;
using Core.Persistence;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class AppointmentRepository : EfRepositoryBase<Appointment, HospitalAppointmentDbContext>, IAppointmentRepository
    {
        public AppointmentRepository(HospitalAppointmentDbContext context) : base(context)
        {
        }
    }
}

using Application.Repositories;
using Core.Persistence;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class PatientRepository : EfRepositoryBase<Patient, HospitalAppointmentDbContext>, IPatientRepository
    {
        public PatientRepository(HospitalAppointmentDbContext context) : base(context)
        {
        }
    }
}

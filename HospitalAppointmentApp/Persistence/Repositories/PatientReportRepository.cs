using Application.Repositories;
using Core.Persistence;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class PatientReportRepository : EfRepositoryBase<PatientReport, HospitalAppointmentDbContext>, IPatientReportRepository
    {
        public PatientReportRepository(HospitalAppointmentDbContext context) : base(context)
        {
        }
    }
}

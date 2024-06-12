using Core.Persistence;
using Domain.Entities;

namespace Application.Repositories
{
    public interface IPatientReportRepository : IRepository<PatientReport>, IAsyncRepository<PatientReport>
    {
    }
}

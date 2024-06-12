using Application.Repositories;
using Core.Persistence;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class FeedbackRepository : EfRepositoryBase<Feedback, HospitalAppointmentDbContext>, IFeedbackRepository
    {
        public FeedbackRepository(HospitalAppointmentDbContext context) : base(context)
        {
        }
    }
}

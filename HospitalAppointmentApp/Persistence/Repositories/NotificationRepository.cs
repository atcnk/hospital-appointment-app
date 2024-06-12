using Application.Repositories;
using Core.Persistence;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class NotificationRepository : EfRepositoryBase<Notification, HospitalAppointmentDbContext>, INotificationRepository
    {
        public NotificationRepository(HospitalAppointmentDbContext context) : base(context)
        {
        }
    }
}

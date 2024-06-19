using Domain.Entities;

namespace Application.Services.DoctorScheduleService
{
    public interface IDoctorScheduleService
    {
        Task<DoctorSchedule?> GetByIdAsync(int id);
        Task SoftDeleteSchedulesByDoctorIdAsync(int doctorId);
    }
}

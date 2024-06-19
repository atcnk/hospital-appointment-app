using Application.Repositories;
using Domain.Entities;

namespace Application.Services.DoctorScheduleService
{
    public class DoctorScheduleManager : IDoctorScheduleService
    {
        private readonly IDoctorScheduleRepository _doctorScheduleRepository;

        public DoctorScheduleManager(IDoctorScheduleRepository doctorScheduleRepository)
        {
            _doctorScheduleRepository = doctorScheduleRepository;
        }

        public async Task SoftDeleteSchedulesByDoctorIdAsync(int doctorId)
        {
            List<DoctorSchedule> schedules = await _doctorScheduleRepository.GetListAsync(ds => ds.DoctorId == doctorId);
            
            foreach (var schedule in schedules)
            {
                await _doctorScheduleRepository.SoftDeleteAsync(schedule);
            }
        }

        public async Task<DoctorSchedule?> GetByIdAsync(int id)
        {
            DoctorSchedule? doctorSchedule = await _doctorScheduleRepository.GetAsync(d => d.Id == id);
            return doctorSchedule;
        }
    }
}

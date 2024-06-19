using Application.Repositories;
using Domain.Entities;

namespace Application.Services.DoctorService
{
    public class DoctorManager : IDoctorService
    {
        private readonly IDoctorRepository _doctorRepository;

        public DoctorManager(IDoctorRepository doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }

        public async Task<Doctor?> GetByIdAsync(int id)
        {
            Doctor? doctor = await _doctorRepository.GetAsync(d => d.Id == id);
            return doctor;
        }
    }
}

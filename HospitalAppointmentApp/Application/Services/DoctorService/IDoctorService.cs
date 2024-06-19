using Domain.Entities;

namespace Application.Services.DoctorService
{
    public interface IDoctorService
    {
        Task<Doctor?> GetByIdAsync(int id);
    }
}

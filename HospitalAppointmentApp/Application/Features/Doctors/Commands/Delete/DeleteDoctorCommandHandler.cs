using Application.Repositories;
using Application.Services.DoctorScheduleService;
using Domain.Entities;
using MediatR;

namespace Application.Features.Doctors.Commands.Delete
{
    public class DeleteDoctorCommandHandler : IRequestHandler<DeleteDoctorCommand>
    {
        private readonly IDoctorRepository _doctorRepository;
        private readonly IDoctorScheduleService _doctorScheduleService;

        public DeleteDoctorCommandHandler(IDoctorRepository doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }

        public async Task Handle(DeleteDoctorCommand request, CancellationToken cancellationToken)
        {
            Doctor? doctor = await _doctorRepository.GetAsync(d => d.Id == request.Id);

            if (doctor is null)
            {
                throw new ArgumentException("Doctor is not found");
            }

            await _doctorScheduleService.SoftDeleteSchedulesByDoctorIdAsync(doctor.Id);
            await _doctorRepository.SoftDeleteAsync(doctor);
        }
    }
}

using Application.Repositories;
using Domain.Entities;
using MediatR;

namespace Application.Features.DoctorSchedules.Commands.Delete
{
    public class DeleteDoctorScheduleCommandHandler : IRequestHandler<DeleteDoctorScheduleCommand>
    {
        private readonly IDoctorScheduleRepository _doctorScheduleRepository;

        public DeleteDoctorScheduleCommandHandler(IDoctorScheduleRepository doctorScheduleRepository)
        {
            _doctorScheduleRepository = doctorScheduleRepository;
        }

        public async Task Handle(DeleteDoctorScheduleCommand request, CancellationToken cancellationToken)
        {
            DoctorSchedule doctorSchedule = await _doctorScheduleRepository.GetAsync(ds => ds.Id == request.Id);

            if (doctorSchedule is null)
            {
                throw new ArgumentException("Doctor schedule is not found");
            }

            await _doctorScheduleRepository.SoftDeleteAsync(doctorSchedule);
        }
    }
}

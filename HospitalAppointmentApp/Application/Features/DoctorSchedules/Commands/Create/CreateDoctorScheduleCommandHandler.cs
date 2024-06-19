using Application.Repositories;
using Application.Services.DoctorService;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.DoctorSchedules.Commands.Create
{
    public class CreateDoctorScheduleCommandHandler : IRequestHandler<CreateDoctorScheduleCommand, CreateDoctorScheduleResponse>
    {
        private readonly IDoctorScheduleRepository _doctorScheduleRepository;
        private readonly IDoctorService _doctorService;
        private readonly IMapper _mapper;

        public async Task<CreateDoctorScheduleResponse> Handle(CreateDoctorScheduleCommand request, CancellationToken cancellationToken)
        {
            Doctor doctor = await _doctorService.GetByIdAsync(request.DoctorId);

            if (doctor is null)
            {
                throw new ArgumentException("Doctor is not found");
            }

            DoctorSchedule doctorSchedule = _mapper.Map<DoctorSchedule>(request);
            await _doctorScheduleRepository.AddAsync(doctorSchedule);

            CreateDoctorScheduleResponse response = _mapper.Map<CreateDoctorScheduleResponse>(doctorSchedule);
            return response;
        }
    }
}

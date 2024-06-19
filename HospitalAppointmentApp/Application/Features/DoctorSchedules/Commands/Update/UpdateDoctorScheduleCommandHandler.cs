using Application.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.DoctorSchedules.Commands.Update
{
    public class UpdateDoctorScheduleCommandHandler : IRequestHandler<UpdateDoctorScheduleCommand, UpdateDoctorScheduleResponse>
    {
        private readonly IDoctorScheduleRepository _doctorScheduleRepository;
        private readonly IMapper _mapper;

        public UpdateDoctorScheduleCommandHandler(IDoctorScheduleRepository doctorScheduleRepository, IMapper mapper)
        {
            _doctorScheduleRepository = doctorScheduleRepository;
            _mapper = mapper;
        }

        public async Task<UpdateDoctorScheduleResponse> Handle(UpdateDoctorScheduleCommand request, CancellationToken cancellationToken)
        {
            DoctorSchedule? doctorSchedule = await _doctorScheduleRepository.GetAsync(ds => ds.Id == request.Id);
        
            if (doctorSchedule is null)
            {
                throw new ArgumentException("Doctor schedule is not found");
            }

            _mapper.Map(request, doctorSchedule);

            await _doctorScheduleRepository.UpdateAsync(doctorSchedule);

            UpdateDoctorScheduleResponse response = _mapper.Map<UpdateDoctorScheduleResponse>(doctorSchedule);
            return response;
        }
    }
}

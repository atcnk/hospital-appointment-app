using Application.Features.DoctorSchedules.Commands.Update;
using Application.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.DoctorSchedules.Queries.GetById
{
    public class GetByIdDoctorScheduleQueryHandler : IRequestHandler<GetByIdDoctorScheduleQuery, GetByIdDoctorScheduleResponse>
    {
        private readonly IDoctorScheduleRepository _doctorScheduleRepository;
        private readonly IMapper _mapper;

        public GetByIdDoctorScheduleQueryHandler(IDoctorScheduleRepository doctorScheduleRepository, IMapper mapper)
        {
            _doctorScheduleRepository = doctorScheduleRepository;
            _mapper = mapper;
        }

        public async Task<GetByIdDoctorScheduleResponse> Handle(GetByIdDoctorScheduleQuery request, CancellationToken cancellationToken)
        {
            DoctorSchedule? doctorSchedule = await _doctorScheduleRepository.GetAsync(ds => ds.Id == request.Id);

            if (doctorSchedule is null)
            {
                throw new ArgumentException("Doctor schedule is not found");
            }

            GetByIdDoctorScheduleResponse response = _mapper.Map<GetByIdDoctorScheduleResponse>(doctorSchedule);
            return response;
        }
    }
}

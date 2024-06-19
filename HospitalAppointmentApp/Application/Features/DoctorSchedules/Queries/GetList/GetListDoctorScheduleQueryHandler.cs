using Application.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.DoctorSchedules.Queries.GetList
{
    public class GetListDoctorScheduleQueryHandler : IRequestHandler<GetListDoctorScheduleQuery, List<GetListDoctorScheduleResponse>>
    {
        private readonly IDoctorScheduleRepository _doctorScheduleRepository;
        private readonly IMapper _mapper;

        public GetListDoctorScheduleQueryHandler(IDoctorScheduleRepository doctorScheduleRepository, IMapper mapper)
        {
            _doctorScheduleRepository = doctorScheduleRepository;
            _mapper = mapper;
        }

        public async Task<List<GetListDoctorScheduleResponse>> Handle(GetListDoctorScheduleQuery request, CancellationToken cancellationToken)
        {
            List<DoctorSchedule> doctorSchedules = await _doctorScheduleRepository.GetListAsync();

            List<GetListDoctorScheduleResponse> response = _mapper.Map<List<GetListDoctorScheduleResponse>>(doctorSchedules);
            return response;
        }
    }
}

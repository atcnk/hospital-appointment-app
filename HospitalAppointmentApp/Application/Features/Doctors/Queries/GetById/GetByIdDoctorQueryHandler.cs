using Application.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Doctors.Queries.GetById
{
    public class GetByIdDoctorQueryHandler : IRequestHandler<GetByIdDoctorQuery, GetByIdDoctorResponse>
    {
        private readonly IDoctorRepository _doctorRepository;
        private readonly IMapper _mapper;

        public GetByIdDoctorQueryHandler(IDoctorRepository doctorRepository, IMapper mapper)
        {
            _doctorRepository = doctorRepository;
            _mapper = mapper;
        }

        public async Task<GetByIdDoctorResponse> Handle(GetByIdDoctorQuery request, CancellationToken cancellationToken)
        {
            Doctor? doctor = await _doctorRepository.GetAsync(d => d.Id == request.Id);

            if (doctor is null)
            {
                throw new ArgumentException("Doctor is not found");
            }

            GetByIdDoctorResponse response = _mapper.Map<GetByIdDoctorResponse>(doctor);
            return response;
        }
    }
}

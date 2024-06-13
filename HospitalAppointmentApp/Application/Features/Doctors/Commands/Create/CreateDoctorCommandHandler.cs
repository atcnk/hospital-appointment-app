using Application.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Doctors.Commands.Create
{
    public class CreateDoctorCommandHandler : IRequestHandler<CreateDoctorCommand, CreateDoctorResponse>
    {
        private readonly IDoctorRepository _doctorRepository;
        private readonly IMapper _mapper;

        public CreateDoctorCommandHandler(IDoctorRepository doctorRepository, IMapper mapper)
        {
            _doctorRepository = doctorRepository;
            _mapper = mapper;
        }

        public async Task<CreateDoctorResponse> Handle(CreateDoctorCommand request, CancellationToken cancellationToken)
        {
            Doctor doctor = _mapper.Map<Doctor>(request);
            await _doctorRepository.AddAsync(doctor);

            CreateDoctorResponse response = _mapper.Map<CreateDoctorResponse>(doctor);
            return response;
        }
    }
}

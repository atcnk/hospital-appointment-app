using Application.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Doctors.Commands.Update
{
    public class UpdateDoctorCommandHandler : IRequestHandler<UpdateDoctorCommand, UpdateDoctorResponse>
    {
        private readonly IDoctorRepository _doctorRepository;
        private readonly IMapper _mapper;

        public UpdateDoctorCommandHandler(IDoctorRepository doctorRepository, IMapper mapper)
        {
            _doctorRepository = doctorRepository;
            _mapper = mapper;
        }

        public async Task<UpdateDoctorResponse> Handle(UpdateDoctorCommand request, CancellationToken cancellationToken)
        {
            Doctor? doctor = await _doctorRepository.GetAsync(d => d.Id == request.Id);

            if (doctor is null)
            {
                throw new ArgumentException("Doctor is not found");
            }

            _mapper.Map(request, doctor);

            await _doctorRepository.UpdateAsync(doctor);

            UpdateDoctorResponse response = _mapper.Map<UpdateDoctorResponse>(doctor);
            return response;
        }
    }
}

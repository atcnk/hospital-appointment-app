﻿using Application.Features.DoctorAvailabilities.Constants;
using Application.Features.DoctorAvailabilities.Rules;
using Application.Repositories;
using AutoMapper;
using Core.Application.Pipelines.Authorization;
using Core.Application.Pipelines.Logging;
using Domain.Entities;
using MediatR;
using static Application.Features.DoctorAvailabilities.Constants.DoctorAvailabilityOperationClaims;

namespace Application.Features.DoctorAvailabilities.Commands.SoftDelete
{
    public class SoftDeleteDoctorAvailabilityCommand : IRequest<SoftDeleteDoctorAvailabilityResponse>, ISecuredRequest, ILoggableRequest
    {
        public string[] RequiredRoles => [Admin, DoctorAvailabilityOperationClaims.Delete];
        public int Id { get; set; }

        public class SoftDeleteDoctorAvailabilityCommandHandler : IRequestHandler<SoftDeleteDoctorAvailabilityCommand, SoftDeleteDoctorAvailabilityResponse>
        {
            private readonly IDoctorAvailabilityRepository _doctorAvailabilityRepository;
            private readonly IMapper _mapper;
            private readonly DoctorAvailabilityBusinessRules _doctorAvailabilityBusinessRules;

            public SoftDeleteDoctorAvailabilityCommandHandler(IDoctorAvailabilityRepository doctorAvailabilityRepository, IMapper mapper, DoctorAvailabilityBusinessRules doctorAvailabilityBusinessRules)
            {
                _doctorAvailabilityRepository = doctorAvailabilityRepository;
                _mapper = mapper;
                _doctorAvailabilityBusinessRules = doctorAvailabilityBusinessRules;
            }

            public async Task<SoftDeleteDoctorAvailabilityResponse> Handle(SoftDeleteDoctorAvailabilityCommand request, CancellationToken cancellationToken)
            {
                DoctorAvailability? doctorAvailability = await _doctorAvailabilityRepository.GetAsync(i => i.Id == request.Id);

                await _doctorAvailabilityBusinessRules.DoctorAvailabilityShouldBeExist(request.Id);

                await _doctorAvailabilityRepository.SoftDeleteAsync(doctorAvailability);

                SoftDeleteDoctorAvailabilityResponse response = _mapper.Map<SoftDeleteDoctorAvailabilityResponse>(doctorAvailability);
                return response;
            }
        }
    }
}

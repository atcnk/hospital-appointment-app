﻿using Application.Features.Appointments.Commands.Create;
using Application.Features.Appointments.Commands.Delete;
using Application.Features.Appointments.Commands.SoftDelete;
using Application.Features.Appointments.Commands.Update;
using Application.Features.Appointments.Queries.GetByDoctorAndDate;
using Application.Features.Appointments.Queries.GetByDoctorAndWeek;
using Application.Features.Appointments.Queries.GetById;
using Application.Features.Appointments.Queries.GetByPatient;
using Application.Features.Appointments.Queries.GetList;
using Application.Features.DoctorAvailabilities.Commands.Create;
using Application.Features.PatientReports.Commands.Create;
using AutoMapper;
using Core.Paging;
using Core.Responses;
using Domain.Entities;
using Domain.Enums;

namespace Application.Features.Appointments.Profiles
{
    public class AppointmentMappingProfile : Profile
    {
        public AppointmentMappingProfile()
        {
            CreateMap<Appointment, CreateAppointmentCommand>().ReverseMap();
            CreateMap<Appointment, CreateAppointmentResponse>().ReverseMap();
            CreateMap<Appointment, DeleteAppointmentCommand>().ReverseMap();
            CreateMap<Appointment, DeleteAppointmentResponse>().ReverseMap();
            CreateMap<Appointment, SoftDeleteAppointmentCommand>().ReverseMap();
            CreateMap<Appointment, SoftDeleteAppointmentResponse>().ReverseMap();
            CreateMap<Appointment, UpdateAppointmentCommand>().ReverseMap();
            CreateMap<Appointment, UpdateAppointmentResponse>().ReverseMap();
            CreateMap<Appointment, GetByIdAppointmentQuery>().ReverseMap();
            CreateMap<Appointment, GetByIdAppointmentResponse>().ReverseMap();
            CreateMap<Appointment, GetListAppointmentQuery>().ReverseMap();
            CreateMap<Appointment, GetListAppointmentResponse>().ReverseMap();
            CreateMap<IPaginate<Appointment>, GetListResponse<GetListAppointmentResponse>>().ReverseMap();

            CreateMap<CreateAppointmentCommand, Appointment>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => AppointmentStatus.Booked));
            CreateMap<Appointment, CreateAppointmentResponse>();

            CreateMap<CreateDoctorAvailabilityCommand, DoctorAvailability>();
            CreateMap<DoctorAvailability, CreateDoctorAvailabilityResponse>();

            CreateMap<CreatePatientReportCommand, PatientReport>();
            CreateMap<PatientReport, CreatePatientReportResponse>();

            CreateMap<Appointment, GetAppointmentsByDoctorAndWeekResponse>().ReverseMap();
            CreateMap<IPaginate<Appointment>, GetListResponse<GetListAppointmentResponse>>().ReverseMap();
            CreateMap<IPaginate<Appointment>, GetListResponse<GetAppointmentsByDoctorAndWeekResponse>>().ReverseMap();
            CreateMap<Appointment, GetAppointmentsByPatientResponse>().ReverseMap();
            CreateMap<IPaginate<Appointment>, GetListResponse<GetAppointmentsByPatientResponse>>().ReverseMap();
            CreateMap<Appointment, GetAppointmentsByDoctorAndDateResponse>().ReverseMap();
            CreateMap<IPaginate<Appointment>, GetListResponse<GetAppointmentsByDoctorAndDateResponse>>().ReverseMap();
        }
    }
}

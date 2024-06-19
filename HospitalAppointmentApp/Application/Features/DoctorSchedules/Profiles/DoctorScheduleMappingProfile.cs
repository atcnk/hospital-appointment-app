using Application.Features.DoctorSchedules.Commands.Create;
using Application.Features.DoctorSchedules.Commands.Update;
using Application.Features.DoctorSchedules.Queries.GetById;
using Application.Features.DoctorSchedules.Queries.GetList;
using AutoMapper;
using Domain.Entities;

namespace Application.Features.DoctorSchedules.Profiles
{
    public class DoctorScheduleMappingProfile : Profile
    {
        public DoctorScheduleMappingProfile()
        {
            CreateMap<DoctorSchedule, CreateDoctorScheduleCommand>().ReverseMap();
            CreateMap<DoctorSchedule, CreateDoctorScheduleResponse>().ReverseMap();
            CreateMap<DoctorSchedule, GetByIdDoctorScheduleQuery>().ReverseMap();
            CreateMap<DoctorSchedule, GetByIdDoctorScheduleResponse>().ReverseMap();
            CreateMap<DoctorSchedule, GetListDoctorScheduleQuery>().ReverseMap();
            CreateMap<DoctorSchedule, GetListDoctorScheduleResponse>().ReverseMap();
            CreateMap<DoctorSchedule, UpdateDoctorScheduleCommand>().ReverseMap();
            CreateMap<DoctorSchedule, UpdateDoctorScheduleResponse>().ReverseMap();
        }
    }
}

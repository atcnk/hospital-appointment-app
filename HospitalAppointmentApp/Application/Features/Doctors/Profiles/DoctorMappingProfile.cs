using Application.Features.Doctors.Commands.Create;
using Application.Features.Doctors.Commands.Update;
using Application.Features.Doctors.Queries.GetById;
using Application.Features.Doctors.Queries.GetList;
using AutoMapper;
using Domain.Entities;

namespace Application.Features.Doctors.Profiles
{
    public class DoctorMappingProfile : Profile
    {
        public DoctorMappingProfile()
        {
            CreateMap<Doctor, CreateDoctorCommand>().ReverseMap();
            CreateMap<Doctor, CreateDoctorResponse>().ReverseMap();
            CreateMap<Doctor, GetByIdDoctorQuery>().ReverseMap();
            CreateMap<Doctor, GetByIdDoctorResponse>().ReverseMap();
            CreateMap<Doctor, GetListDoctorQuery>().ReverseMap();
            CreateMap<Doctor, GetListDoctorResponse>().ReverseMap();
            CreateMap<Doctor, UpdateDoctorCommand>().ReverseMap();
            CreateMap<Doctor, UpdateDoctorResponse>().ReverseMap();
        }
    }
}

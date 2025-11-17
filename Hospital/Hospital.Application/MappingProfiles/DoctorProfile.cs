using AutoMapper;
using Hospital.Application.DTO.Doctor;
using Hospital.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Application.MappingProfiles
{
    public class DoctorProfile : Profile
    {
        public DoctorProfile()
        {
            // Add Doctor
            CreateMap<AddDoctorDto, Doctor>()
                .ForMember(dest => dest.DoctorId, opt => opt.Ignore())
                .ForMember(dest => dest.UserId, opt => opt.Ignore())
                .ForMember(dest => dest.Branches, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedAt, opt => opt.Ignore())
                .ForMember(dest => dest.UpdatedAt, opt => opt.Ignore());

            // Doctor → DoctorDto
            CreateMap<Doctor, DoctorDto>()
                .ForMember(d => d.UserName, opt => opt.MapFrom(s => s.User.UserName))
                .ForMember(d => d.Email, opt => opt.MapFrom(s => s.User.Email))
                .ForMember(d => d.FullName, opt => opt.MapFrom(s => s.User.FullName))
                .ForMember(d => d.SpecializationName, opt => opt.MapFrom(s => s.Specialization != null ? s.Specialization.Name : null))
                .ForMember(d => d.BranchID, opt => opt.MapFrom(s => s.Branches.Select(b => b.BranchId).ToList()));

            // Schedule → DoctorScheduleDto   
            CreateMap<Schedule, DoctorSchuduleDto>()
                .ForMember(dest => dest.ScheduleId, opt => opt.MapFrom(src => src.ScheduleId))
                .ForMember(dest => dest.DayOfWeek, opt => opt.MapFrom(src => src.DayOfWeek))
                .ForMember(dest => dest.StartTime, opt => opt.MapFrom(src => src.StartTime))
                .ForMember(dest => dest.EndTime, opt => opt.MapFrom(src => src.EndTime));

            // DoctorDto → Doctor
            CreateMap<DoctorDto, Doctor>()
                .ForMember(dest => dest.DoctorId, opt => opt.Ignore())
                .ForMember(dest => dest.UserId, opt => opt.Ignore())
                .ForMember(dest => dest.Branches, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedAt, opt => opt.Ignore())
                .ForMember(dest => dest.UpdatedAt, opt => opt.Ignore());
        }
    }

}

using AutoMapper;
using Hospital.Application.DTO.Patient;
using Hospital.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Application.MappingProfiles
{
    public class PatientProfile : Profile
    {
        public PatientProfile()
        {
            // Correct mapping from Patient → PatientDto
            CreateMap<Patient, PatientDto>()
                .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.User.FullName))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.User.Email))
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.User.PhoneNumber))
                .ReverseMap();

            // For updating patient
            CreateMap<UpdatePatientDto, Patient>()
                 .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(_ => DateTime.UtcNow))
                 .ForMember(dest => dest.PatientId, opt => opt.MapFrom(src => src.PatientId))
                 .ForMember(dest => dest.User, opt => opt.Ignore())
                 .ForMember(dest => dest.UserId, opt => opt.Ignore())
                 .ForMember(dest => dest.EmergencyContact, opt => opt.Ignore())
                 .ForMember(dest => dest.CreatedAt, opt => opt.Ignore())
                 .ForMember(dest => dest.Appointments, opt => opt.Ignore())
                 .ForMember(dest => dest.MedicalRecords, opt => opt.Ignore());
        }
    }
}

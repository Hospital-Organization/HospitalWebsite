using Hospital.Application.DTO.Patient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Application.Interfaces.Services
{
    public interface IPatientService
    {
        Task<PatientDto> GetPatientByIdAsync(int id);
        Task<PatientDto> UpdatePatientAsync(UpdatePatientDto dto);
        Task<List<PatientDto>> GetAllPatientsAsync();
    }
}

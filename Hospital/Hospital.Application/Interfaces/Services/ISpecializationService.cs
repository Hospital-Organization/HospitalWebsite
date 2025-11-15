using Hospital.Application.DTO.Event;
using Hospital.Application.DTO.Specialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Application.Interfaces.Services
{
    public interface ISpecializationService
    {
        Task<SpecializationDTO> AddAsync(CreateSpecialization specialization);
        Task<int> UpdateAsync(UpdateSpecialization specialization);
        Task<int> DeleteAsync(GetSpecializationDto specialization);
        Task<SpecializationDTO?> GetAsync(int id);
        Task<IEnumerable<SpecializationInfoDto>> GetAllByBranchAsync(int branchId);
        Task<IEnumerable<SpecializationDTO>> GetAllSpecializaionInSystemAsync();
    }
}

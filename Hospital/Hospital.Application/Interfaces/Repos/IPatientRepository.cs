using Hospital.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Application.Interfaces.Repos
{
    public interface IPatientRepository
    {
      Task AddAsync(Patient patient);
      Task<Patient?> GetByIdAsync(int id);
      Task<List<Patient>> GetAllAsync();
      Task UpdateAsync(Patient patient);
    }
}

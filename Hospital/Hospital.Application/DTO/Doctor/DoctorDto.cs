using Hospital.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Application.DTO.Doctor
{
    public class DoctorDto
    {
        [Key] public int DoctorId { get; set; }
        public string? Biography { get; set; }
        [Range(0, 80)] public int? ExperienceYears { get; set; }
        [Column(TypeName = "decimal(10,2)")] public decimal? ConsultationFees { get; set; }
        public bool? Available { get; set; }
    }
}

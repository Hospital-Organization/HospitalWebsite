using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Application.DTO.Specialization
{
    public class GetSpecializationDto
    {
        public int SpecializationId { get; set; }
        public int BranchId { get; set; }
    }
}

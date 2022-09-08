using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Application.Contracts.WorkFlows
{
    public class EmployeeDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid StructDivisionId { get; set; }
        public StructDivisionDto StructDivision { get; set; }
        public bool IsHead { get; set; }

        public List<EmployeeRoleDto> EmployeeRoles { get; set; }
    }
}

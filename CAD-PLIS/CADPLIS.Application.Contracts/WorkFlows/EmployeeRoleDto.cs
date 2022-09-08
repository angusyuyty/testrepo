using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Application.Contracts.WorkFlows
{
    public class EmployeeRoleDto
    {
        public Guid EmployeeId { get; set; }
        public Guid RoleId { get; set; }
        public RoleDto Role { get; set; }
    }
}

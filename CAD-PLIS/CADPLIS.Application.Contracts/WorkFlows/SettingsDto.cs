using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Application.Contracts.WorkFlows
{
    public class SettingsDto
    {
        public string WFSchema { get; set; }

        public List<EmployeeDto> Employees { get; set; }
        public List<RoleDto> Roles { get; set; }
        public List<StructDivisionDto> StructDivision { get; set; }

        public string SchemeName
        {
            get { return "SimpleWF"; }
        }
    }
}

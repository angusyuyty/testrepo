using CADPLIS.Application.Contracts.WorkFlows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.EntityFrameworkCore.WorkFlowDataAccess
{
    public interface IEmployeeRepository
    {
        List<EmployeeDto> GetAll();
        string GetNameById(string id);
        IEnumerable<string> GetInRole(string roleName);
        bool CheckRole(Guid employeeId, string roleName);
    }
}

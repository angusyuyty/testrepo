
using CADPLIS.EntityFrameworkCore.WorkFlowDataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using CADPLIS.EntityFrameworkCore.EntityFrameworkCore;
using CADPLIS.Application.Contracts.WorkFlows;
using AutoMapper;
using CADPLIS.Domain.Users;
using CADPLIS.Domain.Roles;

namespace CADPLIS.Application.WorkFlows
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly PlisDbcontext _sampleContext;
        private readonly IMapper _autoMapper;
        private readonly IUserRoleRepository _userRoleRepository;
        private readonly IUserRepository _userRepository;
        public EmployeeRepository(PlisDbcontext sampleContext,IMapper mapper, IUserRoleRepository userRoleRepository, IUserRepository userRepository)
        {
            _sampleContext = sampleContext;
            _autoMapper = mapper;
            _userRoleRepository = userRoleRepository;
            _userRepository = userRepository;
        }

        public bool CheckRole(Guid employeeId, string roleName)
        {
             return _sampleContext.EmployeeRoles.Any(r => r.EmployeeId == employeeId && r.Role.Name == roleName);
        }

        public List<EmployeeDto> GetAll()
        {
            return _sampleContext.Employees
                                 .Include(x => x.StructDivision)
                                 .Include(x => x.EmployeeRoles)
                                 .ThenInclude(x => x.Role)
                                 .ToList().Select(e => _autoMapper.Map<EmployeeDto>(e))
                                 .OrderBy(c => c.Name).ToList();
        }
        public IEnumerable<string> GetInRole(string roleName)
        {
            var result = _userRoleRepository.FindListAsync("",roleName).Result.ToList().Select(u=>u.UserId).ToList();
            return result;
            //_sampleContext.EmployeeRoles.Where(r => r.Role.Name == roleName).ToList()
            //  .Select(r => r.EmployeeId.ToString()).ToList();

            
        }

        public string GetNameById(string id)
        {
            string res = "Unknown";

            var item = _userRepository.FindAsync(u=>u.UserId.Equals(id)).Result; //_sampleContext.Employees.Find(id);
            if (item != null)
                res = item.UserName;//item.Name;
            
            return res;
        }
    }
}

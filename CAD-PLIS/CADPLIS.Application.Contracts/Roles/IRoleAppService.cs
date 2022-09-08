using CADPLIS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Application.Contracts.Roles
{
    public interface IRoleAppService
    {
        Task AddAsync(RoleInfoDto roleDto);
        Task UpdateAsync(RoleInfoDto roleDto);
        Task DeleteAsync(int id);
        Task<Paginator<RoleInfoDto>> GetPageListAsync(int pageSize, int pageIndex, string roleId,string roleName);
        Task<List<RoleInfoDto>> GetAllRole();
        Task<RoleInfoDto> GetByIdAsync(int id);
        Task<RoleInfoDto> GetByRoleIdAsync(string roleId);
    }
}

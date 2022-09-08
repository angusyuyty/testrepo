using CADPLIS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Application.Contracts.Groups
{
    public interface IUserRoleGroupAppService
    {
        Task<Paginator<UserRoleGroupDto>> GetPageListAsync(int pageSize, int pageIndex, int id, string userId, string roleId);
        Task<List<UserRoleGroupDto>> GetListAsync(string userId, string roleId);
        Task AddAsync(UserRoleGroupDto userRoleGroupDto);
        Task UpdateAsync(UserRoleGroupDto userRoleGroupDto);
        Task DeleteAsync(int id);
        Task<UserRoleGroupDto> GetByIdAsync(int id); 
    }
}

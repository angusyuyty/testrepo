using CADPLIS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Application.Contracts.Users
{
    public interface IUserRoleAppService:IBaseAppService
    {
        Task Insert(UserRoleDto model);
        Task Update(UserRoleDto model);
        Task<Paginator<UserRoleDto>> GetListBySearchAsync(int pageSize, int pageIndex, string userId);
        Task<UserRoleDto> GetByIdAsync(int id);
        Task<UserRoleDto> GetByUserIdAndRoleIdAsync(string userId, string roleId);
        Task DeleteAsync(int id);
        //Task<UserRoleDto> RoleValidate(UserRoleDto model, string action);
        Task<List<UserRoleDto>> GetRoleByUserId(string userId);
        Task<List<UserRoleDto>> GetListAsync();
    }
}

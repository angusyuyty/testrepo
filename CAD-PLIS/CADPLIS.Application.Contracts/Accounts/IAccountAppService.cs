using CADPLIS.Domain;
using CADPLIS.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Application.Contracts.Accounts
{
    public interface IAccountAppService
    {
        Task<List<string>> GetPermissions();
        Task CreateRoleAsync(RoleInfoDto roleDto);
        Task UpdateRoleAsync(RoleInfoDto roleDto);
        Task DeleteRoleAsync(string name);
        Task  AddUser(RegisterViewModel model);
        Task UpdateUser(UserViewModel userViewModel);
        Task ChangePassword(ChangePasswordViewModel changePasswordViewModel);
        Task DeleteUser(Guid id);
        Task<List<ApplicationUserDto>> LoadUsers();
        Task<Paginator<ApplicationUserDto>> GetPageUsers(int pageSize, int pageIndex);
        Task<ApplicationUserDto> GetUserById(Guid id);
        Task<List<RoleInfoDto>> GetAllRoles();
        Task<Paginator<RoleInfoDto>> GetPageRoles(int pageSize, int pageIndex);
        Task<RoleInfoDto> GetRoleAsync(string name);

        Task<GroupInfoDto> GetGroup(Guid id);
        Task CreateGroupAsync(GroupInfoDto groupInfoDto);
        Task UpdateGroupAsync(GroupInfoDto groupInfoDto);

        Task DeleteGroupAsync(Guid id);
        Task<Paginator<GroupInfoDto>> GetPageGroupList(int pageSize, int pageIndex);

        Task<List<GroupInfoDto>> GetGroupList();
    }
}

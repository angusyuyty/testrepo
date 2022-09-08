using AutoMapper;
using CADPLIS.Application.Contracts.Accounts;
using CADPLIS.Domain.Identity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using CADPLIS.EntityFrameworkCore.EntityFrameworkCore;
using CADPLIS.Domain;
using Microsoft.EntityFrameworkCore;
using CADPLIS.Domain.WorkFlows;
using IdentityModel;
using Dapper;

namespace CADPLIS.Application.Accounts
{
    public class AccountAppService : IAccountAppService
    {
        private readonly EntityPermissions _entityPermissions;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IMapper _mapper;
        private readonly PlisDbcontext _plisDbcontext;

        public AccountAppService(EntityPermissions entityPermissions, RoleManager<ApplicationRole> roleManager, UserManager<ApplicationUser> userManager, IMapper mapper, PlisDbcontext plisDbcontext)
        {
            _entityPermissions = entityPermissions;
            _roleManager = roleManager;
            _userManager = userManager;
            _mapper = mapper;
            _plisDbcontext = plisDbcontext;
        }
        public async Task<List<string>> GetPermissions()
        {

            return await Task.FromResult(_entityPermissions.GetAllPermissionNames());
        }
        public async Task CreateRoleAsync(RoleInfoDto roleDto)
        {
            if (_roleManager.Roles != null && _roleManager.Roles.Any(r => r.Name == roleDto.Name))
            {
                throw new Exception($"{roleDto.Name} already exists !");
            }
            await _roleManager.CreateAsync(new ApplicationRole(roleDto.Name));
            var role = await _roleManager.FindByNameAsync(roleDto.Name);

            foreach (var claim in roleDto.Permissions)
            {
                var resultAddClaim = await _roleManager.AddClaimAsync(role, new Claim("permission", _entityPermissions.GetPermissionByName(claim)));

                if (!resultAddClaim.Succeeded)
                    await _roleManager.DeleteAsync(role);
            }

            var wkRole = new Role
            {
                Id = role.Id,
                Name = role.Name
            };
            _plisDbcontext.WKRoles.Add(wkRole);
            await _plisDbcontext.SaveChangesAsync();
        }

        public async Task UpdateRoleAsync(RoleInfoDto roleDto)
        {
            if (!_roleManager.Roles.Any(r => r.Name == roleDto.Name))
                throw new Exception($"The role {roleDto.Name} doesn't exist");
            else
            {
                // Create the permissions
                var role = await _roleManager.FindByNameAsync(roleDto.Name);

                var claims = await _roleManager.GetClaimsAsync(role);
                var permissions = claims.Where(x => x.Type == ApplicationClaimTypes.Permission).Select(x => x.Value).ToList();

                foreach (var permission in permissions)
                {
                    await _roleManager.RemoveClaimAsync(role, new Claim(ApplicationClaimTypes.Permission, permission));
                }

                foreach (var claim in roleDto.Permissions)
                {
                    var result = await _roleManager.AddClaimAsync(role, new Claim(ApplicationClaimTypes.Permission, _entityPermissions.GetPermissionByName(claim)));

                    if (!result.Succeeded)
                        await _roleManager.DeleteAsync(role);
                }

                if (role != null)
                {
                    var wkflowRole = _plisDbcontext.WKRoles.FirstOrDefault(u => u.Id.Equals(role.Id));
                    if (wkflowRole != null)
                    {
                        wkflowRole.Name = roleDto.Name;
                        await _plisDbcontext.SaveChangesAsync();
                    }
                }
            }
        }

        public async Task DeleteRoleAsync(string name)
        {
            // Check if the role is used by a user
            var users = await _userManager.GetUsersInRoleAsync(name);
            if (users.Any())
                throw new Exception("Role In Use Warning");
            else
            {
                if (name == DefaultRoleNames.Administrator)
                    throw new Exception($"Role {name} cannot be deleted");
                else
                {
                    var role = await _roleManager.FindByNameAsync(name);
                    await _roleManager.DeleteAsync(role);

                    var wkRole = _plisDbcontext.WKRoles.FirstOrDefault(u => u.Id.Equals(role.Id));
                    if (wkRole != null)
                    {
                        _plisDbcontext.WKRoles.Remove(wkRole);
                        await _plisDbcontext.SaveChangesAsync();
                    }
                }
            }
        }
        public async Task AddUser(RegisterViewModel model)
        {
            var id = Guid.NewGuid();
            var user = new ApplicationUser { Id = id, UserName = model.UserName, Email = model.Email, IsHead = model.IsHead, GroupId = model.GroupId };
            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                await _userManager.AddClaimsAsync(user, new Claim[]{
                    new Claim(JwtClaimTypes.Name, user.UserName),
                    new Claim(JwtClaimTypes.Email, user.Email),
                    new Claim(JwtClaimTypes.EmailVerified, ClaimValues.falseString, ClaimValueTypes.Boolean)
                });
                try
                {
                    var employ = new Employee
                    {
                        Id = id,
                        Name = model.UserName,
                        StructDivisionId = model.GroupId.Value,
                        IsHead = model.IsHead
                    };
                    _plisDbcontext.Employees.Add(employ);

                    foreach (var role in model.Roles)
                    {
                        await _userManager.AddToRoleAsync(user, role);
                        var roledata = await _roleManager.FindByNameAsync(role);
                        var roleId = roledata.Id;
                        var employeeRole = new EmployeeRole
                        {
                            EmployeeId = id,
                            RoleId = roleId
                        };
                        _plisDbcontext.EmployeeRoles.Add(employeeRole);
                    }

       
                    _plisDbcontext.SaveChanges();
                }
                catch(Exception e)
                { 
                }

            }

        }
        public async Task UpdateUser(UserViewModel userViewModel)
        {
            var user = await _userManager.FindByIdAsync(userViewModel.UserId.ToString());

            if (user == null)
            {
                throw new Exception("The user doesn't exist");
            }
            user.UserName = userViewModel.UserName;
            user.Email = userViewModel.Email;
            user.GroupId = userViewModel.GroupId;
            user.IsHead = userViewModel.IsHead;
            var result = await _userManager.UpdateAsync(user);
            var currentUserRoles = (List<string>)await _userManager.GetRolesAsync(user);

            var rolesToAdd = new List<string>();
            foreach (var newUserRole in userViewModel.Roles)
            {
                if (!currentUserRoles.Contains(newUserRole))
                    rolesToAdd.Add(newUserRole);
            }

            if (rolesToAdd.Count > 0)
            {
                await _userManager.AddToRolesAsync(user, rolesToAdd);

                //HACK to switch to claims auth
                foreach (var role in rolesToAdd)
                {
                    await _userManager.AddClaimAsync(user, new Claim($"Is{role}", ClaimValues.trueString));
                    var employeeRole = new EmployeeRole
                    {
                        EmployeeId = userViewModel.UserId,
                        RoleId =( await _roleManager.FindByNameAsync(role)).Id
                    };
                    _plisDbcontext.EmployeeRoles.Add(employeeRole);
                }
            }

            var rolesToRemove = currentUserRoles.Where(role => !userViewModel.Roles.Contains(role)).ToList();

            if (rolesToRemove.Count > 0)
            {
                if (user.UserName.ToLower() == DefaultUserNames.Administrator)
                    rolesToRemove.Remove(DefaultUserNames.Administrator);

                await _userManager.RemoveFromRolesAsync(user, rolesToRemove);

                //HACK to switch to claims auth
                foreach (var role in rolesToRemove)
                {
                    await _userManager.RemoveClaimAsync(user, new Claim($"Is{role}", ClaimValues.trueString));
                    var employeeRole = new EmployeeRole
                    {
                        EmployeeId = userViewModel.UserId,
                        RoleId = Guid.Parse(await _roleManager.GetRoleIdAsync(new ApplicationRole { Name = role }))
                    };
                    _plisDbcontext.EmployeeRoles.Remove(employeeRole);
                }
            }

            var employInfo = _plisDbcontext.Employees.FirstOrDefault(u => u.Id.Equals(userViewModel.UserId));
            if (employInfo != null)
            {
                employInfo.Name = userViewModel.UserName;
                employInfo.StructDivisionId = userViewModel.GroupId.Value;
            }

            await _plisDbcontext.SaveChangesAsync();

            if (!result.Succeeded)
            {
                var msg = string.Join(",", result.Errors.Select(i => i.Description));
                throw new Exception($"User Update Failed: {msg}");
            }
        }

        public async Task DeleteUser(Guid id)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null)
            {
                throw new Exception("The user doesn't exist");
            }
            if (user.UserName.ToLower() != DefaultUserNames.Administrator)
            {
                await _userManager.DeleteAsync(user);
                try
                {
                    _plisDbcontext.Database.GetDbConnection().Execute("delete from Employee where Id=@EmployeeId", new { EmployeeId = id });
                    _plisDbcontext.Database.GetDbConnection().Execute("delete from EmployeeRole where EmployeeId=@EmployeeId", new { EmployeeId = id });
                }
                catch (Exception e)
                { 
                }
            }
            else
                throw new Exception($"User {user.UserName} cannot be edited");
        }

        public async Task<List<ApplicationUserDto>> LoadUsers()
        {
            var users = _userManager.Users.ToList();
            var list = new List<ApplicationUserDto>();
            foreach (var item in users)
            {
                var userDto = _mapper.Map<ApplicationUserDto>(item);
                var roles = await _userManager.GetRolesAsync(item);
                userDto.Roles = roles.ToList();
                list.Add(userDto);
            }
            return list;
        }

        public async Task<Paginator<ApplicationUserDto>> GetPageUsers(int pageSize, int pageIndex)
        {
            var dataSource = _plisDbcontext.Users;
            var pageData = new Paginator<ApplicationUserDto>();
            pageData.pageCount = dataSource.Count();
            pageData.pageIndex = pageIndex;
            pageData.pageSize = pageSize;
            var users = await dataSource.Skip(pageSize * pageIndex).Take(pageSize).ToListAsync();
            var list = new List<ApplicationUserDto>();
            foreach (var item in users)
            {
                var userDto = _mapper.Map<ApplicationUserDto>(item);
                var roles = await _userManager.GetRolesAsync(item);
                userDto.Roles = roles.ToList();
                list.Add(userDto);
            }
            pageData.data = list;
            return pageData;
        }

        public async Task<ApplicationUserDto> GetUserById(Guid id)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());
            if (user != null)
            {

                var result = _mapper.Map<ApplicationUserDto>(user);
                result.Roles = (await _userManager.GetRolesAsync(user))?.ToList();
                return result;
            }
            return new ApplicationUserDto();
        }

        public async Task ChangePassword(ChangePasswordViewModel changePasswordViewModel)
        {
            var user = await _userManager.FindByIdAsync(changePasswordViewModel.UserId.ToString());
            if (user == null)
            {
                throw new Exception($"The user {changePasswordViewModel.UserId} doesn't exist");

            }
            var passToken = await _userManager.GeneratePasswordResetTokenAsync(user);
            var result = await _userManager.ResetPasswordAsync(user, passToken, changePasswordViewModel.Password);
            if (!result.Succeeded)
            {
                throw new Exception("change password failed");
            }
        }


        public async Task<List<RoleInfoDto>> GetAllRoles()
        {
            var roles = _roleManager.Roles.ToList();
            var roleDtoList = new List<RoleInfoDto>();
            foreach (var role in roles)
            {
                var claims = await _roleManager.GetClaimsAsync(role);
                var permissions = claims.Where(x => x.Type == ApplicationClaimTypes.Permission).Select(x => _entityPermissions.GetPermissionByValue(x.Value).Name).ToList();
                roleDtoList.Add(new RoleInfoDto
                {
                    Id = role.Id,
                    Name = role.Name,
                    Permissions = permissions
                });
            }
            return await Task.FromResult(roleDtoList);
        }

        public async Task<Paginator<RoleInfoDto>> GetPageRoles(int pageSize, int pageIndex)
        {
            var dataSource = _roleManager.Roles;
            var roleDtoList = new List<RoleInfoDto>();
            var pageData = new Paginator<RoleInfoDto>();

            pageData.pageCount = dataSource.Count();
            pageData.pageIndex = pageIndex;
            pageData.pageSize = pageSize;
            var roles = await dataSource.Skip(pageSize * pageIndex).Take(pageSize).ToListAsync();

            foreach (var role in roles)
            {
                var claims = await _roleManager.GetClaimsAsync(role);
                var permissions = claims.Where(x => x.Type == ApplicationClaimTypes.Permission).Select(x => _entityPermissions.GetPermissionByValue(x.Value).Name).ToList();
                roleDtoList.Add(new RoleInfoDto
                {
                    Id = role.Id,
                    Name = role.Name,
                    Permissions = permissions
                });
            }
            pageData.data = roleDtoList;

            return pageData;
        }

        public async Task<RoleInfoDto> GetRoleAsync(string roleName)
        {

            var identityRole = await _roleManager.FindByNameAsync(roleName);
            var claims = await _roleManager.GetClaimsAsync(identityRole);
            var permissions = claims.Where(x => x.Type == ApplicationClaimTypes.Permission).Select(x => _entityPermissions.GetPermissionByValue(x.Value).Name).ToList();

            var roleDto = new RoleInfoDto
            {
                Name = roleName,
                Permissions = permissions
            };
            return roleDto;
        }

        public async Task<GroupInfoDto> GetGroup(Guid id)
        {
            var model = await _plisDbcontext.GroupInfos.FindAsync(id);
            var result = _mapper.Map<GroupInfoDto>(model);
            return result;
        }


        public async Task CreateGroupAsync(GroupInfoDto groupInfoDto)
        {
            var model = _mapper.Map<GroupInfo>(groupInfoDto);
            if (!groupInfoDto.Id.HasValue)
            {
                model.Id = Guid.NewGuid();
            }
            await _plisDbcontext.GroupInfos.AddAsync(model);

            var structDivision = new StructDivision
            {
                Id = model.Id,
                Name = model.GroupName,
                ParentId = model.ParentId
            };

            await _plisDbcontext.StructDivisions.AddAsync(structDivision);
            await _plisDbcontext.SaveChangesAsync();
        }

        public async Task UpdateGroupAsync(GroupInfoDto groupInfoDto)
        {
            var model = _plisDbcontext.GroupInfos.FirstOrDefault(u => u.Id.Equals(groupInfoDto.Id));
            if (model != null)
            {
                model.GroupName = groupInfoDto.GroupName;
                model.ParentId = groupInfoDto.ParentId;
            }
            _plisDbcontext.GroupInfos.Update(model);

            var structDivision = _plisDbcontext.StructDivisions.FirstOrDefault(u => u.Id.Equals(groupInfoDto.Id));
            if (structDivision != null)
            {
                structDivision.Name = groupInfoDto.GroupName;
                structDivision.ParentId = groupInfoDto.ParentId;
            }

            await _plisDbcontext.SaveChangesAsync();
        }

        public async Task DeleteGroupAsync(Guid id)
        {
            var group = _plisDbcontext.GroupInfos.Find(id);
            group.IsDeleted = true;
            var employGroup = _plisDbcontext.StructDivisions.Find(id);
            if (employGroup != null)
            {
                _plisDbcontext.StructDivisions.Remove(employGroup);
            }
            await _plisDbcontext.SaveChangesAsync();
        }
        public async Task<Paginator<GroupInfoDto>> GetPageGroupList(int pageSize, int pageIndex)
        {
            var dataSource = _plisDbcontext.GroupInfos;
            var pageData = new Paginator<GroupInfoDto>();
            pageData.pageCount = dataSource.Count();
            pageData.pageIndex = pageIndex;
            pageData.pageSize = pageSize;

            var result = await dataSource.Skip(pageSize * pageIndex).Take(pageSize).ToListAsync();
            pageData.data = _mapper.Map<List<GroupInfoDto>>(result);

            return pageData;
        }

        public async Task<List<GroupInfoDto>> GetGroupList()
        {
            var data = _plisDbcontext.GroupInfos;
            var result = _mapper.Map<List<GroupInfoDto>>(data);
            return await Task.FromResult(result);
        }
    }
}

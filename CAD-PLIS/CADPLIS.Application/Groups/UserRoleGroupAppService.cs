using AutoMapper;
using CADPLIS.Application.Contracts.Groups;
using CADPLIS.Application.Contracts.Users;
using CADPLIS.Domain;
using CADPLIS.Domain.Groups;
using CADPLIS.EntityFrameworkCore.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CADPLIS.Application.Contracts.Roles;
using CADPLIS.Application.Contracts.GeneralActionLogs;
using CADPLIS.Common;
using CADPLIS.Domain.GeneralActionLogs;
using CADPLIS.Common.consts;

namespace CADPLIS.Application.Groups
{
    public class UserRoleGroupAppService : IUserRoleGroupAppService
    {
        private readonly IMapper _mapper;
        private readonly PlisDbcontext _plisDbcontext;
        private readonly IUserRoleAppService _userRoleAppService;
        private readonly IRoleAppService _roleAppService;
        private readonly IUserRoleGroupRepository _userRoleGroupRepository;
        private readonly IUnitOfWork _unitOfWork;
        public UserRoleGroupAppService(IMapper mapper, PlisDbcontext plisDbcontext, IUserRoleGroupRepository userRoleGroupRepository,
            IUserRoleAppService userRoleAppService, IRoleAppService roleAppService, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _plisDbcontext = plisDbcontext;
            _userRoleGroupRepository = userRoleGroupRepository;
            _userRoleAppService = userRoleAppService;
            _roleAppService = roleAppService;
            _unitOfWork = unitOfWork;
        }
        public async Task AddAsync(UserRoleGroupDto userRoleGroupDto)
        {
            var dbModel = _mapper.Map<UserRoleGroup>(userRoleGroupDto);
            _plisDbcontext.UserRoleGroups.Add(dbModel);
            await _plisDbcontext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var dbModel = await _userRoleGroupRepository.FindAsync(u => u.Id.Equals(id));
            if (dbModel != null)
            {
                await _userRoleGroupRepository.DeleteAsync(dbModel, true);
            }
            await Task.CompletedTask;
        }

        public async Task<UserRoleGroupDto> GetByIdAsync(int id)
        {
            var dataSource = await _plisDbcontext.UserRoleGroups.Where(u => u.Id.Equals(id)).Join(_plisDbcontext.PlisUserRoles, u => u.UserRoleId, r => r.UserRoleId, (u, r) => new UserRoleGroupDto
            {
                Id = u.Id,
                UserId = r.UserId,
                RoleId = r.RoleId,
                GroupId = u.GroupId,
                CreatedBy = r.CreatedBy,
                CreatedTime = r.CreatedTime,
                CreatedUserRoleId = r.CreatedUserRoleId,
                UpdatedBy = r.UpdatedBy,
                UpdatedTime = r.UpdatedTime,
                UpdatedUserRoleId = r.UpdatedUserRoleId
            }).FirstOrDefaultAsync();
            return dataSource;
        }

        public async Task<Paginator<UserRoleGroupDto>> GetPageListAsync(int pageSize, int pageIndex, int id, string userId, string roleId)
        {
            Paginator<UserRoleGroupDto> page = new Paginator<UserRoleGroupDto>();
            var dataSource = _plisDbcontext.UserRoleGroups.Join(_plisDbcontext.PlisUserRoles, u => u.UserRoleId, r => r.UserRoleId, (u, r) => new UserRoleGroupDto
            {
                Id = u.Id,
                UserId = r.UserId,
                RoleId = r.RoleId,
                GroupId = u.GroupId,
                CreatedBy = r.CreatedBy,
                CreatedTime = r.CreatedTime,
                CreatedUserRoleId = r.CreatedUserRoleId,
                UpdatedBy = r.UpdatedBy,
                UpdatedTime = r.UpdatedTime,
                UpdatedUserRoleId = r.UpdatedUserRoleId
            });

            if (id != default)
            {
                dataSource = dataSource.Where(u => u.Id.Equals(id));
            }
            if (userId != default)
            {
                dataSource = dataSource.Where(u => u.UserId.Equals(userId));
            }
            if (roleId != default)
            {
                dataSource = dataSource.Where(u => u.RoleId.Equals(roleId));
            }
            page.pageCount = dataSource.Count();
            dataSource = dataSource.Skip(pageSize * pageIndex).Take(pageSize);
            var list = await dataSource.AsNoTracking().ToListAsync();
            page.data = _mapper.Map<List<UserRoleGroupDto>>(list);
            page.pageIndex = pageIndex;
            page.pageSize = pageSize;
            return page;
        }

        public async Task<List<UserRoleGroupDto>> GetListAsync(string userId, string roleId)
        {
            var info = await _roleAppService.GetByRoleIdAsync(roleId);
            var dataSource = _plisDbcontext.UserRoleGroups.Join(_plisDbcontext.PlisUserRoles, u => u.UserRoleId, r => r.UserRoleId, (u, r) => new UserRoleGroupDto
            {
                Id = u.Id,
                UserId = r.UserId,
                RoleId = r.RoleId,
                GroupId = u.GroupId,
                CreatedBy = r.CreatedBy,
                CreatedTime = r.CreatedTime,
                CreatedUserRoleId = r.CreatedUserRoleId,
                UpdatedBy = r.UpdatedBy,
                UpdatedTime = r.UpdatedTime,
                UpdatedUserRoleId = r.UpdatedUserRoleId,
                RoleName = info.RoleDescription
            });

            if (!string.IsNullOrEmpty(userId))
            {
                dataSource = dataSource.Where(u => u.UserId.Equals(userId));
            }
            if (!string.IsNullOrEmpty(roleId))
            {
                dataSource = dataSource.Where(u => u.RoleId.Equals(roleId));
            }
            return await dataSource.AsNoTracking().ToListAsync();

        }


        public async Task UpdateAsync(UserRoleGroupDto userRoleGroupDto)
        {
            var list = await GetListAsync(userRoleGroupDto.UserId, userRoleGroupDto.RoleId);
            var info = await _userRoleAppService.GetByUserIdAndRoleIdAsync(userRoleGroupDto.UserId, userRoleGroupDto.RoleId);
        
            List<UserRoleGroup> listAdd = new List<UserRoleGroup>();

            foreach (var item in userRoleGroupDto.GroupIds)
            {
                if (!list.Any(u => u.GroupId.Equals(item)))
                {
                    var newModel = new UserRoleGroup
                    {
                        UserRoleId = info.UserRoleId,
                        GroupId = item,
                        CreatedBy = "admin",
                        CreatedTime = DateTime.Now,
                        CreatedUserRoleId = "Administrator"
                    };
                    listAdd.Add(newModel);
                }
            }
            if (listAdd.Any())
            {
                _plisDbcontext.UserRoleGroups.AddRange(listAdd);
            }

            foreach (var item in list)
            {
                if (!userRoleGroupDto.GroupIds.Contains(item.GroupId))
                {
                    var model = await _userRoleGroupRepository.FindAsync(u => u.UserRoleId == info.UserRoleId && u.GroupId == item.GroupId);
                    if (model != null)
                    {
                        await _userRoleGroupRepository.DeleteAsync(model);
                        var log = new GeneralActionLog
                        {
                            Key = userRoleGroupDto.UserId,
                            SubKey= userRoleGroupDto.RoleId,
                            Form = "PLIS_USER_ROLE_GROUP",
                            ActionType = OperAction.Delete,
                            Action = OperUiConsts.Delete,
                            ActionBy = "admin",
                            ActionByRole = "administrator",
                            ActionDatetime = DateTime.Now
                        };
                        _plisDbcontext.GeneralActionLogs.Add(log);
                    }
                }
            }
            await _unitOfWork.SaveChangeAsync();

            if (listAdd.Any())
            {
                foreach (var item in listAdd)
                {
                    var log = new GeneralActionLog
                    {
                        Key = userRoleGroupDto.UserId,
                        SubKey= userRoleGroupDto.RoleId,
                        Form = "PLIS_USER_ROLE_GROUP",
                        ActionType = OperAction.Insert,
                        Action = OperUiConsts.Save,
                        ActionBy = "admin",
                        ActionByRole = "administrator",
                        ActionDatetime = DateTime.Now
                    };
                    _plisDbcontext.GeneralActionLogs.Add(log);
                }
                await _unitOfWork.SaveChangeAsync();
            }
        }
    }
}

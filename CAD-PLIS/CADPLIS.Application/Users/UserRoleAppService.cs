using AutoMapper;
using CADPLIS.Application.Contracts.GeneralActionLogs;
using CADPLIS.Application.Contracts.References;
using CADPLIS.Application.Contracts.Users;
using CADPLIS.Common;
using CADPLIS.Common.consts;
using CADPLIS.Domain;
using CADPLIS.Domain.GeneralActionLogs;
using CADPLIS.Domain.Users;
using CADPLIS.EntityFrameworkCore.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Application.Users
{
    public class UserRoleAppService : IUserRoleAppService
    {
        private readonly IMapper _mapper;
        private readonly PlisDbcontext _plisDbcontext;
        private readonly IUserRoleRepository _userRoleRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IGeneralActionLogRepository _generalActionLogRepository;
        public UserRoleAppService(IMapper mapper, PlisDbcontext plisDbcontext, IUserRoleRepository userRoleRepository, IUnitOfWork unitOfWork, IGeneralActionLogRepository generalActionLogRepository)
        {
            _mapper = mapper;
            _plisDbcontext = plisDbcontext;
            _userRoleRepository = userRoleRepository;
            _unitOfWork = unitOfWork;
            _generalActionLogRepository = generalActionLogRepository;
        }
        public async Task Insert(UserRoleDto model)
        {
            var res = await _userRoleRepository.FindListAsync(model.UserId,"");
            foreach (var item in res)
            {
                if (!model.Roles.Contains(item.RoleId))
                {
                    await _userRoleRepository.DeleteAsync(item);
                    GeneralActionLog logmodel = new GeneralActionLog();
                    logmodel.Form = "PLIS_USER_ROLE";
                    logmodel.ActionBy = "admin";
                    logmodel.ActionByRole = "Administrator";
                    logmodel.ActionDatetime = DateTime.Now;
                    logmodel.Key = item.UserId;
                    logmodel.SubKey = item.RoleId;
                    //logmodel.Action = "Delete";
                    logmodel.Action = OperUiConsts.Save;
                    logmodel.ActionType = OperAction.Delete;

                    await _generalActionLogRepository.InsertAsync(logmodel);
                }
            }
            List<UserRole> userrolelist = new List<UserRole>();
            foreach (var item in model.Roles)
            {
                var usermodel = _mapper.Map<UserRole>(model);
                usermodel.RoleId = item;
                var result = await _userRoleRepository.FindListAsync(usermodel.UserId, usermodel.RoleId);
                if (result.Count==0)
                {
                    userrolelist.Add(usermodel);

                }
            }
            if (userrolelist.Count > 0)
            {
               await  _userRoleRepository.InsertRangeAsync(userrolelist);
            }
            foreach (var item in userrolelist)
            {
                GeneralActionLog logmodel = new GeneralActionLog();
                logmodel.Form = "PLIS_USER_ROLE";
                logmodel.ActionBy = "admin";
                logmodel.ActionByRole = "Administrator";
                logmodel.ActionDatetime = DateTime.Now;
                logmodel.Key = item.UserId;
                logmodel.SubKey = item.RoleId;
                //logmodel.Action = "Insert";
                logmodel.Action = OperUiConsts.Save;
                logmodel.ActionType = OperAction.Insert;

                await _generalActionLogRepository.InsertAsync(logmodel);
            }
            await _unitOfWork.SaveChangeAsync();
        }

        public async Task Update(UserRoleDto model)
        {

            var res =await _userRoleRepository.FindListAsync(model.UserId, ""); //_plisDbcontext.PlisUserRoles.Where(u => u.UserId == model.UserId).ToList();
            foreach (var item in res)
            {
                if (!model.Roles.Contains(item.RoleId))
                {
                    await _userRoleRepository.DeleteAsync(item);
                    GeneralActionLog logmodel = new GeneralActionLog();
                    logmodel.Form = "PLIS_USER_ROLE";
                    logmodel.ActionBy = "admin";
                    logmodel.ActionByRole = "Administrator";
                    logmodel.ActionDatetime = DateTime.Now;
                    logmodel.Key = item.UserId;
                    logmodel.SubKey = item.RoleId;
                    //logmodel.Action = "Delete";
                    logmodel.Action = OperUiConsts.Save;
                    logmodel.ActionType = OperAction.Delete;

                    await _generalActionLogRepository.InsertAsync(logmodel);
                }
            }
            List<UserRole> userrolelist = new List<UserRole>();
            foreach (var item in model.Roles)
            {
                var tempmodel = _mapper.Map<UserRole>(model);
                var dbModel = new UserRole();
                dbModel.RoleId = item;
                dbModel.UserId = tempmodel.UserId;
                dbModel.CreatedBy = "admin";
                dbModel.CreatedTime = DateTime.Now;
                dbModel.CreatedUserRoleId = "Administrator";
                var result = await _userRoleRepository.FindListAsync(dbModel.UserId, dbModel.RoleId);  
                if (result.Count==0)
                {
                    userrolelist.Add(dbModel);
                }

            }

            if (userrolelist.Count > 0)
            {
                await _userRoleRepository.InsertRangeAsync(userrolelist);
            }
            foreach (var item in userrolelist)
            {
                GeneralActionLog logmodel = new GeneralActionLog();
                logmodel.Form = "PLIS_USER_ROLE";
                logmodel.ActionBy = "admin";
                logmodel.ActionByRole = "Administrator";
                logmodel.ActionDatetime = DateTime.Now;
                logmodel.Key = item.UserId;
                logmodel.SubKey = item.RoleId;
                //logmodel.Action = "Insert";
                logmodel.Action = OperUiConsts.Save;
                logmodel.ActionType = OperAction.Insert;

                await _generalActionLogRepository.InsertAsync(logmodel);
            }
            await _unitOfWork.SaveChangeAsync();

        }
        public async Task<Paginator<UserRoleDto>> GetListBySearchAsync(int pageSize, int pageIndex, string userId)
        {
            Paginator<UserRoleDto> page = new Paginator<UserRoleDto>();
            var userdb = _plisDbcontext.PlisUserRoles.AsQueryable();
            if (!string.IsNullOrEmpty(userId) && !userId.Equals("0"))
            {
                userdb = userdb.Where(u => u.UserId.Contains(userId));
            }
            var result = await userdb.Join(_plisDbcontext.RoleInfos, u => u.RoleId, r => r.RoleId, (u, r) => new UserRoleDto
            {
                RoleName = r.RoleDescription,
                RoleId = u.RoleId,
                UserId = u.UserId,
                UserRoleId = u.UserRoleId,
                CreatedBy = u.CreatedBy,
                CreatedTime = u.CreatedTime,
                CreatedUserRoleId = u.CreatedUserRoleId,
                UpdatedBy = u.UpdatedBy,
                UpdatedTime = u.UpdatedTime,
                UpdatedUserRoleId = u.UpdatedUserRoleId
            })
             .OrderByDescending(u => u.CreatedTime).Skip(pageSize * pageIndex).Take(pageSize).AsNoTracking().ToListAsync();
            page.data = _mapper.Map<List<UserRoleDto>>(result);
            page.pageCount = userdb.Count();
            page.pageSize = pageSize;
            page.pageIndex = pageIndex;
            return page;
        }
        public async Task<UserRoleDto> GetByIdAsync(int id)
        {
            var model = await _userRoleRepository.FindByIdAsync(id); //_plisDbcontext.FindAsync<UserRole>(id);
            var result = _mapper.Map<UserRoleDto>(model);
            return result;
        }

        public async Task<UserRoleDto> GetByUserIdAndRoleIdAsync(string userId, string roleId)
        {
            var model = await _userRoleRepository.FindByUserIdAndRoleIdAsync(userId,roleId); //_plisDbcontext.PlisUserRoles.FirstOrDefaultAsync(u => u.UserId.Equals(userId) && u.RoleId.Equals(roleId));
            var result = new UserRoleDto();
            if (model != null)
            {
                result = _mapper.Map<UserRoleDto>(model);
            }
            return result;
        }


        public async Task<List<UserRoleDto>> GetRoleByUserId(string userId)
        {
            var list = await _plisDbcontext.PlisUserRoles.Where(r => r.UserId == userId).Join(_plisDbcontext.RoleInfos, u => u.RoleId, r => r.RoleId, (u, r) => new UserRoleDto
            {
                RoleName = r.RoleDescription,
                RoleId = u.RoleId,
                UserId = u.UserId,
                UserRoleId = u.UserRoleId,
                CreatedBy = u.CreatedBy,
                CreatedTime = u.CreatedTime,
                CreatedUserRoleId = u.CreatedUserRoleId,
                UpdatedBy = u.UpdatedBy,
                UpdatedTime = u.UpdatedTime,
                UpdatedUserRoleId = u.UpdatedUserRoleId
            }).AsNoTracking().ToListAsync();
            var result = _mapper.Map<List<UserRoleDto>>(list);
            return result;
        }
        public async Task DeleteAsync(int id)
        {
            var model = await _userRoleRepository.FindByIdAsync(id); 
            if (model != null)
            {
                await _userRoleRepository.DeleteAsync(model); 
            }
            await _unitOfWork.SaveChangeAsync(); 
        }


        public async Task<List<UserRoleDto>> GetListAsync()
        {
            var result = await _plisDbcontext.PlisUserRoles.Join(_plisDbcontext.RoleInfos, u => u.RoleId, r => r.RoleId, (u, r) => new UserRoleDto
            {
                RoleName = r.RoleDescription,
                RoleId = u.RoleId,
                UserId = u.UserId,
                UserRoleId = u.UserRoleId,
                CreatedBy = u.CreatedBy,
                CreatedTime = u.CreatedTime,
                CreatedUserRoleId = u.CreatedUserRoleId,
                UpdatedBy = u.UpdatedBy,
                UpdatedTime = u.UpdatedTime,
                UpdatedUserRoleId = u.UpdatedUserRoleId
            }).AsNoTracking().ToListAsync();
            return await Task.FromResult(result);
        }
    }
}

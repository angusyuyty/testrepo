using AutoMapper;
using CADPLIS.Application.Contracts.Functions;
using CADPLIS.Application.Contracts.GeneralActionLogs;
using CADPLIS.Common;
using CADPLIS.Common.consts;
using CADPLIS.Domain;
using CADPLIS.Domain.Functions;
using CADPLIS.Domain.GeneralActionLogs;
using CADPLIS.Domain.NavMenus;
using CADPLIS.EntityFrameworkCore.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Application.Functions
{
    public class GroupAccessibleFunctionAppService : IGroupAccessibleFunctionAppService
    {
        private readonly IMapper _mapper;
        private readonly PlisDbcontext _plisDbcontext;
        private readonly IGroupAccessibleFunctionRepository _groupAccessibleFunctionRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IGeneralActionLogRepository _generalActionLogRepository;
        private readonly INavMenuRepository _navMenuRepository;
        private readonly IFunctionRepository _functionRepository;
        public GroupAccessibleFunctionAppService(IMapper mapper, PlisDbcontext plisDbcontext, IGeneralActionLogRepository generalActionLogRepository, IUnitOfWork unitOfWork, IGroupAccessibleFunctionRepository groupAccessibleFunctionRepository, INavMenuRepository navMenuRepository, IFunctionRepository functionRepository)
        {
            _mapper = mapper;
            _plisDbcontext = plisDbcontext;
            _generalActionLogRepository = generalActionLogRepository;
            _unitOfWork = unitOfWork;
            _groupAccessibleFunctionRepository = groupAccessibleFunctionRepository;
            _navMenuRepository = navMenuRepository;
            _functionRepository = functionRepository;
        }
        public async Task Insert(GroupAccessibleFunctionDto model)
        {
            var res = await _groupAccessibleFunctionRepository.FindListAsync(model.GroupId, "");
            foreach (var item in res)
            {
                if (!model.Functions.Contains(item.FunctionId))
                {
                    await _groupAccessibleFunctionRepository.DeleteAsync(item);
                    GeneralActionLog logmodel = new GeneralActionLog();
                    logmodel.Form = "PLIS_GROUP_ACCESSIBLE_FUNCTION";
                    logmodel.ActionBy = "admin";
                    logmodel.ActionByRole = "Administrator";
                    logmodel.ActionDatetime = DateTime.Now;
                    logmodel.Key = item.GroupId;
                    logmodel.SubKey = item.FunctionId;
                    logmodel.Action = OperUiConsts.Save;
                    logmodel.ActionType = OperAction.Delete;
                    await _generalActionLogRepository.InsertAsync(logmodel);
                }
            }
            List<GroupAccessibleFunction> glist = new List<GroupAccessibleFunction>();
            foreach (var item in model.Functions)
            {
                var gmodel = _mapper.Map<GroupAccessibleFunction>(model);
                gmodel.FunctionId = item;
                var result = await _groupAccessibleFunctionRepository.FindListAsync(gmodel.GroupId, gmodel.FunctionId);
                if (result.Count == 0)
                {
                    glist.Add(gmodel);
                }
            }
            if (glist.Count > 0)
            {
                await _groupAccessibleFunctionRepository.InsertRangeAsync(glist);
            }
            foreach (var item in glist)
            {
                GeneralActionLog logmodel = new GeneralActionLog();
                logmodel.Form = "PLIS_GROUP_ACCESSIBLE_FUNCTION";
                logmodel.ActionBy = "admin";
                logmodel.ActionByRole = "Administrator";
                logmodel.ActionDatetime = DateTime.Now;
                logmodel.Key = item.GroupId;
                logmodel.SubKey = item.FunctionId;
                //logmodel.Action = "Insert";
                logmodel.Action = OperUiConsts.Save;
                logmodel.ActionType = OperAction.Insert;

                await _generalActionLogRepository.InsertAsync(logmodel);
            }
            await _unitOfWork.SaveChangeAsync();
        }

        public async Task Update(GroupAccessibleFunctionDto model)
        {

            var res = await _groupAccessibleFunctionRepository.FindListAsync(model.GroupId, "");
            foreach (var item in res)
            {
                if (!model.Functions.Contains(item.FunctionId))
                {
                    await _groupAccessibleFunctionRepository.DeleteAsync(item);
                    GeneralActionLog logmodel = new GeneralActionLog();
                    logmodel.Form = "PLIS_GROUP_ACCESSIBLE_FUNCTION";
                    logmodel.ActionBy = "admin";
                    logmodel.ActionByRole = "Administrator";
                    logmodel.ActionDatetime = DateTime.Now;
                    logmodel.Key = item.GroupId;
                    logmodel.SubKey = item.FunctionId;
                    //logmodel.Action = "Delete";
                    logmodel.Action = OperUiConsts.Save;
                    logmodel.ActionType = OperAction.Delete;
                    await _generalActionLogRepository.InsertAsync(logmodel);
                }
            }
            List<GroupAccessibleFunction> glist = new List<GroupAccessibleFunction>();
            foreach (var item in model.Functions)
            {
                var tempmodel = _mapper.Map<GroupAccessibleFunction>(model);
                var dbModel = new GroupAccessibleFunction();
                dbModel.FunctionId = item;
                dbModel.GroupId = tempmodel.GroupId;
                dbModel.CreatedBy = "admin";
                dbModel.CreatedTime = DateTime.Now;
                dbModel.CreatedUserRoleId = "Administrator";
                var result = await _groupAccessibleFunctionRepository.FindListAsync(dbModel.GroupId, dbModel.FunctionId);
                if (result.Count == 0)
                {
                    glist.Add(dbModel);
                }

            }

            if (glist.Count > 0)
            {
                await _groupAccessibleFunctionRepository.InsertRangeAsync(glist);
            }

            foreach (var item in glist)
            {
                GeneralActionLog logmodel = new GeneralActionLog();
                logmodel.Form = "PLIS_GROUP_ACCESSIBLE_FUNCTION";
                logmodel.ActionBy = "admin";
                logmodel.ActionByRole = "Administrator";
                logmodel.ActionDatetime = DateTime.Now;
                logmodel.Key = item.GroupId;
                logmodel.SubKey = item.FunctionId;
                //logmodel.Action = "Insert";
                logmodel.Action = OperUiConsts.Save;
                logmodel.ActionType = OperAction.Insert;
                await _generalActionLogRepository.InsertAsync(logmodel);
            }
            await _unitOfWork.SaveChangeAsync();
        }
        public async Task<Paginator<GroupAccessibleFunctionDto>> GetListBySearchAsync(int pageSize, int pageIndex, string gId, string gname)
        {
            Paginator<GroupAccessibleFunctionDto> page = new Paginator<GroupAccessibleFunctionDto>();
            var groupdb = _plisDbcontext.GroupAccessibleFunctions.AsQueryable();
            if (!string.IsNullOrEmpty(gId) && !gId.Equals("0"))
            {
                groupdb = groupdb.Where(u => u.GroupId.Contains(gId));
            }
            page.pageCount = groupdb.Count();
            if (!string.IsNullOrEmpty(gname))
            {
                var result = await (from gf in groupdb
                                    join g in _plisDbcontext.PlisGroups.Where(g => g.GroupDescription.Contains(gname)) on gf.GroupId equals g.GroupId
                                    select new GroupAccessibleFunctionDto
                                    {
                                        //FunctionName = f.FunctionDescription,
                                        //FunctionType = f.FunctionType,
                                        GroupName = g.GroupDescription,
                                        GroupId = gf.GroupId,
                                        FunctionId = gf.FunctionId,
                                        Id = gf.Id,
                                        CreatedBy = gf.CreatedBy,
                                        CreatedTime = gf.CreatedTime,
                                        CreatedUserRoleId = gf.CreatedUserRoleId,
                                        UpdatedBy = gf.UpdatedBy,
                                        UpdatedTime = gf.UpdatedTime,
                                        UpdatedUserRoleId = gf.UpdatedUserRoleId
                                    }
                                    ).OrderByDescending(u => u.CreatedTime).AsNoTracking().ToListAsync();
                page.pageCount = result.Count();
                result = result.Skip(pageSize * pageIndex).Take(pageSize).ToList();
                page.data = _mapper.Map<List<GroupAccessibleFunctionDto>>(result);
            }
            else
            {
                var result = await (from gf in groupdb
                                    join g in _plisDbcontext.PlisGroups on gf.GroupId equals g.GroupId
                                    select new GroupAccessibleFunctionDto
                                    {
                                        //FunctionName = f.FunctionDescription,
                                        // FunctionType = f.FunctionType,
                                        GroupName = g.GroupDescription,
                                        GroupId = gf.GroupId,
                                        FunctionId = gf.FunctionId,
                                        Id = gf.Id,
                                        CreatedBy = gf.CreatedBy,
                                        CreatedTime = gf.CreatedTime,
                                        CreatedUserRoleId = gf.CreatedUserRoleId,
                                        UpdatedBy = gf.UpdatedBy,
                                        UpdatedTime = gf.UpdatedTime,
                                        UpdatedUserRoleId = gf.UpdatedUserRoleId
                                    }
                                   ).OrderByDescending(u => u.CreatedTime).Skip(pageSize * pageIndex).Take(pageSize).AsNoTracking().ToListAsync();
                var fresult = result.Select(r => r.FunctionId).Distinct();
                var menuList = await _navMenuRepository.GetListAsync(u => fresult.Contains(u.MenuId));
                foreach (var item in result)
                {
                    var first = menuList.FirstOrDefault(u => u.MenuId.Equals(item.FunctionId));
                    if (first != null)
                    {
                        item.FunctionType = "menu";
                        item.FunctionName = first.MenuDescription;
                    }
                }

                var groupfunctionList = result.Where(u => string.IsNullOrEmpty(u.FunctionName));
                var functionList = await _functionRepository.GetListAsync(u => fresult.Contains(u.FunctionId));
                foreach (var function in groupfunctionList)
                {
                    var first = functionList.FirstOrDefault(u => u.FunctionId.Equals(function.FunctionId));
                    if (first != null)
                    {
                        function.FunctionType = "system";
                        function.FunctionName = first.FunctionDescription;
                    }
                }
                page.data = _mapper.Map<List<GroupAccessibleFunctionDto>>(result);
            }

            page.pageSize = pageSize;
            page.pageIndex = pageIndex;
            return page;
        }
        public async Task<GroupAccessibleFunctionDto> GetByIdAsync(int id)
        {
            var model = await _groupAccessibleFunctionRepository.FindAsync(u => u.Id.Equals(id));
            var result = _mapper.Map<GroupAccessibleFunctionDto>(model);
            return result;
        }
        public async Task<List<GroupAccessibleFunctionDto>> GetFunctionByGroupId(string gId)
        {
            var list = await _groupAccessibleFunctionRepository.FindListAsync(gId, "");
            var result = _mapper.Map<List<GroupAccessibleFunctionDto>>(list);
            return result;
        }

        public async Task<List<GroupAccessibleFunctionDto>> GetFunctionByGroupIds(List<string> gIds)
        {
            var list = await _groupAccessibleFunctionRepository.GetListAsync(u => gIds.Contains(u.GroupId));
            var result = _mapper.Map<List<GroupAccessibleFunctionDto>>(list);
            return result;
        }


        public async Task DeleteAsync(int id)
        {
            var model = await _groupAccessibleFunctionRepository.FindAsync(u => u.Id.Equals(id));
            if (model != null)
            {
                await _groupAccessibleFunctionRepository.DeleteAsync(model);
            }
            await _unitOfWork.SaveChangeAsync();
        }
    }
}

using AutoMapper;
using CADPLIS.Application.Contracts;
using CADPLIS.Application.Contracts.Functions;
using CADPLIS.Application.Contracts.NavMenus;
using CADPLIS.Common;
using CADPLIS.Common.consts;
using CADPLIS.Server.Application.Events;
using CADPLIS.Server.AuditLog;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CADPLIS.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupAccessibleFunctionController : ControllerBase
    {
        private readonly IGroupAccessibleFunctionAppService _groupAccessibleFunctionAppService;
        private readonly INavMenuAppService _navMenuAppService;
        private readonly IFunctionAppService _functionAppService;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public GroupAccessibleFunctionController(IGroupAccessibleFunctionAppService groupAccessibleFunctionAppService, IMapper mapper, IMediator mediator, INavMenuAppService navMenuAppService, IFunctionAppService functionAppService)
        {
            _mapper = mapper;
            _groupAccessibleFunctionAppService = groupAccessibleFunctionAppService;
            _mediator = mediator;
            _navMenuAppService = navMenuAppService;
            _functionAppService = functionAppService;
        }
        [Route("GetPageList/pageSize/{pageSize}/pageIndex/{pageIndex}")]
        [HttpGet]
        public async Task<ApiResponse> GetPageList(int pageSize, int pageIndex, string gId,string gname)
        {
            var result = await _groupAccessibleFunctionAppService.GetListBySearchAsync(pageSize, pageIndex, gId, gname);
            return new ApiResponse(StatusCodes.Status200OK, OperResult.Success, result);
        }
        [Route("Get/{id}")]
        [HttpGet]
        public async Task<ApiResponse> GetById(int id)
        {
            var result = await _groupAccessibleFunctionAppService.GetByIdAsync(id);
            return new ApiResponse(StatusCodes.Status200OK, OperResult.Success, result);
        }
        [HttpGet]
        [Route("GetFunctionByGroupId")]
        public async Task<ApiResponse> GetFunctionByGroupId(string gId)
        {
            var result = await _groupAccessibleFunctionAppService.GetFunctionByGroupId(gId);

            return new ApiResponse(StatusCodes.Status200OK, OperResult.Success, result.Select(r => r.FunctionId).ToList());
        }
        [Route("Insert")]
        [HttpPost]
        public async Task<ApiResponse> Insert(GroupAccessibleFunctionDto model)
        {
            if (ModelState.IsValid)
            {
                model.CreatedBy = "admin";
                model.CreatedTime = DateTime.Now;
                model.CreatedUserRoleId = "Administrator";
                await _groupAccessibleFunctionAppService.Insert(model);

                return new ApiResponse(StatusCodes.Status200OK, OperResult.Success);
            }
            return new ApiResponse(StatusCodes.Status400BadRequest, "Insert Error!");
        }
        [Route("Update")]
        [HttpPut]
        public async Task<ApiResponse> Update(GroupAccessibleFunctionDto model)
        {
            if (ModelState.IsValid)
            {
                model.UpdatedBy = "admin";
                model.UpdatedTime = DateTime.Now;
                model.UpdatedUserRoleId = "Administrator";

                await _groupAccessibleFunctionAppService.Update(model);
                return new ApiResponse(StatusCodes.Status200OK, OperResult.Success);

            }
            return new ApiResponse(StatusCodes.Status400BadRequest, "Update Error!");
        }
        [Route("Delete/{id}")]
        [HttpDelete]
        public async Task<ApiResponse> Delete(int id)
        {
            if (string.IsNullOrEmpty(id.ToString()))
            {
                return new ApiResponse(StatusCodes.Status400BadRequest, "the delete object can not be null!");
            }
            var gfmodel = await _groupAccessibleFunctionAppService.GetByIdAsync(id);
            await _groupAccessibleFunctionAppService.DeleteAsync(id);
            await _mediator.Publish(new ActiveLogEvent { Key = gfmodel.GroupId,SubKey=gfmodel.FunctionId, Form = "PLIS_GROUP_ACCESSIBLE_FUNCTION", Action = OperUiConsts.Delete,ActionType = OperAction.Delete });
            return new ApiResponse(StatusCodes.Status200OK, OperResult.Success);
        }


        [Route("GetTree")]
        [HttpGet]
        [DisableAuditing]

        public async Task<ApiResponse> GetTree(string gId)
        {
            var glist = _groupAccessibleFunctionAppService.GetFunctionByGroupId(gId).Result.Select(g => g.FunctionId);
            var result = await _navMenuAppService.GetListAsync();
            var menulist = result.Select(i => new SelectTree<string>
            {
                Id = i.Id.ToString(),
                DisplayValue = i.MenuName,
                ParentId = i.ParentId,
                FId = i.MenuId,
                Selected = glist.Contains(i.MenuId)
            }).ToList();
            var firstmenu = menulist.Where(m => m.ParentId == null).ToList();
            GetTreeChild(firstmenu, menulist);
            var treeModel = new SelectTree<string>
            {
                DisplayValue = "Functions",
                Children = firstmenu.Any() ? firstmenu : new List<SelectTree<string>>()
            };
            var flist = _functionAppService.GetFunctionAsync().Result;
            var functionList = flist.Select(i => new SelectTree<string>
            {
                Id = i.Id.ToString(),
                FId = i.FunctionId,
                DisplayValue = i.FunctionDescription,
                Selected = glist.Contains(i.FunctionId)
            }).ToList();
            treeModel.Children.AddRange(functionList);
            GetFunctionsDto<string> treeResult = new GetFunctionsDto<string>();
            treeResult.treeModel = treeModel;
            treeResult.selectedFunctions = glist.ToList();
            var ar = new ApiResponse(StatusCodes.Status200OK, OperResult.Success, treeResult);
            return ar;
        }
        void GetTreeChild(List<SelectTree<string>> parentMenus, List<SelectTree<string>> allMenus)
        {
            foreach (var item in parentMenus)
            {
                var subMenus = allMenus.Where(u => u.ParentId.HasValue && u.ParentId.Equals(Convert.ToInt32(item.Id))).ToList();
                if (subMenus.Any())
                {
                    item.Children = subMenus;
                    GetTreeChild(subMenus, allMenus);
                }
            }
        }

    }
}

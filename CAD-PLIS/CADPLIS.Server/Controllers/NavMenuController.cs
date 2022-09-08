using AutoMapper;
using CADPLIS.Application.Contracts.NavMenus;
using CADPLIS.Common;
using CADPLIS.Server.AuditLog;
using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using CADPLIS.Application.Contracts.References;
using CADPLIS.Application.Contracts.Functions;
using CADPLIS.Server.Application.Events;
using MediatR;
using CADPLIS.Application.Contracts;
using CADPLIS.Application.Contracts.Groups;
using CADPLIS.Common.consts;
using CADPLIS.Common.CacheManager;

namespace CADPLIS.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    // [Authorize]
    public class NavMenuController : ControllerBase
    {
        private readonly ILogger<NavMenuController> _logger;
        private readonly IMapper _autoMapper;
        private readonly INavMenuAppService _navMenuAppService;
        private readonly IFunctionAppService _functionAppService;
        private readonly IMediator _mediator;
        private readonly IGroupAccessibleFunctionAppService _groupAccessibleFunctionAppService;
        private readonly ICacheService _cacheService;
        public NavMenuController(ILogger<NavMenuController> logger, IMapper mapper, INavMenuAppService navMenuAppService, IFunctionAppService functionAppService, IMediator mediator,
            IGroupAccessibleFunctionAppService groupAccessibleFunctionAppService, ICacheService cacheService)
        {
            _logger = logger;
            _autoMapper = mapper;
            _navMenuAppService = navMenuAppService;
            _functionAppService = functionAppService;
            _mediator = mediator;
            _groupAccessibleFunctionAppService = groupAccessibleFunctionAppService;
            _cacheService = cacheService;
        }
        [Route("Get")]
        [HttpGet]
        [DisableAuditing]

        public async Task<ApiResponse> Get()
        {
            var result = await _navMenuAppService.GetListAsync();
            var ar = new ApiResponse(StatusCodes.Status200OK, OperResult.Success, result);
            return ar;
        }

        [Route("Get/{id}")]
        [HttpGet]
        public async Task<ApiResponse> GetById(int id)
        {
            var result = await _navMenuAppService.GetByIdAsync(id);
            return new ApiResponse(StatusCodes.Status200OK, OperResult.Success, result);
        }


        [Route("GetWithChild")]
        [HttpGet]
        public async Task<ApiResponse> GetWithChild()
        {
            var navMenuList = await _navMenuAppService.GetListAsync();
            var navMenuDtoList = _autoMapper.Map<List<NavMenuDto>>(navMenuList);

            var firstMenu = navMenuDtoList.Where(u => u.ParentId == null).OrderBy(u => u.OrderNo).ToList();
            SetMenuWithChildren(firstMenu, navMenuDtoList);
            var navMenuDto = new NavMenuDto
            {
                MenuName = "Menus",
                Children = firstMenu.Any() ? firstMenu.AsEnumerable() : new List<NavMenuDto>()
            };
            return new ApiResponse(StatusCodes.Status200OK, OperResult.Success, navMenuDto);

        }

        [HttpPost]
        [Route("Create")]
        public async Task<ApiResponse> Create([FromBody] NavMenuDto navMenu)
        {
            if (ModelState.IsValid)
            {
                var menuInfo = await _navMenuAppService.GetByMenuIdAsync(navMenu.MenuId);
                if (menuInfo != null)
                {
                    return new ApiResponse(StatusCodes.Status400BadRequest, "menuid is exists!");
                }

                navMenu.CreatedBy = User.Identity.Name ?? "admin";//to do
                navMenu.CreatedTime = DateTime.Now;
                navMenu.CreatedUserRoleId = _cacheService.Get("CurrentRole") ?? "Administrator";
                await _navMenuAppService.Insert(navMenu);

                await _mediator.Publish(new ActiveLogEvent { Key = navMenu.MenuId, Form = "PLIS_NAVMENU", Action = OperUiConsts.Save, ActionType = OperAction.Insert });

                return new ApiResponse(StatusCodes.Status200OK, OperResult.Success);
            }
            else
            {
                return new ApiResponse(StatusCodes.Status400BadRequest, OperResult.Error);
            }
        }
        [HttpPut]
        [Route("Update")]
        public async Task<ApiResponse> Update(NavMenuDto navMenu)
        {
            if (ModelState.IsValid)
            {
                await _navMenuAppService.Update(navMenu);

                await _mediator.Publish(new ActiveLogEvent { Key = navMenu.MenuId, Form = "PLIS_NAVMENU", Action = OperUiConsts.Save, ActionType = OperAction.Update });

                return new ApiResponse(StatusCodes.Status200OK, OperResult.Success);
            }
            return new ApiResponse(StatusCodes.Status400BadRequest, OperResult.Error);
        }

        [HttpGet]
        [Route("GetPageList/pageSize/{pageSize}/pageIndex/{pageIndex}")]
        public async Task<ApiResponse> GetPageList(int pageSize, int pageIndex, int menuType, string menuName)
        {
            var result = await _navMenuAppService.GetPageListAsync(pageSize, pageIndex, menuType, menuName);
            return new ApiResponse(StatusCodes.Status200OK, OperResult.Success, result);
        }

        [HttpGet]
        [Route("HaveChild/{id}")]
        public async Task<ApiResponse> HaveChild(int id)
        {
            var result = await _navMenuAppService.HaveChild(id);
            return new ApiResponse(StatusCodes.Status200OK, OperResult.Success, result);
        }


        [HttpDelete]
        [Route("Delete/{id}")]
        public async Task<ApiResponse> Delete([FromRoute] int id)
        {
            var model = await _navMenuAppService.GetByIdAsync(id);
            await _navMenuAppService.DeleteAsync(id);

            await _mediator.Publish(new ActiveLogEvent { Key = model.MenuId, Form = "PLIS_NAVMENU", Action = OperUiConsts.Delete, ActionType = OperAction.Delete });
            return new ApiResponse(StatusCodes.Status200OK, OperResult.Success);
        }

        void SetMenuWithChildren(List<NavMenuDto> parentMenus, List<NavMenuDto> allMenus)
        {
            foreach (var item in parentMenus)
            {
                var subMenus = allMenus.Where(u => u.ParentId.HasValue && u.ParentId.Equals(item.Id)).OrderBy(u => u.OrderNo).ToList();
                if (subMenus.Any())
                {
                    item.Children = subMenus;
                    SetMenuWithChildren(subMenus, allMenus);
                }
            }
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


        [Route("GetPermissionMenuWithChilds")]
        [HttpGet]
        public async Task<ApiResponse> GetPermissionMenuWithChilds(string role)
        {
            var currentUserId = User.Identity.Name;
            var list = await _navMenuAppService.GetPermissionNavMenu(currentUserId, role);

            var firstMenu = list.Where(u => u.ParentId == null).OrderBy(u => u.OrderNo).ToList();
            SetMenuWithChildren(firstMenu, list);
            var navMenuDto = new NavMenuDto
            {
                MenuName = "Menus",
                Children = firstMenu.Any() ? firstMenu.AsEnumerable() : new List<NavMenuDto>()
            };

            return new ApiResponse(StatusCodes.Status200OK, OperResult.Success, navMenuDto);
        }
    }
}

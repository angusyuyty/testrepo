using AutoMapper;
using CADPLIS.Application.Contracts.Functions;
using CADPLIS.Application.Contracts.Groups;
using CADPLIS.Application.Contracts.NavMenus;
using CADPLIS.Application.Contracts.Users;
using CADPLIS.Domain;
using CADPLIS.Domain.NavMenus;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CADPLIS.Application.NavMenus
{
    public class NavMenuAppService : INavMenuAppService
    {
        private readonly IMapper _autoMapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly INavMenuRepository _navMenuRepository;
        private readonly IUserRoleGroupAppService _userRoleGroupAppService;
        private readonly IGroupAccessibleFunctionAppService _groupAccessibleFunctionAppService;
        public NavMenuAppService(IMapper mapper, IUnitOfWork unitOfWork, INavMenuRepository navMenuRepository, IUserRoleAppService userRoleAppService, IUserRoleGroupAppService userRoleGroupAppService, 
            IGroupAccessibleFunctionAppService groupAccessibleFunctionAppService)
        {
            _autoMapper = mapper;
            _unitOfWork = unitOfWork;
            _navMenuRepository = navMenuRepository;
            _userRoleGroupAppService = userRoleGroupAppService;
            _groupAccessibleFunctionAppService=groupAccessibleFunctionAppService;
        }

        public async Task Insert(NavMenuDto model)
        {
            var navMenu = _autoMapper.Map<PlisNavMenu>(model);
            await _navMenuRepository.InsertAsync(navMenu, true);
            model.Id = navMenu.Id;
        }

        public async Task Update(NavMenuDto model)
        {
            var dbModel = _autoMapper.Map<PlisNavMenu>(model);
            bool isChangeParentId = (model.ParentId.HasValue && dbModel.ParentId == null) ||
                                    (model.ParentId == null && dbModel.ParentId.HasValue) ||
                                     model.ParentId != dbModel.ParentId;
            if (isChangeParentId)
            {
                var parentId = dbModel.ParentId;
                var navMenuChilds = await _navMenuRepository.GetListAsync(u => u.ParentId.Equals(model.Id));
                int? parentsParentId = null;
                if (parentId != null)
                {
                    var navMenuParent = await _navMenuRepository.FindAsync(i => i.Id == parentId.Value);
                    parentsParentId = navMenuParent != null ? navMenuParent.ParentId.Value : null;
                }
                foreach (var item in navMenuChilds)
                {
                    item.ParentId = parentsParentId;
                }
            }
            await _navMenuRepository.UpdateAsync(dbModel);
            await _unitOfWork.SaveChangeAsync();
        }
        public async Task<NavMenuDto> GetByIdAsync(int id)
        {
            var model = await _navMenuRepository.FindAsync(i => i.Id.Equals(id));
            var result = _autoMapper.Map<NavMenuDto>(model);
            return result;
        }

        public async Task<IEnumerable<NavMenuDto>> GetListAsync()
        {
            var list = await _navMenuRepository.GetListAsync();
            if (list.Any())
            {
                var result = _autoMapper.Map<IEnumerable<NavMenuDto>>(list);
                return result;
            }
            else
            {
                return new List<NavMenuDto>();
            }
        }

        public async Task DeleteAsync(int id)
        {
            var model = await _navMenuRepository.FindAsync(u => u.Id.Equals(id));
            if (model != null)
            {
                await _navMenuRepository.DeleteAsync(model);
            }
            var childs = await _navMenuRepository.GetListAsync(u => u.ParentId.HasValue && u.ParentId.Equals(id));
            foreach (var item in childs)
            {
                await _navMenuRepository.DeleteAsync(item);
            }
            await _unitOfWork.SaveChangeAsync();
        }


        public async Task<Paginator<NavMenuDto>> GetPageListAsync(int pageSize, int pageIndex, int menuType, string menuName)
        {
            var pageData = new Paginator<NavMenuDto>(pageSize, pageIndex);
            var count = await _navMenuRepository.GetCountAsync(menuType, menuName);
            var result = await _navMenuRepository.GetPageListAsync(pageSize, pageIndex, menuType, menuName);
            pageData.pageCount = count;
            pageData.data = result.Any() ? _autoMapper.Map<List<NavMenuDto>>(result) : new List<NavMenuDto>(); ;
            return pageData;
        }

        public async Task<bool> HaveChild(int id)
        {
            var result = await _navMenuRepository.FindAsync(u => u.ParentId.HasValue && u.ParentId.Value.Equals(id));
            return result != null;
        }

        public async Task<NavMenuDto> GetByMenuIdAsync(string menuId)
        {
            var result = await _navMenuRepository.FindAsync(u => u.MenuId.Equals(menuId));
            if (result != null)
            {
                return _autoMapper.Map<NavMenuDto>(result);
            }
            return null;
        }


        public async Task<List<NavMenuDto>> GetPermissionNavMenu(string userId, string roleId)
        {
            var userRoleGroups = await _userRoleGroupAppService.GetListAsync(userId, roleId);
            var groupIds = userRoleGroups.Select(x => x.GroupId).Distinct().ToList();
            var result = await _groupAccessibleFunctionAppService.GetFunctionByGroupIds(groupIds);
            var functionIds=result.Select(x=>x.FunctionId).Distinct().ToList();
            var list =await GetListAsync();
            return list.Where(u=>functionIds.Contains(u.MenuId)).ToList();
        }
    }
}

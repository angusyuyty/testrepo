using CADPLIS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Application.Contracts.NavMenus
{
    public interface INavMenuAppService: IBaseAppService
    {
        Task Insert(NavMenuDto model);
        Task Update(NavMenuDto model);
        Task<IEnumerable<NavMenuDto>> GetListAsync();
        Task<NavMenuDto> GetByIdAsync(int id);
        Task<NavMenuDto> GetByMenuIdAsync(string menuId);
        Task DeleteAsync(int id);
        Task<Paginator<NavMenuDto>> GetPageListAsync(int pageSize, int pageIndex, int menuType, string menuName);
        Task<bool> HaveChild(int id);
        Task<List<NavMenuDto>> GetPermissionNavMenu(string userId, string roleId);
    }
}

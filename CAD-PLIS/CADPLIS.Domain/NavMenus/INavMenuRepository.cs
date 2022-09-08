using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Domain.NavMenus
{
    public interface INavMenuRepository
    {
        Task InsertAsync(PlisNavMenu plisNavMenu, bool autoSave = false);
        Task UpdateAsync(PlisNavMenu plisNavMenu, bool autoSave = false);
        Task DeleteAsync(PlisNavMenu plisNavMenu, bool autoSave = false);
        Task<PlisNavMenu> FindAsync(Expression<Func<PlisNavMenu, bool>> whereLambda);
        Task<List<PlisNavMenu>> GetListAsync();
        Task<List<PlisNavMenu>> GetListAsync(Expression<Func<PlisNavMenu, bool>> whereLambda);
        Task<List<PlisNavMenu>> GetPageListAsync(int pageSize, int pageIndex, int menuTyp, string menuName = null);
        Task<int> GetCountAsync(int menuType, string menuName = null);
    }
}

using CADPLIS.Domain.NavMenus;
using CADPLIS.EntityFrameworkCore.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.EntityFrameworkCore.NavMenus
{
    public class NavMenuRepository : EfBaseRepository<PlisNavMenu>, INavMenuRepository
    {
        public NavMenuRepository(PlisDbcontext plisDbcontext) : base(plisDbcontext)
        {

        }

        public async Task DeleteAsync(PlisNavMenu plisNavMenu, bool autoSave = false)
        {
            await RemoveAsync(plisNavMenu, autoSave);
        }

        public async Task<PlisNavMenu> FindAsync(Expression<Func<PlisNavMenu, bool>> whereLambda)
        {
            var result = await FindModelAsync(whereLambda);
            return result;
        }

        public async Task<List<PlisNavMenu>> GetListAsync()
        {
            var result = GetListQuery();
            return await result.ToListAsync();
        }
        public async Task<List<PlisNavMenu>> GetListAsync(Expression<Func<PlisNavMenu, bool>> whereLambda)
        {
            var result =  DbSet.AsNoTracking().Where(whereLambda);
            return await result.ToListAsync();
        }
        public async Task InsertAsync(PlisNavMenu plisNavMenu, bool autoSave = false)
        {
            await AddAsync(plisNavMenu, autoSave);
        }

        public async Task UpdateAsync(PlisNavMenu plisNavMenu, bool autoSave = false)
        {
            await EditAsync(plisNavMenu, autoSave);
        }

        public async Task<List<PlisNavMenu>> GetPageListAsync(int pageSize, int pageIndex, int menuType , string menuName = null)
        {
            var query = GetListQuery(menuType, menuName);
            var result = await query.PageBy(pageSize * pageIndex, pageSize)
               .ToListAsync();
            return result;
        }

        public async Task<int> GetCountAsync(int menuType , string menuName = null)
        {
            var query = GetListQuery(menuType, menuName);

            var totalCount = await query.CountAsync();

            return totalCount;
        }


        protected virtual IQueryable<PlisNavMenu> GetListQuery(int menuType=0 , string menuName = null)
        {
            return DbSet.AsNoTracking()
                .WhereIf(menuType != default, i => i.MenuType != null && i.MenuType.Equals(menuType))
                .WhereIf(!string.IsNullOrEmpty(menuName), i => i.MenuName.Contains(menuName));
        }
    }
}

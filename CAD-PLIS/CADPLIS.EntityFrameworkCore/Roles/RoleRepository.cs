using CADPLIS.Domain.Roles;
using CADPLIS.EntityFrameworkCore.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.EntityFrameworkCore.Roles
{
    public class RoleRepository : EfBaseRepository<RoleInfo>, IRoleRepository
    {
        public RoleRepository(PlisDbcontext plisDbcontext) : base(plisDbcontext)
        {

        }

        public async Task InsertAsync(RoleInfo roleInfo, bool autoSave = false)
        {
            await AddAsync(roleInfo, autoSave);
        }

        public async Task<int> GetCountAsync(string roleId = null, string roleName = null)
        {
            var query = GetListQuery(roleId, roleName);

            var totalCount = await query.CountAsync();

            return totalCount;
        }

        public async Task<List<RoleInfo>> GetPageListAsync(int pageSize, int pageIndex, string roleId, string roleName)
        {
            var query = GetListQuery(roleId, roleName);
            var result = await query.PageBy(pageSize * pageIndex, pageSize)
                .ToListAsync();
            return result;
        }

        protected virtual IQueryable<RoleInfo> GetListQuery(
         string roleId = null,
         string roleName = null)
        {
            return DbSet.AsNoTracking()
                .WhereIf(roleId != null, role => role.RoleId.Contains(roleId))
                .WhereIf(roleName != null, role => role.RoleDescription.Contains(roleName));
        }

        public async Task UpdateAsync(RoleInfo roleInfo, bool autoSave)
        {
            await  EditAsync(roleInfo, autoSave);
        }

        public async Task DeleteAsync(RoleInfo roleInfo, bool autoSave)
        {
            await RemoveAsync(roleInfo, autoSave);
        }

        public async Task<RoleInfo> FindAsync(Expression<Func<RoleInfo, bool>> whereLambda)
        {
            var result = await FindModelAsync(whereLambda);
            return result;
        }
        public async Task<List<RoleInfo>> GetListAsync()
        {
            var result = GetListQuery();
            return await result.ToListAsync();
        }
        public async Task<List<RoleInfo>> GetListBySearchAsync(Expression<Func<RoleInfo, bool>> whereLambda)
        {
            var result = await FindListAsync(whereLambda);
            return result;
        }
    }
}

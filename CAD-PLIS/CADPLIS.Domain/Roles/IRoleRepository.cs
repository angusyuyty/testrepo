using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Domain.Roles
{
    public interface IRoleRepository
    {
        Task InsertAsync(RoleInfo roleInfo,bool autoSave=false);
        Task UpdateAsync(RoleInfo roleInfo, bool autoSave = false);
        Task DeleteAsync(RoleInfo roleInfo, bool autoSave = false);
        Task<RoleInfo> FindAsync(Expression<Func<RoleInfo,bool>> whereLambda);

        Task<int> GetCountAsync(string roleId = null, string roleName = null);
        Task<List<RoleInfo>> GetPageListAsync(int pageSize, int pageIndex, string roleId, string roleName);
        Task<List<RoleInfo>> GetListAsync();
        Task<List<RoleInfo>> GetListBySearchAsync(Expression<Func<RoleInfo, bool>> whereLambda);
    }
}

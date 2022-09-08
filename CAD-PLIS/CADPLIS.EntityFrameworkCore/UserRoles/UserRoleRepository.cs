using CADPLIS.Domain.Users;
using CADPLIS.EntityFrameworkCore.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.EntityFrameworkCore.UserRoles
{
    public class UserRoleRepository: EfBaseRepository<UserRole>, IUserRoleRepository
    {
        private readonly PlisDbcontext _plisDbcontext;
        public UserRoleRepository(PlisDbcontext plisDbcontext) : base(plisDbcontext)
        {
            _plisDbcontext = plisDbcontext;
        }
        public async Task InsertRangeAsync(List<UserRole> model, bool autoSave = false)
        {
            await AddRangeAsync(model, autoSave);
        }
        public async Task ModifyAsync(UserRole model, bool autoSave = false)
        {
            await EditAsync(model, autoSave);
        }

        public async Task DeleteAsync(UserRole model, bool autoSave = false)
        {
            await RemoveAsync(model, autoSave);
        }
        public async Task<UserRole> FindByIdAsync(int id)
        {
            return await FindModelAsync(u => u.UserRoleId == id);
        }
        public async Task<List<UserRole>> FindListAsync(string userId,string roleId=null)
        {
            var result=  DbSet.AsNoTracking().WhereIf(!string.IsNullOrEmpty(userId) ,u => u.UserId == userId)
                                             .WhereIf(!string.IsNullOrEmpty(roleId), u => u.RoleId == roleId);
            return await result.ToListAsync();
        }

        public async Task<UserRole> FindByUserIdAndRoleIdAsync(string userId, string roleId)
        {
            return await FindModelAsync(u => u.UserId.Equals(userId) && u.RoleId.Equals(roleId));
        }

    }
}
